﻿
#region Nullable    
//using System.Net.NetworkInformation;

//string name = null;

//int? num= null;

//if (name == null)
//{
//    Console.WriteLine("dsdsds");
//}

//int? m = 5;
//GetPersonById(m);
//static void GetPersonById(int? id)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Not found");
//    }
//}

#endregion

using DomainLayer.Models;
using NullableDelegateExceptions;
using NullableDelegateExceptions.Constants;
using NullableDelegateExceptions.Exceptions;
using ServicesLayer.Services;
using ServicesLayer.Services.Interfaces;

//PractiseDelegate calculate=new PractiseDelegate();
//calculate.CheckDelegate();
//calculate.CheckWord();
//calculate.ShowString();


//int m = 5;
//int n = 0;
//var res = m / n;
//Console.WriteLine(res);



//try
//{
//    int m = 5;
//    int n = 0;

//    Divide(m,n);

//    var res = m / n;
//int[] arr = { 1, 2, 3, };
//    arr[5] = 100;
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//Divide(5, 1);
//static void Divide(int n,int m)
//{
//    bool isSuccess=false;
//    try
//    {
//        int[] arr = { 1, 2, 3 };
//        arr[5] = 100;
//        var result = n / m;
//        isSuccess = true;
//        Console.WriteLine(result);
//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        isSuccess= false;
//    }
//    finally
//    {
//        string message = string.Empty;
//        if (isSuccess)
//        {
//            message = "Register is ok";
//        }
//        else
//        {
//            message="Something is wrong";
//        }
//        SendEmail(message);
//    }
//}


//static void SendEmail(string message)
//{
//    Console.WriteLine(message);
//}



//Login("pervin123", "pervin12345");
//static void Login(string username, string password)
//{
//	try
//	{
//		if (username == "pervin123" && password == "pervin12345")
//		{
//			Console.WriteLine("Login is success");
//		}
//		else
//		{
//			throw new InvalidLoginException(ExceptionMessages.InvalidLogin);
//		}
//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//	}
//}


//IEmployeeService service = new EmployeeService();
//Console.WriteLine(service.GetCountByAge(26));





//TASK 1: FACTORIAL

//Factorial(-20);
//static void Factorial(int num)
//{
//	int fact = 1;
//	try
//	{
//		if (num > 0)
//		{
//			for (int i = 1; i <= num; i++)
//			{
//				fact *= i;
//			}
//			Console.WriteLine(fact);
//		}
//		else
//		{
//			throw new Exception("Number is not true");
//		}
//	}
//	catch (Exception ex)
//	{

//		Console.WriteLine(ex.Message);
//	}
//}




//TASK 2 : Persons

//PersonPredicate persons=new PersonPredicate();
//persons.CheckDelegate();