using Microsoft.VisualStudio.TestTools.UnitTesting;
using CZ.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CZ.Domain.Entities;

namespace CZ.Domain.Services.Tests
{
    [TestClass()]
    public class DomainClientServiceTests
    {
        [TestMethod()]
        public void GetSpecialClientsTest()
        {
            var mockRepo = new Mock<IDomainClientService>();

            
            var allclient = new List<Client>();//send list of clients.
            mockRepo.Setup(x => x.GetSpecialClients(allclient)).Returns(List<Client>());

           // var clientService = new DomainClientService();
          //  Assert.Fail();
        }
    }
}