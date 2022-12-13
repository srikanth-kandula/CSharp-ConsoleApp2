using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'maximumProduct' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY inputArray as parameter.
     */

    public static long maximumProduct(List<int> inputArray)
    {
        long product = 1;
        //individual element
        foreach(int num in inputArray)
        {
            product = product * num;
        }
        inputArray.Sort();
        foreach (int num in inputArray)
        {
            Console.WriteLine(num);
        }
        
        //
        for(int i=2; i<=inputArray.Count; i++)
        {
            int temp = 1;
            for(int j=i-1; j<inputArray.Count; j++)//1, 5
            {
                temp = temp * inputArray[j];
            }
            product = product * temp;
        }

        Console.WriteLine(product);

        return product;
    }



    public static int getMinimumSeconds(List<int> height, int h, int u, int v)
    {
        int minSeconds = 0;
        int numOfCats = height.Count;
        if (2 * u < v)
        {
            minSeconds = numOfCats * u;
        }
        else
        {
            height.Sort();
            int i = 0;
            int j = numOfCats - 1;
            while(i <= j)
            {
                if(i != j && height[j] + height[i] < h)
                {
                    i++;
                    minSeconds = minSeconds + v;
                } else
                {
                    minSeconds = minSeconds + u;
                }
                j--;
            }
        }

        return minSeconds;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int inputArrayCount = Convert.ToInt32(Console.ReadLine().Trim());

        //List<int> inputArray = new List<int>();

        //for (int i = 0; i < inputArrayCount; i++)
        //{
        //    int inputArrayItem = Convert.ToInt32(Console.ReadLine().Trim());
        //    inputArray.Add(inputArrayItem);
        //}

        //long result = Result.maximumProduct(inputArray);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
        List<int> inputArray = new List<int>();
        inputArray.Add(5);
        inputArray.Add(4);
        inputArray.Add(2);
        inputArray.Add(3);
        inputArray.Add(1);
        inputArray.Add(6);
        Result.maximumProduct(inputArray);
        Console.ReadLine();
    }
}
