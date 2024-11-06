Este projeto sera implementado em uma empresa !

                    CONECTAR A QUALQUER SERVIDOR LOCAL
1. AJUSTE app.config em connection string para conectar ao Banco de dados desejado!
connectionString="Data Source=IP DO SERVIDOR;Initial Catalog=Cadastro_projeto;Persist Security Info=True;User ID=USUARIO DO DATABASE;Password=SENHA DO USUARIO;Encrypt=False;TrustServerCertificate=True" providerName="Microsoft.Data.SqlClient"/>

2. ATIVE O FIREWALL PARA PORTA 1433 ENTRADA E SAIDA

3. AJUSTE A STRING CONECTION DOS FORMULARIOS(PODE USAR O EXEMPLO 1)~

4. NO SQL Server Configuration Manager ative as portas 1433 para conexao

5. NO SQL SERVER NAS CONFIGURACOES, AJUSTE PARA CONEXAO EXTERNA


COM ESSES PASSOS DITO ACIMA, IREMOS CONSEGUIR FAZER COM QUE A APLICACAO FUNCIONE
