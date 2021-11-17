using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.User;
using Moq;
using Xunit;

namespace Api.Service.Test.User
{
    public class QuandoForExecutadoUpdate : UserTests
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;


        [Fact(DisplayName = "É possível executar o método PUT")]
        public async Task E_possivel_executar_metodo_put()
        {
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Put(userUpdateDTO)).ReturnsAsync(userUpdateResultDTO);
            _service = _serviceMock.Object;

            var result = await _service.Put(userUpdateDTO);
            Assert.NotNull(result);
            Assert.Equal(NameUpdate, result.Name);
            Assert.Equal(EmailUpdate, result.Email);

        }

    }
}
