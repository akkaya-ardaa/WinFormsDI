﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleServices
{
    public class DogFoodService : IAnimalFoodService
    {
        public void Feed()
        {
            Debug.WriteLine("Dog fed.");
        }
    }
}
