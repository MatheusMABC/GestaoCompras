O projeto Gestão Compras tem por finalidade fazer cadastro de duas entidades: fornecedor júridico e fornecedor fisico.

Antes de executar o projeto é necessário configurar a string de conexão para que a aplicação conecte ao servidor com o banco de dados.

Para fazer essa configuração é necessário abrir o arquivo chamado appsettings.json e preencher as seguintes informações:

Data Source=.\\SQLEXPRESS; Initial Catalog=NomeBancoDados; User ID=NomeUsuario; Password=SenhaUsuario; Integrated Security=False; Persist Security Info=True; MultipleActiveResultSets=true;


Para isso execute o Visual Studio e encontre o console Package Manager Console. Normalmente ele é encontrado no menu do software e está na parte inferior das Ferramentas(Tools). 
Após configurar o arquivo e encontrar oconsole Package Manager Console  é necessário executar o comando update-database para que o Entity Framework crie o banco e as suas tabelas.

