# Controle-de-tarefas
Usei o C# pois esse é uma ferramenta na qual possuo uma familiaridade maior.

- desafios/problemas com os quais você se deparou durante a execução do projeto.
Trabalhar com a hora sem a data foi um ponto que ainda não tinha trabalhado no C#.

- maneiras através das quais você pode melhorar a aplicação, seja em performance, estrutura ou padrões.
Gostaria estruturar melhor as Classes deixando de uma maneira mais intuitiva, criar mais validações e respostas de erro mais personalizadas.

- todas as intruções necessárias para que qualquer pessoa consiga rodar sua aplicação sem maiores problemas.
Um progrma bem simples no qual apresenta na primeira tela de execução dois botões onde vc pode listar as tarefas ou clicar em gestão de tarefas.
Ao clicar em gratão de tarefas vc pode buscas atraves do id uma tarefa para edita-la ou exclu-la ou implesmente inserir novos valores e clicar em criar uma tarefa.

Foi utilizado um bando de dados local o SQlServer com o nome de DesafioUNO 

comandos de criação da tabela: 

create table TB_Tarefas(
ID_Cliente int Identity(1,1),
Ds_Tarefa varchar(500),
Dt_tempoTarefa Time,
Ct_CategoriaTarefa varchar(100),
St_Tarefa varchar(100)
);


select * from TB_Tarefas

insert into TB_Tarefas (Ds_Tarefa,Dt_tempoTarefa,Ct_CategoriaTarefa,St_Tarefa)
values('Antonio','10:55', 'Manutenção', 'Fechada');
