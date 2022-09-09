#language: pt
#encoding: iso-8859-1

Funcionalidade: RecuperarSenhaDeAcesso
	como um novo usuário do sistema eu quero recuperar
	minha senha de acesso de modo que possa gerenciar contatos

Cenário: Recuperação de senha de usuário com sucesso
	Permitir que um usuário realize a recuperação da senha com sucesso

	Dado Eu sou um usuário que já está cadastrado no sistema
	E Acesso a página de recuperação de senha
	E informo o meu email cadastrado
	Quando  Solicito a recuperação da minha senha
	Entao Sistema informa que um email já foi enviado com os dados para recuperação da senha

Cenário: Email inválido para recuperação da senha
	Não permitir a recuperação da senha para email não cadastrados no sistema

	Dado Acesso a página de recuperação de senha
	E informo o meu email que não foi cadastrado no sistema
	Quando  Solicito a recuperação da minha senha
	Entao Sistema informa que o email é inválido


