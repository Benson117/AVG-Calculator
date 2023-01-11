using System;

namespace AVG_Calculator
{
	class Program
	{
		static void Main(string[] args)


		{



			MainMenu();
		}





		static void MainMenu()


		{

			Console.Clear();
			Console.WriteLine("Welcome AVG Calculator");
			Console.WriteLine("");
			Console.WriteLine("Option 1, View Average");
			Console.WriteLine("Option 2, Calculate Average");
			Console.WriteLine("Option 3, Exit ");
			Console.WriteLine("Please type 1 or 2 or 3 to navigate");


			string myoptions;
			myoptions = Console.ReadLine();

			switch (myoptions)


			{

				case "1":
					View_AvgAmount();
					break;



		

				case "2":
					Cal_AvgAmount();
				break;




				case "3":
					Exit();
				break;



			}




			MainMenu();

		}




			static void View_AvgAmount()

			{
			Console.WriteLine("View the Average");
			Console.ReadLine();

		}


			static void Cal_AvgAmount()

			{

			double Dell, Samsung, Lenovo, Hp;

			Console.Write("Enter the amount of Dell = ");

			Dell = int.Parse(Console.ReadLine());
		

			Console.Write("Enter the amount of Samsung = ");
			Samsung = int.Parse(Console.ReadLine());



             Console.Write("Enter the amount of Lenovo = ");
			Lenovo = int.Parse(Console.ReadLine());

			

			Console.Write("Enter the amount of Hp = ");

			 Hp = int.Parse(Console.ReadLine());



			double avg = (Dell + Samsung + Lenovo + Hp) / 4;

			Console.WriteLine("The Average of the products = R" + avg);

			Console.ReadLine();

		}

		static void Exit()

			{
			Console.WriteLine("Are you sure you would like to exit the program");
			Console.ReadLine();

			Console.WriteLine("Press the Enter key on the keyboard to confirm!");
			Console.ReadLine();

			System.Environment.Exit(1);

		}







	}
	}

