using Exceptions;
using solution;

namespace MainProgram
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                Solution.AllVechiles();
            }
            catch (InitializationException ex)
            {
                Console.WriteLine("InitializationException: " + ex.Message);
            }
            catch (AddException ex)
            {
                Console.WriteLine("AddException: " + ex.Message);
            }
            catch (VehicleNotFoundException ex)
            {
                Console.WriteLine("VehicleNotFoundException: " + ex.Message);
            }
            catch (UpdateAutoException ex)
            {
                Console.WriteLine("UpdateAutoException: " + ex.Message);
            }
            catch (RemoveAutoException ex)
            {
                Console.WriteLine("RemoveAutoException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}