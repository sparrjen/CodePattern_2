﻿using Design_Patterns_Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class SimulatedDatabase : IDataRepository
    {
        public string Load(string v)
        {
            return v;
        }

        public string GetAnimal()
        {
            var animal = Load("From Table Animal Where Owner==Steve");
            return animal;
        }

        public string GetCustomer()
        {
            var costomer = Load("From Table Customer Where Name == Steve");
            return costomer;
        }

        public string GetData()
        {
            var data = Load("Dataset A");
            return data;
        }

        public void Save(string data)
        {
            Console.WriteLine($"Saving data \"{data}\"");
        }
    }
}
