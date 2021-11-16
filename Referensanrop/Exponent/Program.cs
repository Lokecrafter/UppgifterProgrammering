using System;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 upphöjt till 7: "+Power(10,7));
	        Console.WriteLine("2 upphöjt till 10: "+Power(2, 10));
        }
        ///<param name="b"> Bas. Flyttal, vilket somhelst</param>
        ///<param name="e"> Exponent. Heltal, endast positivt eller 0</param>
        static float Power(float b, int e){
            float returnNumb = 1;
            for(int i = 0; i < e; i++){
                returnNumb *= b;
            }
            return returnNumb;
        }
    }
}
