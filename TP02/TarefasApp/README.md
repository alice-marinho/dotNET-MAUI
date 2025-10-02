# TarefasApp

Este projeto é uma aplicação simples de lista de tarefas desenvolvida com .NET MAUI, com foco em navegação hierárquica e gerenciamento de tarefas (adição, edição e exclusão) através de modais.

## Sobre o Projeto

O "TarefasApp" foi criado como parte de um trabalho prático para a disciplina CBTPRDM - ADS 671, ministrada pelo Professor Wellington Tuler Moraes no INSTITUTO FEDERAL DE EDUCAÇÃO, CIÊNCIA E TECNOLOGIA DE SÃO PAULO - CAMPUS CUBATÃO.

A aplicação permite ao usuário:

*   **Visualizar uma lista de tarefas:** Cada item da lista exibe o título e uma breve descrição da tarefa.
*   **Navegar para detalhes da tarefa:** Ao selecionar um item da lista, o aplicativo navega para uma página de detalhes que exibe informações adicionais como data de criação e prioridade.
*   **Editar tarefas:** Na página de detalhes, um botão "Editar" abre um modal que permite alterar o título, descrição, data de criação e prioridade da tarefa.
*   **Excluir tarefas:** Também na página de detalhes, um botão "Excluir" remove a tarefa após uma confirmação.
*   **Adicionar novas tarefas:** Um botão "Adicionar" na página inicial abre um modal para inserir um novo título, descrição, data de criação e prioridade.

## Funcionalidades Implementadas

*   **Página Inicial:** Exibe uma `CollectionView` com as tarefas.
*   **Navegação Hierárquica:** Para visualização de detalhes da tarefa.
*   **Modais:** Utilizados para adição e edição de tarefas.
*   **Passagem de Dados:** Entre páginas e modais para preenchimento de informações.
*   **Diálogo de Confirmação:** Antes da exclusão de uma tarefa.
*   **Layout Agradável e Navegação Intuitiva.**

## Tecnologias Utilizadas

*   **[.NET MAUI](https://learn.microsoft.com/pt-br/dotnet/maui/)**: Framework para desenvolvimento de aplicativos multiplataforma.

## Como Executar o Projeto

1.  **Pré-requisitos:**
    *   Visual Studio com a workload ".NET Multi-platform App UI development" instalada.
    *   SDK do .NET.

2.  **Clonar o repositório:**
    ```bash
    git clone https://github.com/alice-marinho/dotNET-MAUI.git
    cd TarefasApp
    ```

3.  **Abrir no Visual Studio:**
    Abra o arquivo de solução (`.sln`) no Visual Studio.

4.  **Compilar e Executar:**
    Selecione o emulador ou dispositivo desejado e execute o projeto.
