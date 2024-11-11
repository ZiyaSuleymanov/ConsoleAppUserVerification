namespace ConsoleAppUserVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            string inputUserAge = Console.ReadLine();
            byte UserAge = Convert.ToByte(inputUserAge);

            Console.WriteLine("Enter wage: ");
            string inputWage = Console.ReadLine();
            int UserWage = Convert.ToInt32(inputWage);

            Console.WriteLine("Enter gender: ");
            string inputGender = Console.ReadLine();

            if (UserAge > 18 && UserWage >= 1000 )
            {
            if (inputGender == "male") 
            {
            Console.WriteLine("You are suitable candidate in the labor market");
                
            }
            else if(inputGender == "female")
            {
            Console.WriteLine("You are a lady suitable for the labor market");    
            }
            else
            {
            { Console.WriteLine("Enter your gender correctly"); }
            }

            }

            else if(UserAge <18 && UserWage < 1000)
            {
            Console.WriteLine("You are not yet of working age"); 
            }

            else 
            {
            Console.WriteLine("No matching data");
            }


        }
    }
}
