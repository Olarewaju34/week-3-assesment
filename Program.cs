// // // See https://aka.ms/new-console-template for more information
  Console.WriteLine("--------------------Question1 ---------------------");
   Console.Write("enter a number: ");
   int integer1 = Convert.ToInt32(Console.ReadLine());
   Console.Write("enter second number: ");
   int integer2 = Convert.ToInt32(Console.ReadLine());
   while(integer1 < integer2)
   {
   integer1++;
   if (integer1 % 5 == 0)
   {
   Console.WriteLine(integer1);
   }
    }
  Console.WriteLine("------------Question2----------------");
   int FirstTerm = 0;
   int SecondTerm =1;
   int counter = 100;
    int nextterm;
    for (int i = 0; i <= counter; i++)
    {
     Console.WriteLine("{0}",FirstTerm);
     nextterm = FirstTerm+SecondTerm;
      FirstTerm=SecondTerm;
      SecondTerm= nextterm;
     }
     Console.WriteLine("----------------Question3-----------------");
   Console.Write("enter first integer: ");
   int firstint = Convert.ToInt32(Console.ReadLine());
   Console.Write("enter second integer: ");
   int secondint = Convert.ToInt32(Console.ReadLine());
   Console.Write("input third integer: ");
   int thirdint = Convert.ToInt32(Console.ReadLine());
   Console.Write("enter fourth integer: ");
   int fourthint = Convert.ToInt32(Console.ReadLine());
   Console.Write("enter fifth integer: ");
   int fifthint = Convert.ToInt32(Console.ReadLine());
   if(firstint>secondint && firstint>thirdint && firstint>fourthint && firstint>fifthint)
   {
   Console.WriteLine(firstint);
   }
   else if (secondint>firstint && secondint>thirdint && secondint>fourthint && secondint>fifthint)
   {
     Console.WriteLine(secondint);
   }
   else if (thirdint>firstint && thirdint>secondint && thirdint>fourthint && thirdint>fifthint)
   {
   Console.WriteLine(thirdint);
   }
   else if(fourthint>firstint && fourthint>secondint && fourthint>thirdint && fourthint>fifthint)
   {
     Console.WriteLine(fourthint);
   }
   else
   {
     Console.WriteLine(fifthint);
   }
   Console.WriteLine("---------question4--------------");
   Console.Write("enter coefficient of a: ");
   int a = Convert.ToInt32(Console.ReadLine());
   Console.Write("enter coefficient of b: ");
  int b = Convert.ToInt32(Console.ReadLine());
   Console.Write("enter coefficient of c: ");
   int c = Convert.ToInt32(Console.ReadLine());
   double X1;
   double X2;
   int D =  b*b - 4*a*c;
   Console.WriteLine(D);
    if(D < 0)
    {
     Console.WriteLine("it has no real root");
    }
    else if (D==0)
    {
   X1= -b/2*a;
   Console.WriteLine(X1);
    }
    else
    {
   X1 = -b - Math.Sqrt(D)/2*a; 
   X2 = -b + Math.Sqrt(D)/2*a;
   Console.WriteLine($"roots of the equation are {X1} and {X2}");
   }
  Console.WriteLine("-------------------Question5-----------------");
   Random numberGen = new Random();
   int bonus = numberGen.Next(1,10);
   Console.WriteLine($"your bonus score is {bonus}");
    if (bonus == 2 )
    {
      Console.WriteLine(bonus*10);
    }
    else if (bonus == 5)
    {
       Console.WriteLine(bonus *100);
    }else if (bonus ==8 )
    {
       Console.WriteLine(bonus *1000);
    }
    else if (bonus == 0 || bonus>9)
    {
  Console.WriteLine("error!!!");
    }
  Console.WriteLine("------------Question6------------");
   Console.Write("input a number: ");
   int n = Convert.ToInt32(Console.ReadLine());
   for (int value = 1; value <= n; value++)
   {
       if(value % 3 == 0 && value% 7 ==0)
       {
   Console.WriteLine(value);
       }
   }
   Console.WriteLine("---------------------Question7-------------");
