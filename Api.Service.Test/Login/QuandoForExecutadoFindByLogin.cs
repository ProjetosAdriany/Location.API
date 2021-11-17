using System;
using System.Threading.Tasks;
using Api.Domain.DTOs;
using Api.Domain.Interfaces.Services.User;
using Moq;
using Xunit;

namespace Api.Service.Test.User
{
    public class QuandoForExecutadoFindByLogin
    {
        private ILoginService _service;
        private Mock<ILoginService> _serviceMock;

        [Fact(DisplayName = "É possível executar o método FindByLogin")]
        public async Task E_possivel_executar_metodo_findbylogin()
        {
            var email = Faker.Internet.Email();
            var objReturn = new
            {
                authenticated = true,
                created = DateTime.UtcNow,
                expiration = DateTime.UtcNow.AddHours(8),
                accessToken = Guid.NewGuid(),
                userEmail = email,
                userName = Faker.Name.FullName(),
                message = "Usuário Logado"
            };

            var loginDto = new LoginDTO
            {
                Email = email
            };

            _serviceMock = new Mock<ILoginService>();
            _serviceMock.Setup(m => m.findByEmail(loginDto)).ReturnsAsync(objReturn);
            _service = _serviceMock.Object;

            var result = await _service.findByEmail(loginDto);
            Assert.NotNull(result);
        }
    }
}
