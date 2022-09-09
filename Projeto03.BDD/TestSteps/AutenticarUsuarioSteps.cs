using Bogus;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Projeto03.BDD.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Projeto03.BDD.TestSteps
{
    [Binding]
    public class AutenticarUsuarioSteps
    {
        private readonly IWebDriver _webDriver;
        private readonly string baseUrl = "http://localhost:4200";

        private string _emailUsuario;
        private string _senhaUsuario;
        public AutenticarUsuarioSteps()
        {
            _webDriver = TestsHelper.GetInstance();
           // TestsHelper.SaveSreenshot(_webDriver, DateTime.Now.ToString("ssMMyyyHHmmss"));
        }

        [Given(@"Eu sou um usuário cadastrado no sistema")]
        public void GivenEuSouUmUsuarioCadastradoNoSistema()
        {
            _webDriver.Navigate().GoToUrl($"{baseUrl}/criar-conta");

            var faker = new Faker("pt_BR");

            var nome = faker.Person.FullName;
            var email = faker.Person.Email.ToLower();
            var senha = faker.Internet.Password(8);

            _webDriver.FindElement(By.XPath("/html/body/app-root/div/div/app-register/div/div/div/div/form/div[1]/input"))
                .SendKeys(nome);

            _webDriver.FindElement(By.XPath("/html/body/app-root/div/div/app-register/div/div/div/div/form/div[2]/input"))
                .SendKeys(email);

            _webDriver.FindElement(By.XPath("/html/body/app-root/div/div/app-register/div/div/div/div/form/div[3]/input"))
                .SendKeys(senha);

            _webDriver.FindElement(By.XPath("/html/body/app-root/div/div/app-register/div/div/div/div/form/div[4]/input"))
                .SendKeys(senha);

            _webDriver.FindElement(By.XPath("/html/body/app-root/div/div/app-register/div/div/div/div/form/div[5]/input"))
                .Click();
                    
            //aguardar a exibição da mensagem
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            var element = wait.Until(driver => driver.FindElement(By.XPath("/html/body/app-root/div/div/app-register/div/div/div/div/div[2]/strong")));//endereço/de/onde/vai/aparescer/a/mensagem

            //validar o resultado
             element.Text.Should().Contain("cadastrado com sucesso.");//parte de menssagem de sucesso que aparece 

            //armazenar a senha e o email cadastrados
            _emailUsuario = email;
            _senhaUsuario = senha;
        }

        [Given(@"Acesso a página de autenticação de usuário")]
        public void GivenAcessoAPaginaDeAutenticacaoDeUsuario()
        {
            _webDriver.Navigate().GoToUrl($"{baseUrl}/acessar-conta");

           
        }

        [Given(@"Informo meu email de acesso")]
        public void GivenInformoMeuEmailDeAcesso()
        {
            var elemente = _webDriver.FindElement(By.XPath("/html/body/app-root/div/div/app-login/div/div/div/div/form/div[1]/input"));
            elemente.Clear(); //limpando o campo

            //preencher o campo com o email do usuário cadastrado
            elemente.SendKeys(_emailUsuario);
        }

        [Given(@"Informo minha senha de acesso")]
        public void GivenInformoMinhaSenhaDeAcesso()
        {
            var elemente = _webDriver.FindElement(By.XPath("/html/body/app-root/div/div/app-login/div/div/div/div/form/div[2]/input"));
            elemente.Clear(); //limpando o campo

            //preencher o campo com o email do usuário cadastrado
            elemente.SendKeys(_senhaUsuario);
        }

        [When(@"Solicitar a realização do acesso")]
        public void WhenSolicitarARealizacaoDoAcesso()
        {
            _webDriver.FindElement(By.XPath("/html/body/app-root/div/div/app-login/div/div/div/div/form/div[3]/input"))
                .Click();
           
        }

        [Then(@"Sistema autentica meu usuário com sucesso")]
        public void ThenSistemaAutenticaMeuUsuarioComSucesso()
        {
            //aguardar a exibição da mensagem
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            var element = wait.Until
                (driver => driver.FindElement(By.XPath("/html/body/app-root/div/app-menu-principal/nav/div/div[2]/p/span")));
 
            //verificar se o sistema exibe a mensagem "Seja bem vindo"
            element.Text.Should().Contain("Seja bem vindo,");

            //verificar se o usuário foi redirecionado para a URL (contatos-consulta)
            _webDriver.Url.Should().Contain("contatos-consulta");

            //gerar uma evidencia do teste
            TestsHelper.SaveSreenshot(_webDriver, "AutenticarUsuarioComSucesso");

            //fechar navedador
            //_webDriver.Close();
           // _webDriver.Quit();
        }
        [Given(@"Informo um email não cadastrado")]
        public void GivenInformoUmEmailNaoCadastrado()
        {
            var faker = new Faker("pt_BR");
            var elemente = _webDriver.FindElement
                (By.XPath("/html/body/app-root/div/div/app-login/div/div/div/div/form/div[1]/input"));
            elemente.Clear();
            elemente.SendKeys(faker.Person.Email.ToLower());
        }

        [Given(@"Informo uma senha não cadastrada")]
        public void GivenInformoUmaSenhaNaoCadastrada()
        {
            var faker = new Faker("pt_BR");
            var elemente = _webDriver.FindElement
                (By.XPath("/html/body/app-root/div/div/app-login/div/div/div/div/form/div[2]/input"));
            elemente.Clear();
            elemente.SendKeys(faker.Internet.Password(8));
        }


        [Then(@"Sistema informa que o acesso é negado")]
        public void ThenSistemaInformaQueOAcessoENegado()
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            var element = wait.Until
                (driver => driver.FindElement(By.XPath("/html/body/app-root/div/div/app-login/div/div/div/div/div[2]/strong")));

            //verificar se o sistema exibe a mensagem "Seja bem vindo"
            element.Text.Should().Contain("Falha ao autenticar,");

            //verificar se o usuário foi redirecionado para a URL (contatos-consulta)
            _webDriver.Url.Should().Contain("acessar-conta");

            //gerar uma evidencia do teste
            TestsHelper.SaveSreenshot(_webDriver, "AutenticarUsuarioSemSucesso");

            //fechar navedador
           // _webDriver.Close();
//_webDriver.Quit();
        }

    }
}
