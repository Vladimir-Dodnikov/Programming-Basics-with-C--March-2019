﻿using System;
class Commisions
{
    static void Main()
    {
        string city = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());
        double commisions = -1.0;
        if (city == "Sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                commisions = 0.05;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commisions = 0.07;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commisions = 0.08;
            }
            else if (sales > 10000)
            {
                commisions = 0.12;
            }
        }
        else if (city == "Varna")
        {
            if (sales >= 0 && sales <= 500)
            {
                commisions = 0.045;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commisions = 0.075;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commisions = 0.10;
            }
            else if (sales > 10000)
            {
                commisions = 0.13;
            }
        }
        else if (city == "Plovdiv")
        {
            if (sales >= 0 && sales <= 500)
            {
                commisions = 0.055;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commisions = 0.08;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commisions = 0.12;
            }
            else if (sales > 10000)
            {
                commisions = 0.145;
            }
        }
        if (commisions > 0)
        {
            Console.WriteLine("{0:f2}", sales * commisions);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
