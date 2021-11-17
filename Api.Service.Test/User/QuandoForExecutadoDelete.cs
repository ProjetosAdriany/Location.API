using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.User;
using Moq;
using Xunit;

namespace Api.Service.Test.User
{
    public class QuandoForExecutadoDelete : UserTests
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact(DisplayName = "É possível executar o método delete")]

        public async Task E_possivel_executar_metodo_delete()
        {
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Delete(Id)).ReturnsAsync(true);
            _service = _serviceMock.Object;

            var result = await _service.Delete(Id);
            Assert.True(result);

        }
    }
}
