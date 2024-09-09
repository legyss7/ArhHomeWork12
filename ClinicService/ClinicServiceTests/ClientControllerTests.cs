using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    public class ClientControllerTests
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _mocClientRepository;

        public ClientControllerTests()
        {
            _mocClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_mocClientRepository.Object);
        }

        [Fact]
        public void GetAllClietsTest()
        {
            // [1.1] Подготовка данных для тестирования

            // [1.2]
            List<Client> list = new List<Client>();
            list.Add(new Client());
            list.Add(new Client());
            list.Add(new Client());

            _mocClientRepository.Setup(repository =>
                repository.GetAll()).Returns(list);

            // [2] Исполнение тестируемого метода
            var operationResult = _clientController.GetAll();

            // [3] Подготовка эталонного результата, проверка результата
            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Client>>(
                ((OkObjectResult)operationResult.Result).Value);

            _mocClientRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());

        }

        public static readonly object[][] CorrectCreateClientData =
        {
            new object[] { new DateTime(1985, 5, 20), "123 1234", "FFFF", "AAAA", "WWW" },
            new object[] { new DateTime(1987, 2, 16), "14", "2FFFF", "2AAAA", "2WWW" },
            new object[] { new DateTime(1975, 1, 25), "13 1234", "3FFFF", "3AAAA", "3WWW" },
        };

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void CreateClientTest(
            DateTime birthday, string document,
            string surName, string firstName, string patronymic)
        {
            _mocClientRepository.Setup(repository => repository
                .Create(It.IsNotNull<Client>()))
                .Returns(1)
                .Verifiable();


            var operationResult = _clientController.Create(new CreateClientRequest
            {
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });


            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(
                ((OkObjectResult)operationResult.Result).Value);

            _mocClientRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

    }
}
