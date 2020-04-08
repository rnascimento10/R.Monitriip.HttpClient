using FluentAssertions;
using System;
using Xunit;

namespace R.Monitriip.HttpClient.Tests
{
    public class MontriipClientTests
    {
        protected const string URL_HOMOLOGACAO = "http://appservices.antt.gov.br:8000/antt/monitriip.validacao/rest/";



        [Fact]
        public void ClienteDeveSerConfiguradoParaHomologacaoQuandoOConstrutorReceberSomenteOToken()
        {
            //Arrange
            var token = Guid.NewGuid().ToString();
            //Act
            var sut = new MonitriipClient(token);
            //Assert
            sut.BaseAddress.Should().Be(URL_HOMOLOGACAO);
            sut.Timeout.Should().Be(new TimeSpan(0, 0, 3));
        }

        [Fact]
        public void ClienteDeveSerConfiguradoQuandoOConstrutorReceberAUrlEOToken()
        {
            //Arrange
            var token = Guid.NewGuid().ToString();
            var minhaUrl = "http://minhaurl.com.br";

            //Act
            var sut = new MonitriipClient(minhaUrl, token);
            //Assert
            sut.BaseAddress.Should().Be(minhaUrl, token);
            sut.Timeout.Should().Be(new TimeSpan(0, 0, 3));
        }

        [Fact]
        public void ClienteDeveSerConfiguradoQuandoOConstrutorReceberAUrlOTokenEoTimeout()
        {
            //Arrange
            var token = Guid.NewGuid().ToString();
            var minhaUrl = "http://minhaurl.com.br";
            var timeout = 4;

            //Act
            var sut = new MonitriipClient(timeout, minhaUrl, token);

            //Assert
            sut.BaseAddress.Should().Be(minhaUrl, token);
            sut.Timeout.Should().Be(new TimeSpan(0, 0, 4));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void QuandoOClienteReceberAUrlOTokenEoTimeoutMenorOuIgualAZeroOTimeoutDeveSerDe3Segundos(int timeout)
        {
            //Arrange
            var token = Guid.NewGuid().ToString();
            var minhaUrl = "http://minhaurl.com.br";

            //Act
            var sut = new MonitriipClient(timeout, minhaUrl, token);

            //Assert
            sut.BaseAddress.Should().Be(minhaUrl, token);
            sut.Timeout.Should().Be(new TimeSpan(0, 0, 3));
        }


    }
}
