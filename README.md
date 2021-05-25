# ntrodução

Aplicação Web desenvolvida para efetuar a manutenção do cadastro de paciente.


A tela principal apresenta duas opções:

- Cadastro de paciente:

  Ao preencher o formulário para efetuar o cadastro de um paciente e clicar no botão Salvar,
  será feito uma consulta para verificar se o CPF já está cadastrado, se não estiver, 
  então o processo segue para que as informações sejam registradas na base de dados.


- Alteração de paciente:

  Deverá informar um CPF para que seja carregado as informações do participante e clicar no botão Pequisar CPF.
  Ao clicar no botão será verificar se o CPF existe na base de dados, se for encontrado as informações serão 
  carregados na pagina.
  Efetuando a alteração das informações necessárias então pode clicar no botão de Alteração para salvar as informações.



Arquitetura da aplicação:

A aplicação é separada em duas partes:

•	Web - Onde consta as paginas web

•	Mod - Onde consta a arquitetura das camadas de negocio, a estrutura é definida:
     o	Base - Processos para conexão e os processos de integração com base de dados
     o	Entity - Classe para carregamento de dados
     o	Geral - Processos globais
     o	Lib - Processos de negócios
     o	Bll - com os processos referentes ao cadastro e alteração
     o	Geral - com processos globais de uso da aplicação
