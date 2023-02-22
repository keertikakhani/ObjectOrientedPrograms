using System;
using System.Data;

namespace ObjectOrientedPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Object oriented Programs");

            string path = "C:\\Users\\rishi\\OneDrive\\Desktop\\New\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\Inventory.json";
            FetchInventory obj = new FetchInventory();

            InventoryDetails data = obj.Read(path);

            Console.WriteLine("Types of Rice");
            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
                int price = data.typesOfRice[i].weight * data.typesOfRice[i].price;
                Console.WriteLine("The Price of {0} for {1} kg is {2}", 
                   data.typesOfRice[i].name, data.typesOfRice[i].weight, price);
            }
            Console.WriteLine("**********************");

            Console.WriteLine("Types of Pulses");
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);
                int price = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;
                Console.WriteLine("The Price of {0} for {1} kg is {2}",
                   data.typesOfPulses[i].name, data.typesOfPulses[i].weight, price);
            }
            Console.WriteLine("**********************");

            Console.WriteLine("Types of Wheat");
            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine(data.typesOfWheat[i].price);
                int price = data.typesOfWheat[i].weight * data.typesOfWheat[i].price;
                Console.WriteLine("The Price of {0} for {1} kg is {2}",
                   data.typesOfWheat[i].name, data.typesOfWheat[i].weight, price);
            }
            Console.WriteLine("**********************");

            Console.ReadLine();
        }
    }
}
