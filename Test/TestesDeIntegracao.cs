using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Test
{
    public class TestesDeIntegracao : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<SuaStartup> _factory;

        public TestesDeIntegracao(WebApplicationFactory<SuaStartup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/Livro/GetLivro")]
        [InlineData("/api/Cliente/GetCliente")]
        public async Task Deve_Retornar_Status_Code_200(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
        }

        [Theory]
        [InlineData("/api/Livro/GetLivro", 1)] // Seu ID de Livro
        [InlineData("/api/Cliente/GetCliente", 1)] // Seu ID de Cliente
        public async Task Deve_Retornar_Dados_Corretos(string url, int id)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"{url}/{id}");
            response.EnsureSuccessStatusCode(); // Status Code 200-299

            // Assert
            var content = await response.Content.ReadAsStringAsync();
            var objetoRetornado = JsonConvert.DeserializeObject<SeuTipo>(content); // Substitua SeuTipo pelo tipo de objeto retornado pela API

            // Adicione asserções para garantir que os dados retornados estejam corretos
            Assert.NotNull(objetoRetornado);
            // Adicione mais asserções conforme necessário
        }
    }
}
