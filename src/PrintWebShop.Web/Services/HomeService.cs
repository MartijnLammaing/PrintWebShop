using System.Linq;
using PrintWebShop.Controllers;
using PrintWebShop.Data.DatabaseConfigurations;

namespace PrintWebShop.Services
{
    public class HomeService : IHomeService
    {
        public string GetTest()
        {
            var testdb = new TestContext();
            string bla = testdb.TestClasses.First().TestProperty;
            return bla;
        }
    }
}