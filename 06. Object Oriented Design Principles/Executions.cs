using DataBase;

namespace Executions
{

    public class CarCommand
    {
        private CarDatabase database;

        public CarCommand(CarDatabase database)
        {
            this.database = database;
        }

        public void ProcessInput()
        {
            Console.WriteLine("Enter car information (brand, model, quantity, cost). Enter 'exit' to quit.");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                string[] tokens = input.Split(',');

                if (tokens.Length != 4)
                {
                    Console.WriteLine("Invalid input. Expected: brand, model, quantity, cost.");
                    continue;
                }

                string brand = tokens[0].Trim();
                string model = tokens[1].Trim();

                if (!int.TryParse(tokens[2].Trim(), out int quantity) || quantity < 1)
                {
                    Console.WriteLine("Invalid quantity. Must be a positive integer.");
                    continue;
                }

                if (!decimal.TryParse(tokens[3].Trim(), out decimal cost) || cost < 0)
                {
                    Console.WriteLine("Invalid cost. Must be a non-negative decimal.");
                    continue;
                }

                database.AddCar(brand, model, quantity, cost);
            }

            Console.WriteLine("Enter command: count all, count types, average price, average price type [brand], or exit.");

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "exit")
                {
                    break;
                }

                database.ProcessCommand(command);
            }
        }


    }
    public class Execution
    {
        public static void ExecutionMethod()
        {
            CarDatabase database = CarDatabase.Instance;
            CarCommand command = new CarCommand(database);
            command.ProcessInput();
        }
    }
}
