using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace class_exercise
{
    class Program
    {

        public static int restartOngoingResult;
        
        static void Main(string[] args)
        {
            MainMenu();

            static void MainMenu()
            {
                Console.WriteLine("1) Enkel kalkylator");
                Console.WriteLine("2) Kalkylator med löpande resultat");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();

                if(choice == 1)
                {
                    SimpleCalculator();
                
                } else if(choice == 2)
                {
                    OngoingResultCalculator();
                }
            }

            static void CanBeDone()
            {
                Console.WriteLine("1) Addition ");
                Console.WriteLine("2) Subtraktion");
                Console.WriteLine("3) Multiplikation");
                Console.WriteLine("4) Division");
            }

            static void OngoingResultCalculator()
            {
                if(restartOngoingResult == 0)
                {
                    restartOngoingResult = 1;
                    restart:
                    Console.WriteLine("Mata in startvärde större än 0: ");
                    double input = double.Parse(Console.ReadLine());
                    if(input > 0)
                    {
                        Calculator.result = input;

                        Console.WriteLine("\n");

                        CanBeDone();

                    } else
                    {
                        Console.Clear();
                        goto restart;
                    }
                
                } else if(restartOngoingResult == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Nuvarande resultat: " + Calculator.result);
                    CanBeDone();
                }
                
                switch (Console.ReadLine())
                {
                    case "1":
                        Input("Addition", "ongoing");
                        MainMenu();
                        break;

                    case "2":
                        Input("Subtraction", "ongoing");
                        MainMenu();
                        break;

                    case "3":
                        Input("Multiplication", "ongoing");
                        MainMenu();
                        break;

                    case "4":
                        Input("Division", "ongoing");
                        MainMenu();
                        break;
                }
            }

            static void SimpleCalculator()
            {
                CanBeDone();

                switch (Console.ReadLine())
                {
                    case "1":
                        Input("Addition", "simple");
                        MainMenu();
                        break;

                    case "2":
                        Input("Subtraction", "simple");
                        MainMenu();
                        break;

                    case "3":
                        Input("Multiplication", "simple");
                        MainMenu();
                        break;

                    case "4":
                        Input("Division", "simple");
                        MainMenu();
                        break;
                }
            }
            
            static void Input(string action, string type)
            {
                if(type == "simple")
                {
                    restartOngoingResult = 0;

                    Console.Clear();
                    Console.WriteLine(action + ": ");
                    Console.WriteLine("Skriv in första värdet: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in andra värdet: ");
                    double n2 = double.Parse(Console.ReadLine());

                    switch (action)
                    {
                        case "Addition":
                            Console.WriteLine("Resultatet är: " + Calculator.Addition(n1, n2));
                            break;

                        case "Subtraction":
                            Console.WriteLine("Resultatet är: " + Calculator.Subtraction(n1, n2));
                            break;

                        case "Multiplication":
                            Console.WriteLine("Resultatet är: " + Calculator.Multiplication(n1, n2));
                            break;

                        case "Division":
                            if(n2 != 0)
                            Console.WriteLine("Resultatet är: " + Calculator.Division(n1, n2));
                            else
                                Console.WriteLine("Går inte att dividera med noll");
                            break;
                    }
                    Console.WriteLine("\n");
                
                } else if(type == "ongoing")
                {
                    Console.Clear();
                    Console.WriteLine(action + ": ");
                    Console.WriteLine("Vad vill du addera " + Calculator.result + " med?: ");
                    double n1 = double.Parse(Console.ReadLine());

                    switch (action)
                    {
                        case "Addition":
                            Console.WriteLine("Resultatet är: " + Calculator.Addition(n1));
                            break;

                        case "Subtraction":
                            Console.WriteLine("Resultatet är: " + Calculator.Subtraction(n1));
                            break;

                        case "Multiplication":
                            Console.WriteLine("Resultatet är: " + Calculator.Multiplication(n1));
                            break;

                        case "Division":
                            if(n1 != 0) 
                                Console.WriteLine("Resultatet är: " + Calculator.Division(n1));
                            else
                                Console.WriteLine("Går inte att dividera med noll");
                            break;
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
