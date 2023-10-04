using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleServices
{
    public class CatService : IAnimalService
    {
        public CatService()
        {
            Debug.WriteLine("Cat service created.");
        }
        public void Sound()
        {
            Debug.WriteLine("Meoww meoww");
        }
    }
}
