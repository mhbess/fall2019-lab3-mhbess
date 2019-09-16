using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milesWalked
{
    class Program
    {
        static void Main(string[] args)
        {
            int userHeight = GetUserHeight();
            int userSteps = GetUserSteps();
            double averageStride = GetAverageStride(userHeight);
            double strideLength = GetStrideLength(averageStride);
            double feetWalked = GetFeetWalked(strideLength, userSteps);
            double milesWalked = GetMilesWalked(feetWalked);
            Console.WriteLine("You walked " + milesWalked + " miles");
            Console.ReadKey();

        }

            static int GetUserHeight()
            {
                Console.WriteLine("How tall are you in inches?");
                int userHeight = int.Parse(Console.ReadLine());
                return userHeight;   
            }


            static int GetUserSteps()
            {
                Console.WriteLine("How many steps do you take a day?");
                int userSteps = int.Parse(Console.ReadLine());
                return userSteps;
            }

            static double GetAverageStride(int userHeight)
            {
                double averageStride = userHeight * 0.413;
                return averageStride;
            }

            static double GetStrideLength(double averageStride)
            {
                double strideLength = averageStride / 12;
                return strideLength;
            }
            
            static double GetFeetWalked(double strideLength, int userSteps)
            {
                double feetWalked = strideLength * userSteps;
                return feetWalked;
            }

            static double GetMilesWalked(double feetWalked)
            {
                double milesWalked = feetWalked / 5280;
                return milesWalked;
            }






        











            


        }
    }

