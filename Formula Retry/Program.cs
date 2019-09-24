using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_Retry
{
    class Program
    {
        
        static float QuestionA(float x)
        {
            float result = x * x + 2 * x - 7;
            return result;
                
        }

        static float QuestionB(float a,float b,float c) ///////////////
        {
            float resultcont = b * 2 - 4 * a * c;

            if (resultcont >= 0)
            {
                float resultcont2 = (float)Math.Sqrt(resultcont);
                float result = resultcont2 / 2 * a;
                return result;
            }

            else
            {
                Console.WriteLine("The polynomial has no roots.");
                return resultcont;
            }

        }

        static float QuestionC(float s, float t, float e)
        {
            float result = s + t * (e - s);
            return result;
        }

        static float QuestionD()
        { 
            float[] x = new float[2];
            float[] y = new float[2];
            float resultcont = (x[2] * x[1]) + (x[2] * x[1]) + (y[2] - y[1]) + (y[2] - y[1]);
            float result = (float)Math.Sqrt(resultcont);
            return result;
        }

        static float QuestionE(float x, float y, float z)
        {
            float P = 0;
            float Q = 0;
            float result = P * x * Q * x + P * y * Q * y + P * z * Q * z;
            return result;
        }

        //static float QuestionF(float a, float b, float c, float d, float x, float y, float z)
        //{
        //    float resultcont = a * x + 0 + b * y + 0 + c * z + d;
        //    float resultcont2 = a * a + b * b + c * c;
        //    float resultcont3 = (float)Math.Sqrt(resultcont2);
        //    float result = resultcont / resultcont3;
        //    return result;
        //}

        //static float QuestionG(float t)
        //{
        //    float P = 0;
        //    float result = ((1 - t) + (1 - t) + (1 - t)) + 3 * ((1 - t) + (1 - t)) * t * P + 3 *         //                    (1 - t) * (t * t) * (P + P) + (t * t * t) * (P + P + P);        //    return result;
        //}

        static void Main(string[] args)
        {
            
            bool testRun = true;
            while (testRun == true) ////////////////////////////////////////////////////////////////
            {
                string read = Console.ReadLine().ToLower();

                if (read == "a")
                {
                    Console.WriteLine("Choose a number for this task");
                    Console.ReadLine();

                    if(read == "")
                    {
                    }

                    //Console.WriteLine(QuestionA(21.45f));
                    Console.WriteLine("Choose question number: a, b, c, d, or e");
                    
                    Console.ReadLine();

                }

                else if (read == "b")
                {
                    Console.WriteLine("Choose three different numbers for this task");
                    Console.ReadLine();

                    if (read == "")
                    {
                        
                    }

                    //Console.WriteLine(QuestionB(2, 3, 4));

                    Console.WriteLine("Choose question number: a, b, c, d, or e");
                    Console.ReadLine();
                }

                else if (read == "c")
                {
                    //Console.WriteLine(QuestionC());
                }

                else if (read == "d")
                {
                    //Console.WriteLine(QuestionD());
                }

                else if (read == "e")
                {
                    //Console.WriteLine(QuestionE());
                }

                //else if (read == "f")
                //{
                //    //Console.WriteLine(QuestionF());
                //}

                //else if (read == "g")
                //{
                //    //Console.WriteLine(QuestionG());
                //}

                else if (read == "exit")
                {
                    testRun = false;
                }

                else
                {
                    Console.WriteLine("Invalid Choice");
                    Console.WriteLine("Choose question number: a, b, c, d, or e");
                }
            }
            Console.WriteLine("Press anything to leave");
            Console.ReadKey();
        }

    }
}
