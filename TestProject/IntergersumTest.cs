using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Controllers;
using TestApp.Data;
using Assert = NUnit.Framework.Assert;

namespace TestProject
{
    public class IntergersumTest
    {
        private Mock<IntergerSumController> intergerSumController;
        private ApplicationDbContext _context;
        private DbContextOptions<ApplicationDbContext> dbContextOptions;

        [SetUp]
        public void Setup()
        {
            intergerSumController = new Mock<IntergerSumController>(_context);
            _context = new ApplicationDbContext(dbContextOptions);
        }
        [Test]
        public void CheckIntResult()
        {
            var result = intergerSumController.Object.Index(2, 4);
            Assert.IsInstanceOf<OkObjectResult>(result);
        }
        [Test]
        public void TEST()
        {
            var result = intergerSumController.Object.Test(2, 4);
            Assert.IsInstanceOf<OkObjectResult>(result);
        }
    }
}
