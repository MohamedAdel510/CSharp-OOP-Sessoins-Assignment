//////////////////  Assignment 1 OOP /////////////////
using CSharp_OOP_Sessoin_01_Assignment.Enums;
using System.Collections.Specialized;

namespace CSharp_OOP_Sessoin_01_Assignment
{

	class testAccessModifier
	{
		public int testPublic { get; set; }
		private int testPrivate { get; set; }
	}


	internal class Program
	{
		static void Main(string[] args)
		{

			#region Part 01 : 

			#region Q1 Explain with code example how class and struct behave differently 

			//// 1-  class behave as reference type data type 
			//StudentClass std01 = new StudentClass();
			//// Create refernce refers to null
			//// allocate required byte at heap
			//// intialize allocated byte with defualt values
			//// assign  address of allocated object to the ref "std01"

			//std01.id = 1;
			//std01.Name = "Ahmed";

			//StudentClass std02 = std01;

			//Console.WriteLine(std01.ToString());
			//Console.WriteLine(std02.ToString());

			//// if any changing happen for std01 will affect std02

			//std01.Name = "Mohamed";

			//Console.WriteLine(std01.ToString());
			//Console.WriteLine(std02.ToString());

			//// Struct behaves as value type used to represents small lightweight data


			//StudnetStruct std03 = new StudnetStruct();
			//// Note new here behave difference. 
			//std03.Name = "Ahmed";
			//std03.id = 1;

			//StudnetStruct std04 = new StudnetStruct();

			//std03 = std04;

			//Console.WriteLine(std03.Name);
			//Console.WriteLine(std03.id);

			//Console.WriteLine(std04.Name);
			//Console.WriteLine(std04.id);


			#endregion

			#region Q2 : Explain the difference between public and private access modifiers with an example. 

			//testAccessModifier t = new testAccessModifier();
			//// Public Access modifier:  Members are accessibale everywhere
			//t.testPublic = 1;

			//// Private Access modifier:  Members are accessibale with in the class only
			//// t.testPrivate = 1; not allowed for its protection level

			#endregion

			#region Q3 : Describe the steps to create and use a class library in Visual    Studio.

			// first we have to create new project of type class library as toolbox wiht utility class 
			// second we have to add the class library refrence to the console app 
			// make sure you are using the name spaces and handling it's protection level

			#endregion

			#region Q4 : What is a class library? Why do we use class libraries?
			// class library is a separate project that contains reusable classes, has no main method
			// and con not run 
			// benifets
			// Reusability - Organization - Maintenance
			#endregion

			#endregion


			#region Part 02: Movie Ticket Booking System

			//Ticket ticket = new Ticket();

			//do
			//{
			//	Console.Write("Enter Movie Name: ");
			//	ticket.MovieName = Console.ReadLine();
			//} while (string.IsNullOrWhiteSpace(ticket.MovieName));

			//bool isParsed;
			//Ticket_Type type;

			//do
			//{
			//	Console.Write("Enter Ticket Type (Standard, VIP, IMAX): ");
			//	isParsed = Enum.TryParse<Ticket_Type>(Console.ReadLine(), true, out type);
			//} while (!isParsed || !Enum.IsDefined(typeof(Ticket_Type), type));
			//ticket.Type = type;

			//string seat;
			//int number;

			//do
			//{
			//	Console.Write("Enter Seat Row (A, B, C, ..., Z): ");
			//	seat = Console.ReadLine()!.ToUpper();
			//} while (seat.Length != 1 || string.IsNullOrWhiteSpace(seat));

			//do
			//{
			//	Console.Write("Enter Seat Number: ");
			//	isParsed = int.TryParse(Console.ReadLine(), out number);
			//} while (!isParsed);

			//ticket.seatLocation = new(seat[0], number);

			//double price;
			//do
			//{
			//	Console.Write("Enter Price: ");
			//	isParsed = double.TryParse(Console.ReadLine(), out price);
			//} while (!isParsed);

			//ticket.Price = price;

			//double discount;
			//do
			//{
			//	Console.Write("Enter Discount Amount: ");
			//	isParsed = double.TryParse(Console.ReadLine(), out discount);
			//} while (!isParsed);

			//ticket.PrintTicket();

			//Console.WriteLine("===== After Discount =====");
			//Console.WriteLine($"Discount Before: {discount}");
			//ticket.ApplyDiscount(ref discount);
			//Console.WriteLine($"Discount After: {discount}");
			//Console.WriteLine($"Movie\t: {ticket.MovieName}");
			//Console.WriteLine($"Type\t: {ticket.Type}");

			#endregion

			#region Assignment02

			Cinema cinema = new Cinema(3);
			Ticket ticket;

			Console.WriteLine("========== Ticket Booking ==========\n");

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"\nEnter Data For Ticket {i+1}");
				//ticket = new Ticket();
				string name;
				do
				{
					Console.Write("Enter Movie Name: ");
					name = Console.ReadLine()!;
				} while (string.IsNullOrWhiteSpace(name));

				bool isParsed;
				Ticket_Type type;

				do
				{
					Console.Write("Enter Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
					isParsed = Enum.TryParse<Ticket_Type>(Console.ReadLine(), true, out type);
				} while (!isParsed || !Enum.IsDefined(typeof(Ticket_Type), type));
				//ticket.Type = type;

				string seat;
				int number;

				do
				{
					Console.Write("Enter Seat Row (A, B, C, ..., Z): ");
					seat = Console.ReadLine()!.ToUpper();
				} while (seat.Length != 1 || string.IsNullOrWhiteSpace(seat));

				do
				{
					Console.Write("Enter Seat Number: ");
					isParsed = int.TryParse(Console.ReadLine(), out number);
				} while (!isParsed);

				


				double price;
				do
				{
					Console.Write("Enter Price: ");
					isParsed = double.TryParse(Console.ReadLine(), out price);
				} while (!isParsed);

				//ticket.Price = price;


				cinema[i] = new Ticket(name, type, new(seat[0], number), price);
				
			}

			Console.WriteLine("\n=============== All Tickets ===============\n");

			for(int i = 0; i < cinema.Count; i++)
			{
				
				Console.WriteLine(cinema[i]?.ToString());
			}

			Console.WriteLine("\n============= Search by Movie =============\n");

			string movieName;
			do
			{
				Console.Write("Enter movie name to search: ");
				movieName = Console.ReadLine()!;
			} while (string.IsNullOrWhiteSpace(movieName));

			for(int i = 0; i < cinema.Count; i++)
			{
				if (cinema[i]?.MovieName?.ToLower() == movieName.ToLower())
				{
					Console.WriteLine($"Found: {cinema[i]?.ToString()}");
				}
			}

			Console.WriteLine("\n=======================\n");
			Console.WriteLine($"Total Ticket Sold: {Ticket.GetTotalTicketsSold()}");
			Console.WriteLine("\n=======================\n");
			Console.WriteLine($"Book 1 Refrence: {BookingHelper.GenerateBookingReference()}");
			Console.WriteLine($"Book 2 Refrence: {BookingHelper.GenerateBookingReference()}");
			Console.WriteLine("\n=======================\n");
			Console.WriteLine($"group discount for a group of 5 tickets at 80 EGP: {BookingHelper.CalcGroupDiscount(5, 80)}");

			#endregion
		}



	}
}
