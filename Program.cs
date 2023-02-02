using System;

public class Program
{
    public static void Main()
    {
        /*#region задание 1
		Console.WriteLine("Напишите число от 1-100");
		int num = Convert.ToInt32(Console.ReadLine());
		if(num%5==0&&num%3==0)
		{
			Console.WriteLine("FizzBuzz");
		}
		else if(num%3==0)
		{
			Console.WriteLine("Fizz");
		}
		else if(num%5==0)
		{
			Console.WriteLine("Buzz");
		}
		else if(num<=0&&num>=101)
		{
			Console.WriteLine("Error");
		}
		else if(num%5!=0&&num%3!=0)
		{
			Console.WriteLine(num);
		}
		#endregion*/



        /*#region задание 2
		Console.WriteLine("Введите 2 числа");
		int num2 = Convert.ToInt32(Console.ReadLine());
		int num3 = Convert.ToInt32(Console.ReadLine());
		int result = (num2/100)*num3;
		Console.WriteLine(result);
		#endregion*/



        /*#region задание 3
		Console.WriteLine("Введите 4 цифры");
		int num4=Convert.ToInt32(Console.ReadLine());
		int num5=Convert.ToInt32(Console.ReadLine());
		int num6=Convert.ToInt32(Console.ReadLine());
		int num66=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine($"num4={num4} num5={num5} num6={num6} num66={num66}");
		#endregion*/


        /*
		#region задание 4
		Console.WriteLine("Введите 6-значное число");
		int num7=Convert.ToInt32(Console.ReadLine());
		int n,k=1;
		n=num7;
		int last=n%10;
		
		while (num7 >= 10) 
    { 
        num7/=10;
        k*=10;
		if (num7==last)
		{
		Console.WriteLine(n);
		}
		else
		{
			int ww=n - num7*k + last*k - last+num7;
			Console.WriteLine(ww);
		}
    }
		#endregion*/




        /*#region  задание 5
		Console.WriteLine("Введите дату. День, месяц, число.");
		int day=Convert.ToInt32(Console.ReadLine());
		int month=Convert.ToInt32(Console.ReadLine());
		int year=Convert.ToInt32(Console.ReadLine());
		
		if(month==12||month>=1&&month<=2)
		{
			Console.WriteLine("Winter");
		}
		else if(month>=3&&month<=5)
		{
			Console.WriteLine("Spring");
		}
		else if(month>=6&&month<=8)
		{
			Console.WriteLine("Summer");
		}
		else if(month>=9&&month<=11)
		{
			Console.WriteLine("Fall");
		}
		#endregion*/



        /*#region задание 6
		Console.WriteLine("Введите температуру");	
		int temp=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("1)Температура по фаренгейту\n 2)По цельсию");	
		int val=Convert.ToInt32(Console.ReadLine());
		
		if(val==1)
		{
			int res2=(temp*(5/9))+32;
			Console.WriteLine(res2);
		
		}
		else if(val==2)
		{
			int res=(temp-32)*(5/9);
			Console.WriteLine(res);
		}
		
		#endregion*/


        /*
		#region задание 7
		Console.WriteLine("Введите 2 числа");	
		int n1=Convert.ToInt32(Console.ReadLine());	
		int n2=Convert.ToInt32(Console.ReadLine());	
		
		if(n1>n2)
		{
			Console.WriteLine("Введите правильный диапазон");	
		}
		else if(n1%2==0&&n2%2==0)
		{
		 Console.WriteLine(n1);	
			Console.WriteLine(n2);	
		}
		
		#endregion*/
    }
}
