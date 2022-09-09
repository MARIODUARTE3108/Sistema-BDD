#language: pt
#encoding: iso-8859-1

Funcionalidade: Cadastrar usuário
	como um novo usuário do sistema eu quero realizar
	o cadastro da minha conta de modo que possa gerenciar contatos

Cenario: Cadastro de conta de usuário com sucesso
	permitir que um usuário realize o cadastro de sua conta com sucesso

	Dado Acesso a página de cadastro de usuários
	E Informo o nome do meu usuário
	E Informo o email do meu usuário
	E Informo a senha do meu usuário
	E Confirmo a senha do meu usuário
	Quando Solicitar a realização do cadastro do usuário
	Então  Sistema informa que o usuário foi cadastrado com sucesso

Cenário: Email cadastrado para uoutro usuário
	não permitir o cadastro de usuários com o mesmo email

	Dado Eu sou um usuário já cadastrado no sistema
	E Realizo um cadastro com um email já existente
	Quando  Solicitar a realização do cadastro do usuário
	Então  Sistema informa que o email já está cadastrado para outro usuário