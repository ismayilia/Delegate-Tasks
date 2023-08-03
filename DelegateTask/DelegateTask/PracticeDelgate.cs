using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DelegateTask
{
    internal class PracticeDelgate
    {

        //public delegate bool CheckNums(int num); 

        //public void ExecutemEhtod()
        //{
        //    //List<int> nums = new List<int> {1, 2, 3, 5, 7, 9, 12 };  
        //    SumOfOddNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }); // Anonim object bir defe istifade edirik
        //}

        //private void SumOfOddNumbers(List<int> numbers)

        //{
        //    int sum = 0;
        //    foreach (int number in numbers) 
        //    {
        //        if (number%2==1)
        //        {
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}



        //private void SumOfEvenNumbers(List<int> numbers)

        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        if (number % 2 != 1)
        //        {
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}


        //private void SumOfGraterFourNumbers(List<int> numbers)

        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        if (number >4)
        //        {
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}









        // Custom yazilan----------------------------------------------

        //public delegate bool CheckNums(int num);




        //public bool CheckOddNums(int number)
        //{
        //    return number % 2 == 1;
        //}

        //public bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}


        //public bool CheckGreaterFiveNums(int number)
        //{
        //    return number >5;
        //}

        //public void ExecutemEhtod() // Adi bir method cs-de ishletmek ucun, Methodun cagrildigi setr
        //{
        //    //List<int> nums = new List<int> {1, 2, 3, 5, 7, 9, 12 };  
        //    SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckOddNums);// methodun icine gondereceyimiz
        //    SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckEvenNums);
        //    SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckEvenNums);  // Anonim object bir defe istifade edirik
        //}

        //private void SumNumbers(List<int> numbers, CheckNums func)

        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}









        // Sistemin verdiyi---------------------------------------------------



        //public delegate bool CheckNums(int num);


        //public bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}


        //public bool CheckGreaterFiveNums(int number)
        //{
        //    return number > 5;
        //}


        //public bool CheckOddNums(int number)
        //{
        //    return number % 2 == 1;
        //}




        public void ExecutemEhtod() // Adi bir method cs-de ishletmek ucun, Methodun cagrildigi setr
        {
            //List<int> nums = new List<int> {1, 2, 3, 5, 7, 9, 12 };  
            SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, m => m % 2 == 1);// methodun icine gondereceyimiz
            //SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckEvenNums);
            //SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckEvenNums);  // Anonim object bir defe istifade edirik
        }

        private void SumNumbers(List<int> numbers, Predicate<int> func)

        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (func(number))
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }




















        //public void ExecuteMehtod() // Adi bir method cs-de ishletmek ucun, Methodun cagrildigi setr
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9, 12 };

        //    var result = numbers.Where(m => m % 2 == 1).Sum(m => m);
        //    var data = numbers.FirstOrDefault(m => m > 5);
        //    Console.WriteLine(result);

        //}








        //public delegate void ChangeStr(string str);


        //public void StrToLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}


        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}


        //public void ExecuteMethod()
        //{
        //    GetString("Salam", StrToUpper);
        //}



        //private void GetString(string str, ChangeStr func)
        //{
        //    func(str);
        //}















        //public void StrToLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}


        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}


        //public void ExecuteMethod()
        //{
        //    GetString("Salam", StrToUpper);
        //}



        //private void GetString(string str, Action<string> func)
        //{
        //    func(str);
        //}











        //public void StrToLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}


        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}


        //public void ExecuteMethod()
        //{
        //    //Action<string> func = new Action<string>(StrToLower);  1-ci variant instance almaq
        //    Action<string> func = StrToLower;

        //    func += StrToUpper;
        //    func.Invoke("Salamlar");

        //}






        // Bize gelen stringin lengthin qaytarsin


        //public delegate int CheckLength(string str);


        //public int GetLength(string text)
        //{
        //    return text.Length;
        //}


        //public void ExecuteMethod()
        //{
        //    GetStringLength("salam", GetLength);
        //}



        //public void GetStringLength(string str, CheckLength func)
        //{
        //    Console.WriteLine(func(str));

        //}
















        //public int GetLength(string text)
        //{
        //    return text.Length;
        //}


        //public void ExecuteMethod()
        //{
        //    GetStringLength("salam", GetLength);
        //}



        //public void GetStringLength(string str, Func<string,int> func)
        //{
        //    Console.WriteLine(func(str));

        //}






        // Delegate 2 parametr qebul etsin, gelen stringin lengthi-nin  ustune numu gelir qaytarir

        //public int GetLength(string text, int num)
        //{
        //    return text.Length + num;
        //}


        //public void ExecuteMethod()
        //{
        //    GetStringLength("salam", GetLength);
        //}



        //public void GetStringLength(string str, Func<string, int, int> func)
        //{
        //    Console.WriteLine(func(str, 12));

        //}








        //public int GetLength(string text, int num)
        // {
        //    return text.Length + num;
        //}


        //public void ExecuteMethod()
        //{
        //    Func<string, int, int> func = GetLength;
        //    Console.WriteLine(func.Invoke("salam", 100));
        //}















    }
}
