

//  Console.Write("Введите число №1: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число №2: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

//  if (firstNumber == secondNumber)
     
//     { Console.WriteLine ("Значения равны");
//     }
 
//  if (firstNumber > secondNumber)

//     {Console.WriteLine("Максимальное значение №1: " + firstNumber);
//     }


//  if (firstNumber < secondNumber)

//     { Console.WriteLine ("Максимальное значение №2: " + secondNumber);
//     };


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите число №1: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число №2: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число №3: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// int max = firstNumber;

// if (secondNumber> max) 
//    {  max = secondNumber;
//    }
// if (thirdNumber>max) 
//     {  max = thirdNumber;
//     }
//    Console.WriteLine ("Максимальное значение: " + max);




// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

//  Console.Write("Введите число : ");
//  int Number = Convert.ToInt32(Console.ReadLine());

//  if (Number%2==0 ) 
   
//    {Console.WriteLine("Четное число ");
//   }
// else
// {Console.WriteLine("нечетное число ");
    
// }


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

 Console.Write("Введите число N: ");

 int N = Convert.ToInt32(Console.ReadLine());


 int number = 1 ;

 while (number <= N) 
 {
     if (number%2==0)
     { 
         Console.Write(number + " ");
         
     }
     else
     { 
         number++;
         
     }
     number++;
 };



        
