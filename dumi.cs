using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words
{
    class Program
    {

        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Recursion rec = new Recursion();
            rec.InputSet = rec.MakeCharArray(inputLine);
            rec.CalcPermutation(0);

            Console.WriteLine(rec.PermutationCount);
        }
       
    }
    class Recursion
    {
        private int elementLevel = -1;
        private int numberOfElements;
        private int[] permutationValue = new int[0];
        private int permutationCount = 0;

        private char[] inputSet;

        public char[] InputSet
        {
            get { return inputSet; }
            set { inputSet = value; }
        }

        public int PermutationCount
        {
            get { return permutationCount; }
            set { permutationCount = value; }
        }

        public char[] MakeCharArray(string InputString)
        {
            char[] charString = InputString.ToCharArray();
            Array.Resize(ref permutationValue, charString.Length);
            numberOfElements = charString.Length;
            return charString;
        }

        public void CalcPermutation(int k)
        {
            elementLevel++;
            permutationValue.SetValue(elementLevel, k);

            if (elementLevel == numberOfElements)
            {
                bool valid = true;
                for (int i = 0; i < permutationValue.Length - 1; i++)
                {
                    if(inputSet[permutationValue[i] - 1] == inputSet[permutationValue[i + 1] - 1])
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    OutputPermutation(permutationValue);
                }
            }
            else
            {
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (permutationValue[i] == 0)
                    {
                        CalcPermutation(i);
                    }
                }
            }
            elementLevel--;
            permutationValue.SetValue(0, k);
        }

        private void OutputPermutation(int[] value)
        {
            PermutationCount++;
        }
    }
}
