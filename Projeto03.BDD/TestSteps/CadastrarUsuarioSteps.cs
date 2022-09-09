using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Projeto03.BDD.TestSteps
{
    [Binding]
    public class CadastrarUsuarioSteps
    {
        [Given(@"Acesso a página de cadastro de usuários")]
        public void GivenAcessoAPaginaDeCadastroDeUsuarios()
        {
            throw new PendingStepException();
        }

        [Given(@"Informo o nome do meu usuário")]
        public void GivenInformoONomeDoMeuUsuario()
        {
            throw new PendingStepException();
        }

        [Given(@"Informo o email do meu usuário")]
        public void GivenInformoOEmailDoMeuUsuario()
        {
            throw new PendingStepException();
        }

        [Given(@"Informo a senha do meu usuário")]
        public void GivenInformoASenhaDoMeuUsuario()
        {
            throw new PendingStepException();
        }

        [Given(@"Confirmo a senha do meu usuário")]
        public void GivenConfirmoASenhaDoMeuUsuario()
        {
            throw new PendingStepException();
        }

        [When(@"Solicitar a realização do cadastro do usuário")]
        public void WhenSolicitarARealizacaoDoCadastroDoUsuario()
        {
            throw new PendingStepException();
        }

        [Then(@"Sistema informa que o usuário foi cadastrado com sucesso")]
        public void ThenSistemaInformaQueOUsuarioFoiCadastradoComSucesso()
        {
            throw new PendingStepException();
        }

        [Given(@"Eu sou um usuário já cadastrado no sistema")]
        public void GivenEuSouUmUsuarioJaCadastradoNoSistema()
        {
            throw new PendingStepException();
        }

        [Given(@"Realizo um cadastro com um email já existente")]
        public void GivenRealizoUmCadastroComUmEmailJaExistente()
        {
            throw new PendingStepException();
        }

        [Then(@"Sistema informa que o email já está cadastrado para outro usuário")]
        public void ThenSistemaInformaQueOEmailJaEstaCadastradoParaOutroUsuario()
        {
            throw new PendingStepException();
        }

    }
}
