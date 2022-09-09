#language: pt
#encoding: iso-8859-1

Funcionalidade: GerenciarContatos
	como um novo usuário autenticado no sistema eu quero cadastrar,
	consultar, alterar e excluit os meus contatos de modo que possa
	manter uma agenda de contatos

Cenario: Gerenciamento de contatos realizado com sucesso
	permitir que um usuário cadastre, consulte, altere e exclua os seus contatos

	Dado Eu sou um usuário autenticado no sistema
	E Acesso a página de cadastro de contato
	E Informo o nome do contado
	E Informo o email do contato
	E Informo o telefone do contato
	Quando Solicitar a realização do cadastro de contato
	Entao  Sistema informa que o contato foi cadastrado com sucesso

	Dado Eu acesso a página de consulta de contatos
	E seleciono o primeiro contato exibido para edição
	E Altero o nome do contato
	E Altero o email do contato
	E Altero o telefone do contato
	Quando Solicitar a atualização dos dados do contato
	Entao  Sistema informa que o contato foi atualizado com sucesso

	Dado  Eu acesso a página de consulta de contatos
	E seleciono o primeiro contato exibido para exclusão
	Quando Confirmar a realização da exclusao do contato
	Entao  Sistema informa que o contato foi excluído com sucesso