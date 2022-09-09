using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Projeto03.BDD.TestSteps
{
    [Binding]
    public class RecuperarSenhaDeAcessoSteps
    {
        [Given(@"Eu sou um usuário que já está cadastrado no sistema")]
        public void GivenEuSouUmUsuarioQueJaEstaCadastradoNoSistema()
        {
            throw new PendingStepException();
        }

        [Given(@"Acesso a página de recuperação de senha")]
        public void GivenAcessoAPaginaDeRecuperacaoDeSenha()
        {
            throw new PendingStepException();
        }

        [Given(@"informo o meu email cadastrado")]
        public void GivenInformoOMeuEmailCadastrado()
        {
            throw new PendingStepException();
        }

        [When(@"Solicito a recuperação da minha senha")]
        public void WhenSolicitoARecuperacaoDaMinhaSenha()
        {
            throw new PendingStepException();
        }

        [Then(@"Sistema informa que um email já foi enviado com os dados para recuperação da senha")]
        public void ThenSistemaInformaQueUmEmailJaFoiEnviadoComOsDadosParaRecuperacaoDaSenha()
        {
            throw new PendingStepException();
        }

        [Given(@"informo o meu email que não foi cadastrado no sistema")]
        public void GivenInformoOMeuEmailQueNaoFoiCadastradoNoSistema()
        {
            throw new PendingStepException();
        }

        [Then(@"Sistema informa que o email é inválido")]
        public void ThenSistemaInformaQueOEmailEInvalido()
        {
            throw new PendingStepException();
        }

    }
}
