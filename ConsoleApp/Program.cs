using DAL;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFModels models = new EFModels())
            {
                // Just need to do some kind of request to the database to replicate issue.
                List<Test> testEntities = models.Tests.Where(x => !string.IsNullOrWhiteSpace(x.TestString)).ToList();
            }
        }
    }
}
