using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleServices
{
    public class DogService : IAnimalService
    {
        private readonly IAnimalFoodService _foodService;
        public DogService(IAnimalFoodService foodService)
        {
            _foodService = foodService;
            Debug.WriteLine("Dog service created.");
        }
        public void Sound()
        {
            _foodService.Feed();
            Debug.WriteLine("Bark bark bark");
        }
    }
}
