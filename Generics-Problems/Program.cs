﻿using System;
using System.IO;

namespace Generics_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics based problems");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Delete Array Element \n2.Delete using Generic Method \n3.Delete using Generic Class\n4.Find Minimum Number\n5.Find Minimum Using Generic Method \n6 Generic class Find minimum");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Select option");
                    Console.WriteLine("1.Delete Integer \n2.Delete Double element\n3.Delete Char");
                    int select = Convert.ToInt16(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("Delete an Integer Element");
                            Console.WriteLine("Enter How many elements u want to insert");
                            int size = Convert.ToInt32(Console.ReadLine());
                            int[] arr = new int[size];
                            Console.WriteLine("Enter Elements 1 by 1");
                            for (int i = 0; i < size; i++)
                            {
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Plz pick up any element you want to skip");
                            int delete = Convert.ToInt32(Console.ReadLine());
                            DeleteElement.DeleteNumber(arr, delete);
                            break;
                        case 2:
                            Console.WriteLine("Enter How many elements u want to insert");
                            int Doublesize = Convert.ToInt32(Console.ReadLine());
                            double[] doubleArr = new double[Doublesize];
                            Console.WriteLine("Enter Elements 1 by 1");
                            for (int i = 0; i < Doublesize; i++)
                            {
                                doubleArr[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine("Plz pick up any element you want to skip");
                            double doubledelete = Convert.ToDouble(Console.ReadLine());
                            DeleteElement.DeleteElementDubleArray(doubleArr, doubledelete);
                            break;
                        case 3:
                            Console.WriteLine("How many char elements to add into array");
                            int charsize = Convert.ToInt32(Console.ReadLine());
                            char[] charArr = new char[charsize];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < charArr.Length; i++)
                            {
                                charArr[i] = Convert.ToChar(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            char deletechar = Convert.ToChar(Console.ReadLine());

                            DeleteElement.DeleteElementCharArray(charArr, deletechar);
                            break;
                        default:
                            Console.WriteLine("Enter Correct option");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Select option for Generic Method");
                    Console.WriteLine("1.Delete Integer \n2.Delete Double element\n3.Delete Char");
                    int Choose = Convert.ToInt16(Console.ReadLine());
                    switch (Choose)
                    {
                        case 1:
                            Console.WriteLine("How many integer elements to add into method");
                            int size = Convert.ToInt32(Console.ReadLine());
                            int[] arr = new int[size];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < size; i++)
                            {
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            int Intdelete = Convert.ToInt32(Console.ReadLine());
                            DeleteElementGenericMethod.DeleteElement<int>(arr, Intdelete);
                            break;
                        case 2:
                            Console.WriteLine("Enter How many elements u want to insert");
                            int Doublesize = Convert.ToInt32(Console.ReadLine());
                            double[] doubleArr = new double[Doublesize];
                            Console.WriteLine("Enter Elements 1 by 1");
                            for (int i = 0; i < Doublesize; i++)
                            {
                                doubleArr[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine("Plz pick up any element you want to skip");
                            double doubledelete = Convert.ToDouble(Console.ReadLine());
                            DeleteElementGenericMethod.DeleteElement<double>(doubleArr, doubledelete);
                            break;
                        case 3:
                            Console.WriteLine("How many char elements to add into array");
                            int charsize = Convert.ToInt32(Console.ReadLine());
                            char[] charArr = new char[charsize];
                            Console.WriteLine("Enter elements 1 by 1");
                            for (int i = 0; i < charArr.Length; i++)
                            {
                                charArr[i] = Convert.ToChar(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            char deletechar = Convert.ToChar(Console.ReadLine());
                            DeleteElementGenericMethod.DeleteElement<char>(charArr, deletechar);

                            break;
                        default:
                            Console.WriteLine("Enter Correct option");
                            break;

                    }
                    break;
                case 3:
                    Console.WriteLine("Select option for Generic Class");
                    Console.WriteLine("1.Delete Integer \n2.Delete Double element\n3.Delete Char");
                    int Find = Convert.ToInt16(Console.ReadLine());
                    switch (Find)
                    {
                        case 1:
                            Console.WriteLine("How many element u want to insert");
                            int size = Convert.ToInt16(Console.ReadLine());
                            int[] intarr = new int[size];
                            Console.WriteLine("Enter elements 1 by 1");
                            for (int i = 0; i < size; i++)
                            {
                                intarr[i] = Convert.ToInt16(Console.ReadLine());
                            }
                            Console.WriteLine("Plz pickup any element from array");
                            int Intdelete = Convert.ToInt16(Console.ReadLine());
                            DeleteElementGenericClass<int> generic = new DeleteElementGenericClass<int>(intarr, Intdelete);
                            generic.DeleteElement();
                            break;
                        case 2:
                            Console.WriteLine("Enter How many elements u want to insert");
                            int Doublesize = Convert.ToInt32(Console.ReadLine());
                            double[] doubleArr = new double[Doublesize];
                            Console.WriteLine("Enter Elements 1 by 1");
                            for (int i = 0; i < Doublesize; i++)
                            {
                                doubleArr[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine("Plz pick up any element you want to skip");
                            double doubledelete = Convert.ToDouble(Console.ReadLine());
                            DeleteElementGenericClass<double> genericdouble = new DeleteElementGenericClass<double>(doubleArr, doubledelete);
                            genericdouble.DeleteElement();
                            break;
                        case 3:
                            Console.WriteLine("How many char element u want to into array");
                            int charsize = Convert.ToInt32(Console.ReadLine());
                            char[] charArr = new char[charsize];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < charArr.Length; i++)
                            {
                                charArr[i] = Convert.ToChar(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            char deletechar = Convert.ToChar(Console.ReadLine());
                            DeleteElementGenericClass<char> genericchar = new DeleteElementGenericClass<char>(charArr, deletechar);
                            genericchar.DeleteElement();
                            break;

                    }
                    break;

                case 4:
                    Console.WriteLine("Select option for Find Minimum  Int,Float,string");
                    Console.WriteLine("1Minimum Int Value.\n2.Mini double value\n3.mini String ");
                    int Check = Convert.ToInt16(Console.ReadLine());
                    switch (Check)
                    {
                        case 1:
                            Console.WriteLine("Minimum Integer is ");
                            Console.WriteLine(FindMinimum.FindMinIntegerNumbar(10, 20, 30));
                            break;
                        case 2:
                            Console.WriteLine("Minimum double value is :");
                            Console.WriteLine(FindMinimum.FindMinFloatValue(10.2, 20.1, 30.1));
                            break;
                        case 3:
                            Console.WriteLine("Minimum string is :");
                            Console.WriteLine(FindMinimum.FindMinStringValue("Apple", "Banana", "Pineapple"));
                            break;
                    }
                    break;

                case 5:
                    Console.WriteLine("Find Minimum Using Generic Method");
                    Console.WriteLine("Select option for Find Minimum  Int,Float,string");
                    Console.WriteLine("1Minimum Int Value.\n2.Mini double value\n3.mini String ");
                    int Number = Convert.ToInt16(Console.ReadLine());
                    switch (Number)
                    {
                        case 1:
                            Console.WriteLine("Minimum Int Value");
                            Console.WriteLine(FindMinimumGenericMethod.FindMinimumValue<int>(11, 22, 33));
                            break;
                        case 2:
                            Console.WriteLine("Minimum Float Value ");
                            Console.WriteLine(FindMinimumGenericMethod.FindMinimumValue<double>(11.1, 33.3, 66.6));
                            break;
                        case 3:
                            Console.WriteLine("Minimum String Value ");
                            Console.WriteLine(FindMinimumGenericMethod.FindMinimumValue<string>("Ant", "Elephant", "Dog"));
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine("Generic class ");
                    Console.WriteLine("Find Minimum Using Generic Method");
                    Console.WriteLine("Select option for Find Minimum  Int,Float,string");
                    Console.WriteLine("1Minimum Int Value.\n2.Mini double value\n3.mini String ");
                    int choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Minimum Int Value");
                           // FindMinimumGenericClass<int> intGeneric = new FindMinimumGenericClass<int>(1, 2, 3);
                            
                            Console.WriteLine(FindMinimumGenericClass<int>.FindMinimum(100,200,300));
                            break;
                        case 2:
                            Console.WriteLine("Minimum Float Value ");
                            Console.WriteLine(FindMinimumGenericClass<float>.FindMinimum(100.1f, 20.1f, 30.1f));
                            break;
                        case 3:
                            Console.WriteLine("Minimum String Value ");
                            Console.WriteLine(FindMinimumGenericClass<string>.FindMinimum("Ant", "Elephant", "Dog"));
                            break;
                    }
                    break;
            }
        }
            
        
    }
}
