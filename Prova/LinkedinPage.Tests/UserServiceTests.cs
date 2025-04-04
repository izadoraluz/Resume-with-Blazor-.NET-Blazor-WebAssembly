// BlazorOOP_TDD_Aula.Tests/MensagemServiceTests.cs
using Xunit;
using LinkedinPage.Services;
using System.Collections.Generic;

namespace LinkedinPage.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void GetAll_DeveRetornarListaNaoVazia()
        {
            // Arrange
            IUserService service = new UserService();

            // Act
            List<InformaçõesUser> users = service.GetAll();

            // Assert
            Assert.NotEmpty(users);
        }

        [Fact]
        public void GetById_DeveRetornarUsuarioCorreto()
        {
            // Arrange
            IUserService service = new UserService();
            int userId = 1;

            // Act
            InformaçõesUser user = service.GetById(userId);

            // Assert
            Assert.NotNull(user);
            Assert.Equal(userId, user.Id);
        }
    }
    {
        [Fact]
        public void ObterMensagens_DeveRetornarListaNaoVazia()
        {
            // Arrange
            IMensagemService service = new MensagemService();

            // Act
            List<string> mensagens = service.ObterMensagens();

            // Assert
            Assert.NotEmpty(mensagens);
        }

        [Fact]
        public void ObterMensagens_DeveConterMensagemDeBoasVindas()
        {
            // Arrange
            IMensagemService service = new MensagemService();

            // Act
            List<string> mensagens = service.ObterMensagens();

            // Assert
            Assert.Contains("Olá, bem-vindo à nossa aplicação!", mensagens);
        }
    }
}