Pacotes: dotnet restore

Criacao e Inicializacao do Banco de Dados:

Instalar o EF
dotnet tool install --global dotnet-ef --version 6.0.25

dotnet ef migrations add CriarBancoInicial
dotnet ef database update

Instalar o SQLite Toolbox
Extensoes → Toobolx Compact

SELECTS p/ ver os dados iniciais:
SELECT * FROM Categorias;
SELECT * FROM Tarefas;

Correção do CORS
.. Acho q nem precisou, era outro erro. Erro na API... OK

# Exercicios da Prova

Exercicio 1: --- PATCH DA TAREFA (Alterar Tarefa)
- PATCH 	api/tarefa/alterar

FEITO - Linha 57 TarefaController !
Ex de Tarefa:

{
  "tarefaId": 1,
  "titulo": "Desenvolver Funcionalidade de Listar as Solicitações",
  "descricao": "Precisa fazer a função na API pra listar as S.S.",
  "criadoEm": "2023-11-20T22:03:42.094Z",
  "categoriaId": 1
}

Exemplo 2 - Ja preenche tambem o objeto Categoria.
{
  "tarefaId": 2,
  "titulo": "Estudar Angular",
  "status": false,
  "descricao": "Preparar-se para a aula de Angular",
  "criadoEm": "2023-11-23T19:45:50.5520391",
  "categoriaId": 2
}

RETORNO DO EXEMPLO ACIMA:
{
  "tarefaId": 2,
  "titulo": "Estudar Angular",
  "status": false,
  "descricao": "Preparar-se para a aula de Angular",
  "criadoEm": "2023-11-23T19:45:50.5520391",
  "categoria": {
    "categoriaId": 2,
    "nome": "Estudos",
    "criadoEm": "2023-11-22T19:45:50.5520323"
  },
  "categoriaId": 2
}


Ver se foi criado o PATCH da tarefa ID 1:
SELECT * FROM Tarefas;  -- Sim, foi.

1	Desenvolver Funcionalidade de Listar as Solicitações	Precisa fazer a função na API pra listar as S.S.	2023-11-20 22:03:42.094	1

Tarefas 1 e 2 - GET das Tarefas concluidas e nao concluidas.
GET		api/tarefa/naoconcluidas
GET		api/tarefa/concluidas


^^ Pra fazer esses GET precisa existir o status da tarefa...
dotnet ef migrations add CriacaoStatusTarefa -- Criei na Model e adicionei e fiz Update.

Status em boolean feito no modelo. SELECT p/ ver se cadastrou:
SELECT * FROM Tarefas WHERE status = 0;
SELECT * FROM Tarefas WHERE status = 1;

As Rotas já trazem as tarefas NAO CONCLUIDAS e CONCLUIDAS.


ETAPA DO FRONT END:

GitHub ---- >>> 