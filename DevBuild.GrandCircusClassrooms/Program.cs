using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.GrandCircusClassrooms
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangularRoom roomObject;
            double tmpLength, tmpWidth;
            string userResponse = "";
            bool userValidResponse = false;
            bool userExit = false;

            Console.Write("***********************************************************\n" +
                           "*       Welcome to Dev.Build(2.0) Room Calculator!       *\n" +
                           "**********************************************************\n\n");

            while (!userExit)
            {
                roomObject = new RectangularRoom();
                userValidResponse = false;
                Console.Write("Enter Room Length, in feet: ");
                if (double.TryParse(Console.ReadLine(), out tmpLength))
                {
                    roomObject.Length = tmpLength;
                }

                Console.Write("Enter Room Width, in feet: ");
                if (double.TryParse(Console.ReadLine(), out tmpWidth))
                {
                    roomObject.Width = tmpWidth;
                }

                Console.WriteLine("\nArea is {0} sq. ft.", roomObject.Area);
                Console.WriteLine("Perimeter = {0} ft.\n", roomObject.Perimeter);

                while (!userValidResponse)
                {
                    Console.WriteLine("Enter dimensions for another room? (type y/n or yes/no)");
                    userResponse = Console.ReadLine();
                    switch (userResponse.ToLower())
                    {
                        case "y":
                        case "yes":
                            {
                                //we received a valid response from the user, and user wants to enter another set of dimensions
                                //let's make sure we stay in the program loop by keeping userExit false, and reset to the top of the loop
                                userValidResponse = true;
                                userExit = false;
                               
                                break;
                            }

                        case "n":
                        case "no":
                            {
                                userValidResponse = true;
                                userExit = true;
                                break;
                            }

                        default:
                            {
                                userValidResponse = false;
                                Console.WriteLine("I didn't recognize your response. Please enter y/n or yes/no)");
                                break;
                            }
                    }
                }
            }
        }
    }
}