Console.Write("printing deck of card: ");
 for (int i = 1; i <= 4; i++)
  {
    for (int j =2; j  <= 14 ; j++)
    {
      switch (i)
      {
       case 1:
       Console.WriteLine("club");
       break;

       case 2:
       Console.WriteLine("diamond");
       break;

       case 3:
       Console.WriteLine("hearts");
    break;
      case 4: 
       Console.WriteLine("spades");
      break;    
      }

      switch (j)
      {
  case 2:
  Console.Write("2-");
  break;
  case 3:
  Console.Write("3-");
  break;
  case 4:
  Console.Write("4-");
  break;
  case 5:
  Console.Write("5-");
  break;
  case 6:
Console.Write("6-");
break;
case 7:
Console.Write("7-");
break;
case 8:
Console.Write("9-");
break;
case 10:
Console.Write("10-");
break;
case 11:
Console.Write("J-");
break;
case 12:
Console.Write("K-");
break;
case 13:
Console.Write("Q-");
break;



      }
    }
    Console.WriteLine();
  }
  Console.WriteLine("--------------Question8------------------");
   int firstterm = 0;
   int secondterm =1;
   Console.Write("enter number: ");
   int input = Convert.ToInt32(Console.ReadLine());
    int term;
    for (int i = 0; i <= input; i++)
    {    Console.WriteLine("{0}",firstterm);
   term = firstterm+secondterm;
      firstterm=secondterm;
      secondterm=term;
     }
     Console.WriteLine("----------------Question9----------------");
 int [,] figures = {{1,2,3,4},
                     {12,13,14,5},
                     {11,15,16,6},
                     {10,9,8,7}
                   };
                   for (int i = 0; i < figures.GetLength(0); i++)
                   {
                     for (int j = 0;  j < figures.GetLength(1); j++)
                     {
                       Console.Write(figures[i,j] + " ");
                     }
                     Console.WriteLine();
                  }
   Console.WriteLine("-------------------Question10-----------------");
    int [] num = new int [20];
    for (int i = 0; i < num.Length; i++)
    {
       Console.Write("enter number: ");
       num[i] = Convert.ToInt32(Console.ReadLine());
          int result = num[i] *5;
     Console.WriteLine(result);
   }
Console.WriteLine("----------------Question11--------------");
  int [] number1 = new int [3];
  int [] number2 = new int[3];
  for (int i = 0; i < number1.Length; i++)
  {
    Console.Write("input a number: ");
      number1[i] = Convert.ToInt32(Console.ReadLine()); 
  }
  Console.WriteLine("second array");
   for (int j = 0; j < number2.Length; j++)
   {
    Console.Write("input a number: ");
    number2[j]= Convert.ToInt32(Console.ReadLine());
   }
   bool isarrayequal = number1.SequenceEqual(number2);
   Console.WriteLine($"is first array equal to second array?? {isarrayequal}");
Console.WriteLine("------------------Question14-----------");
 Console.Write("enter a decimal number: ");
int deciint = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Convert.ToString(deciint,2));
Console.WriteLine("---------------Question15-----------------");
  Console.Write("Enter binary number: ");
    string binarynum = Console.ReadLine();
     Console.WriteLine(Convert.ToInt32(binarynum,2));
Console.WriteLine("------------------Question16-------------");
  Console.Write("Enter decimal number: ");
      long decivalue = Convert.ToInt64(Console.ReadLine());
      Console.WriteLine(Convert.ToString(decivalue,16));
Console.WriteLine("-----------------Question17--------------------");
 Console.Write("Enter hexidecimal value: ");
     string hexavalue = Console.ReadLine();
     Console.WriteLine(Convert.ToInt32(hexavalue,16));
Console.WriteLine("---------------------Question18---------------");
  Console.Write("enter hexadecimal value: ");
string hexaint = Console.ReadLine();
     Console.WriteLine(Convert.ToString(Convert.ToInt32(hexaint,16),2));
Console.WriteLine("------------------------------Question19--------------");
  Console.Write("enter a binary number: ");
  long binary= Convert.ToInt64(Console.ReadLine());
  Console.WriteLine(Convert.ToString(binary,16),2);


  Console.WriteLine("-------------------Question20----------------");
 
  Console.Write("Enter the number of the rows: ");
 int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of the columns: ");
 int columns = Convert.ToInt32(Console.ReadLine());
 int[,] spiral = new int[rows, columns];
 Console.WriteLine("Enter the cells of the matrix:");
 for (int row = 0; row < rows; row++)
 {
 for (int col = 0; col < columns; col++)
 {
 Console.Write("matrix[{0},{1}] = ",row, col);
  spiral[row, col] = Convert.ToInt32(Console.ReadLine());
 }
 }
 for (int row = 0; row < spiral.GetLength(0); row++)
 {
 for (int col = 0; col < spiral.GetLength(1); col++)
 {
 Console.Write($"  {spiral[row, col]}");
 }
 Console.WriteLine();
 }