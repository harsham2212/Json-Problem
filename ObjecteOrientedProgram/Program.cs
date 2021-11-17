using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            InventoryMain im = new InventoryMain();
            while (flag)
            {
                Console.WriteLine("Enter option \n 1.Name \n 2.Weight \n 3.Price \n 4.Exit \n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        im.DisplayData(@"E:\BridgeLAbz\Git\ObjectOrientedPrograms\ObjecteOrientedProgram\File\Inventory.json");
                        break;
                    case 2:
                        flag = false;
                        break;

                }
            }
        }
    }
}