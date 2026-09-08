namespace ListaDeTarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNovaTarefa = new Label();
            txtTarefa = new TextBox();
            btnAdicionar = new Button();
            lstTarefas = new CheckedListBox();
            btnRemover = new Button();
            lblContador = new Label();
            SuspendLayout();
            //
            // lblNovaTarefa
            //
            lblNovaTarefa.AutoSize = true;
            lblNovaTarefa.Location = new Point(12, 15);
            lblNovaTarefa.Name = "lblNovaTarefa";
            lblNovaTarefa.Size = new Size(76, 15);
            lblNovaTarefa.TabIndex = 0;
            lblNovaTarefa.Text = "Nova tarefa:";
            //
            // txtTarefa
            //
            txtTarefa.Location = new Point(12, 33);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(280, 23);
            txtTarefa.TabIndex = 1;
            txtTarefa.KeyDown += txtTarefa_KeyDown;
            //
            // btnAdicionar
            //
            btnAdicionar.Location = new Point(300, 32);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(90, 25);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            //
            // lstTarefas
            //
            lstTarefas.CheckOnClick = true;
            lstTarefas.FormattingEnabled = true;
            lstTarefas.Location = new Point(12, 70);
            lstTarefas.Name = "lstTarefas";
            lstTarefas.Size = new Size(378, 202);
            lstTarefas.TabIndex = 3;
            lstTarefas.ItemCheck += lstTarefas_ItemCheck;
            //
            // btnRemover
            //
            btnRemover.Location = new Point(12, 285);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(150, 28);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover selecionada";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            //
            // lblContador
            //
            lblContador.AutoSize = true;
            lblContador.Location = new Point(180, 292);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(0, 15);
            lblContador.TabIndex = 5;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 330);
            Controls.Add(lblContador);
            Controls.Add(btnRemover);
            Controls.Add(lstTarefas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTarefa);
            Controls.Add(lblNovaTarefa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovaTarefa;
        private TextBox txtTarefa;
        private Button btnAdicionar;
        private CheckedListBox lstTarefas;
        private Button btnRemover;
        private Label lblContador;
    }
}
