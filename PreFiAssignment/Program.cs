using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreFiAssignment
{
    public class MyNameinArray
    {
        public void DisplayName()
        {
            string fullName = "SHINONOME KUUKO KAONASHI";
            fullName = fullName.Replace(" ", "");

            int cols = 5;
            int rows = (int)Math.Ceiling(fullName.Length / (double)cols);

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (index < fullName.Length)
                    {
                        
                        Console.Write(fullName[index] + " ");
                        index++;
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyNameinArray myName = new MyNameinArray();
            myName.DisplayName();
        }
    }
}
