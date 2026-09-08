namespace ListaDeTarefas
{
    public partial class Form1 : Form
    {
        // O arquivo fica na mesma pasta do executavel.
        private readonly string caminhoArquivo = "tarefas.txt";

        public Form1()
        {
            InitializeComponent();
            CarregarTarefas();
            AtualizarContador();
        }

        private void btnAdicionar_Click(object? sender, EventArgs e)
        {
            string texto = txtTarefa.Text.Trim();

            if (texto.Length == 0)
            {
                MessageBox.Show("Digite uma tarefa antes de adicionar.", "Lista de Tarefas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // O segundo parametro do Add e o estado do check (false = nao concluida).
            lstTarefas.Items.Add(texto, false);

            txtTarefa.Clear();
            txtTarefa.Focus();

            SalvarTarefas();
            AtualizarContador();
        }

        private void btnRemover_Click(object? sender, EventArgs e)
        {
            if (lstTarefas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma tarefa para remover.", "Lista de Tarefas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lstTarefas.Items.RemoveAt(lstTarefas.SelectedIndex);

            SalvarTarefas();
            AtualizarContador();
        }

        private void lstTarefas_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            // O ItemCheck dispara ANTES do item mudar de estado. Se eu salvasse aqui
            // direto, gravaria o valor antigo. O BeginInvoke joga a execucao para
            // depois que o WinForms terminou de atualizar o item.
            BeginInvoke(() =>
            {
                SalvarTarefas();
                AtualizarContador();
            });
        }

        private void txtTarefa_KeyDown(object? sender, KeyEventArgs e)
        {
            // Permite adicionar apertando Enter, sem precisar clicar no botao.
            if (e.KeyCode == Keys.Enter)
            {
                btnAdicionar_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void SalvarTarefas()
        {
            var linhas = new List<string>();

            for (int i = 0; i < lstTarefas.Items.Count; i++)
            {
                // Formato: "1;texto" para concluida e "0;texto" para pendente.
                string concluida = lstTarefas.GetItemChecked(i) ? "1" : "0";
                linhas.Add(concluida + ";" + lstTarefas.Items[i].ToString());
            }

            File.WriteAllLines(caminhoArquivo, linhas);
        }

        private void CarregarTarefas()
        {
            if (!File.Exists(caminhoArquivo))
            {
                return;
            }

            foreach (string linha in File.ReadAllLines(caminhoArquivo))
            {
                if (linha.Length == 0)
                {
                    continue;
                }

                // Arquivos salvos na versao antiga guardavam so o texto da tarefa.
                // Essas linhas continuam sendo lidas, como tarefas pendentes.
                bool formatoNovo = linha.Length > 1 && linha[1] == ';'
                                   && (linha[0] == '0' || linha[0] == '1');

                if (formatoNovo)
                {
                    lstTarefas.Items.Add(linha.Substring(2), linha[0] == '1');
                }
                else
                {
                    lstTarefas.Items.Add(linha, false);
                }
            }
        }

        private void AtualizarContador()
        {
            int total = lstTarefas.Items.Count;
            int concluidas = lstTarefas.CheckedItems.Count;

            lblContador.Text = total + " tarefa(s) - " + concluidas + " concluida(s)";
        }
    }
}
