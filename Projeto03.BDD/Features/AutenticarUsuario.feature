#language: pt
#encoding: iso-8859-1

Funcionalidade: Autenticar usuário
	como um usuário cadastrado no sistema
	eu quero acessar minha conta de modo
	que eu possa gerenciar os contatos

	Cenário: Autenticação de usuário com sucesso
	Permitir que um usuário realize autenticação no sistema

	Dado Eu sou um usuário cadastrado no sistema
	E Acesso a página de autenticação de usuário
	E Informo meu email de acesso
	E Informo minha senha de acesso
	Quando Solicitar a realização do acesso
	Então  Sistema autentica meu usuário com sucesso

	Cenário: Acesso Negado
	Bloquear o acesso de um usuário inválido

	Dado Acesso a página de autenticação de usuário
	E Informo um email não cadastrado
	E Informo uma senha não cadastrada
	Quando Solicitar a realização do acesso
	Então Sistema informa que o acesso é negado