# Lista de Tarefas

Aplicativo de lista de tarefas com interface gráfica, feito em C# com Windows Forms. As tarefas ficam salvas em arquivo, então continuam lá quando o programa é fechado e aberto de novo.

## Como funciona

Você digita a tarefa e clica em Adicionar (ou aperta Enter). A tarefa entra na lista com uma caixinha ao lado: marcar a caixinha significa concluída. Para apagar, é só selecionar a tarefa e clicar em Remover.

Toda alteração — adicionar, remover ou marcar como concluída — é gravada na hora em um arquivo `tarefas.txt`, criado na mesma pasta do executável. Ao abrir o programa novamente, a lista é recarregada desse arquivo com o estado de cada tarefa.

## Funcionalidades

- Adicionar tarefas, pelo botão ou apertando Enter
- Marcar e desmarcar tarefas como concluídas
- Remover a tarefa selecionada
- Contador de tarefas totais e concluídas
- Salvamento automático a cada alteração, sem botão de "salvar"
- Recarregamento da lista ao abrir o programa
- Validação: não adiciona tarefa vazia e avisa quando nenhuma tarefa está selecionada para remover

## Tecnologias

- C#
- Windows Forms (.NET 10)

## Como executar

1. Clone o repositório
2. Abra o arquivo `ListaDeTarefas.csproj` no Visual Studio
3. Execute com F5

Requer Windows e .NET 10.

## Formato do arquivo

Cada linha do `tarefas.txt` guarda o estado e o texto da tarefa, separados por ponto e vírgula:

```
0;Estudar estruturas de dados
1;Terminar o portfólio
```

O `1` marca tarefa concluída e o `0` marca pendente. Arquivos salvos numa versão anterior do app, que guardavam apenas o texto, continuam sendo lidos normalmente — as tarefas entram como pendentes.

---

Feito por [Murilo Reis](https://github.com/MuriloReis93) · [Portfólio](https://muriloreis93.github.io)
