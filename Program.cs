using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PROID_3
{
    internal class Program
    {

        class QR
        {
            public int CodeGenerator()
            {
                Random random = new Random();

                int num = random.Next(100000000, 999999999);

                return num;
            }
        }

        static void Main(string[] args)
        {
            bool MondayReply = false, TuesdayReply = false, WednesdayReply = false, ThursdayReply = false, FridayReply = false, SatursdayReply = false, SundayReply = false;
            string SelectedDays = "";
            bool Setting = true;

            int TotalPoints = 0;
            int MondayPoints = 0, TuesdayPoints = 0, WednesdayPoints = 0, ThursdayPoints = 0, FridayPoints = 0, SaturdayPoints = 0, SundayPoints = 0;

            string NoPlasticDays = "";
            
            bool NegativePoints = false;

            string ExchangePoints = "";
            int NumberOfVouchers = 0;

            string ExchangeSupermarket = "";

            while (true)
            {
                //Setting of grocery days
                while (Setting == true)
                {
                    //Monday - setting grocery days
                    Console.WriteLine("Do you go to the supermarket on Monday? (Yes/No)");
                    string Reply = Console.ReadLine();
                    if (Reply == "Yes")
                    {
                        MondayReply = true;

                        if (SelectedDays != "")
                        {
                            SelectedDays += ", ";
                        }
                        SelectedDays += "Monday";
                    }
                    else
                    {
                        MondayReply = false;
                    }
                    Console.WriteLine();

                    //Tuesday - setting grocery days
                    Console.WriteLine("Do you go to the supermarket on Tuesday? (Yes/No)");
                    Reply = Console.ReadLine();
                    if (Reply == "Yes")
                    {
                        TuesdayReply = true;

                        if (SelectedDays != "")
                        {
                            SelectedDays += ", ";
                        }
                        SelectedDays += "Tuesday";
                    }
                    else
                    {
                        TuesdayReply = false;
                    }
                    Console.WriteLine();

                    //Wednesday - setting grocery days
                    Console.WriteLine("Do you go to the supermarket on Wednesday? (Yes/No)");
                    Reply = Console.ReadLine();
                    if (Reply == "Yes")
                    {
                        WednesdayReply = true;

                        if (SelectedDays != "")
                        {
                            SelectedDays += ", ";
                        }
                        SelectedDays += "Wednesday";
                    }
                    else
                    {
                        WednesdayReply = false;
                    }
                    Console.WriteLine();

                    //Thursday - setting grocery days
                    Console.WriteLine("Do you go to the supermarket on Thursday? (Yes/No)");
                    Reply = Console.ReadLine();
                    if (Reply == "Yes")
                    {
                        ThursdayReply = true;

                        if (SelectedDays != "")
                        {
                            SelectedDays += ", ";
                        }
                        SelectedDays += "Thursday";
                    }
                    else
                    {
                        ThursdayReply = false;
                    }
                    Console.WriteLine();

                    //Friday - setting grocery days
                    Console.WriteLine("Do you go to the supermarket on Friday? (Yes/No)");
                    Reply = Console.ReadLine();
                    if (Reply == "Yes")
                    {
                        FridayReply = true;

                        if (SelectedDays != "")
                        {
                            SelectedDays += ", ";
                        }
                        SelectedDays += "Friday";
                    }
                    else
                    {
                        FridayReply = false;
                    }
                    Console.WriteLine();

                    //Saturday - setting grocery days
                    Console.WriteLine("Do you go to the supermarket on Saturday? (Yes/No)");
                    Reply = Console.ReadLine();
                    if (Reply == "Yes")
                    {
                        SatursdayReply = true;

                        if (SelectedDays != "")
                        {
                            SelectedDays += ", ";
                        }
                        SelectedDays += "Saturday";
                    }
                    else
                    {
                        SatursdayReply = false;
                    }
                    Console.WriteLine();

                    //Sunday - setting grocery days
                    Console.WriteLine("Do you go to the supermarket on Sunday? (Yes/No)");
                    Reply = Console.ReadLine();
                    if (Reply == "Yes")
                    {
                        SundayReply = true;

                        if (SelectedDays != "")
                        {
                            SelectedDays += ", ";
                        }
                        SelectedDays += "Sunday";
                    }
                    else
                    {
                        SundayReply = false;
                    }
                    Console.WriteLine();

                    //Confirmation of grocery days
                    Console.Write("These are the days that you have selected: ");
                    Console.WriteLine(SelectedDays);
                    Console.WriteLine("\nDo you want to set it again? (Yes/No)");
                    Reply = Console.ReadLine();

                    //Resetting of grocery days
                    if (Reply == "Yes")
                    {
                        MondayReply = false;
                        TuesdayReply = false;
                        WednesdayReply = false;
                        ThursdayReply = false;
                        FridayReply = false;
                        SatursdayReply = false;
                        SundayReply = false;

                        SelectedDays = "";
                        Console.WriteLine();
                        Console.Clear();
                    }
                    else
                    {
                        Setting = false;
                    }
                }

                //Monday
                Console.Clear();
                Console.WriteLine("Monday");
                Console.WriteLine("Waiting for input to activate QR Code... (Press any key)");
                Console.ReadKey();
                Console.Write("\r\n ▄▄▄▄▄▄▄   ▄ ▄ ▄▄▄▄▄▄▄ \r\n █ ▄▄▄ █ ▄ ▄ ▀ █ ▄▄▄ █ \r\n █ ███ █  ▄ ▄█ █ ███ █ \r\n █▄▄▄▄▄█ ▄▀█▀▄ █▄▄▄▄▄█ \r\n ▄▄▄ ▄▄▄▄█ █ ▄▄▄   ▄   \r\n ▀█ █▄█▄▀█  █ █▄█ ▄▀██ \r\n █ ▄▄▄▀▄ ▀▄▄█▀█▄█▀  ▄  \r\n ▄▄▄▄▄▄▄ ██▄ ▄ ▀▀▄ ▀█▄ \r\n █ ▄▄▄ █ █ ▄ ▄ █    ██ \r\n █ ███ █ ▄▀▄█ █▄▄█ ▄▀▄ \r\n █▄▄▄▄▄█ ██▄█▀█▄ ▄  █▄ \r\n");

                //Generate QR number
                QR Monday = new QR();
                int MondayCode = Monday.CodeGenerator();
                Console.WriteLine();
                Console.WriteLine("Code: " + MondayCode.ToString() + "\n");

                Console.WriteLine("Have you scanned your code? (Yes/No)");
                string Scanned = Console.ReadLine();

                if (MondayReply == true)
                {
                    if (Scanned == "Yes")
                    {
                        MondayPoints += 20;
                    }
                    else
                    {
                        MondayPoints -= 20;
                    }
                }
                else
                {
                    if (Scanned == "Yes")
                    {
                        MondayPoints += 10;
                    }
                }

                TotalPoints += MondayPoints;

                if (Scanned == "Yes")
                {
                    if (NoPlasticDays != "")
                    {
                        NoPlasticDays += ", ";
                    }
                    NoPlasticDays += "Monday";
                }

                //Tuesday
                Console.Clear();
                Console.WriteLine("Tuesday");
                Console.WriteLine("Waiting for input to activate QR Code... (Press any key)");
                Console.ReadKey();
                Console.WriteLine("\r\n ▄▄▄▄▄▄▄  ▄ ▄▄ ▄▄▄▄▄▄▄ \r\n █ ▄▄▄ █ ██ ▀▄ █ ▄▄▄ █ \r\n █ ███ █ ▄▀ ▀▄ █ ███ █ \r\n █▄▄▄▄▄█ █ ▄▀█ █▄▄▄▄▄█ \r\n ▄▄ ▄  ▄▄▀██▀▀ ▄▄▄ ▄▄  \r\n ▄▄█ █▄▄███▀ ▄▄▀▀ ▄▄ █ \r\n  ▀██  ▄▄▀ ▄▀▄ ▄  ▀ ██ \r\n ▄▄▄▄▄▄▄ █▄▀▀ ▄ ▄▄ ▄█  \r\n █ ▄▄▄ █  ███▀▀▄  ▄  █ \r\n █ ███ █ ▀█▀▀▄  ██▄ ▀█ \r\n █▄▄▄▄▄█ █▄▀▄▄▀▀██▄ ▄ \r\n");

                //Generate QR number
                QR Tuesday = new QR();
                int TuesdayCode = Tuesday.CodeGenerator();
                Console.WriteLine("Code: " + TuesdayCode.ToString() + "\n");

                Console.WriteLine("Have you scanned your code? (Yes/No)");
                Scanned = Console.ReadLine();

                if (TuesdayReply == true)
                {
                    if (Scanned == "Yes")
                    {
                        TuesdayPoints += 20;
                    }
                    else
                    {
                        TuesdayPoints -= 20;
                    }
                }
                else
                {
                    if (Scanned == "Yes")
                    {
                        TuesdayPoints += 10;
                    }
                }

                TotalPoints += TuesdayPoints;

                if (Scanned == "Yes")
                {
                    if (NoPlasticDays != "")
                    {
                        NoPlasticDays += ", ";
                    }
                    NoPlasticDays += "Tuesday";
                }

                //Wednesday
                Console.Clear();
                Console.WriteLine("Wednesday");
                Console.WriteLine("Waiting for input to activate QR Code... (Press any key)");
                Console.ReadKey();
                Console.WriteLine("\r\n ▄▄▄▄▄▄▄ ▄ ▄▄▄ ▄▄▄▄▄▄▄ \r\n █ ▄▄▄ █ ▄▄▀█  █ ▄▄▄ █ \r\n █ ███ █ █▀ ▄▀ █ ███ █ \r\n █▄▄▄▄▄█ ▄▀█▀█ █▄▄▄▄▄█ \r\n ▄▄▄▄  ▄ ▄▄▄██▄  ▄▄▄ ▄ \r\n ▄▀▀▀▀█▄██  █▀▄▄█▀▀▀▄█ \r\n ▄ ▄▀█ ▄▀ █▄▀▄▄▄ ▀▀ ▄▀ \r\n ▄▄▄▄▄▄▄ ▀▀▀█▄  ▄█  ▀▀ \r\n █ ▄▄▄ █  ▀█ ▄ ▄ ▀██▀  \r\n █ ███ █ █▄▄▀▄ █▀ ▀▀▀  \r\n █▄▄▄▄▄█ █ ▀  █ █▄ ▄ ▀ \r\n");

                //Generate QR number
                QR Wednesday = new QR();
                int WednesdayCode = Wednesday.CodeGenerator();
                Console.WriteLine("Code: " + WednesdayCode.ToString() + "\n");

                Console.WriteLine("Have you scanned your code? (Yes/No)");
                Scanned = Console.ReadLine();

                if (WednesdayReply == true)
                {
                    if (Scanned == "Yes")
                    {
                        WednesdayPoints += 20;
                    }
                    else
                    {
                        WednesdayPoints -= 20;
                    }
                }
                else
                {
                    if (Scanned == "Yes")
                    {
                        WednesdayPoints += 10;
                    }
                }

                TotalPoints += WednesdayPoints;

                if (Scanned == "Yes")
                {
                    if (NoPlasticDays != "")
                    {
                        NoPlasticDays += ", ";
                    }
                    NoPlasticDays += "Wednesday";
                }

                //Thursday

                Console.Clear();
                Console.WriteLine("Thursday");
                Console.WriteLine("Waiting for input to activate QR Code... (Press any key)");
                Console.ReadKey();
                Console.WriteLine("\r\n ▄▄▄▄▄▄▄ ▄▄  ▄ ▄▄▄▄▄▄▄ \r\n █ ▄▄▄ █ ▄▀▄ █ █ ▄▄▄ █ \r\n █ ███ █ █▄▄▀  █ ███ █ \r\n █▄▄▄▄▄█ ▄ ▄ ▄ █▄▄▄▄▄█ \r\n ▄▄▄▄  ▄ ▄▀█  ▄  ▄▄▄ ▄ \r\n ▀ ▄▄▀▄▄█  █ █▄█▄▀▄ ▄█ \r\n ▀█▀ █▀▄▀▄▄█▄▀▀ █▀█ █  \r\n ▄▄▄▄▄▄▄ ▀ █  █▄▄█▄ ▀▀ \r\n █ ▄▄▄ █  ▄██▀▀██ ▀█   \r\n █ ███ █ █▀▀▄ █     ▀  \r\n █▄▄▄▄▄█ █▄▀██ ▀▀█▄▄ ▀ \r\n");

                //Generate QR number
                QR Thursday = new QR();
                int ThursdayCode = Thursday.CodeGenerator();
                Console.WriteLine("Code: " + ThursdayCode.ToString() + "\n");

                Console.WriteLine("Have you scanned your code? (Yes/No)");
                Scanned = Console.ReadLine();

                if (ThursdayReply == true)
                {
                    if (Scanned == "Yes")
                    {
                        ThursdayPoints += 20;
                    }
                    else
                    {
                        ThursdayPoints -= 20;
                    }
                }
                else
                {
                    if (Scanned == "Yes")
                    {
                        ThursdayPoints += 10;
                    }
                }

                TotalPoints += ThursdayPoints;

                if (Scanned == "Yes")
                {
                    if (NoPlasticDays != "")
                    {
                        NoPlasticDays += ", ";
                    }
                    NoPlasticDays += "Thursday";
                }

                //Friday

                Console.Clear();
                Console.WriteLine("Friday");
                Console.WriteLine("Waiting for input to activate QR Code... (Press any key)");
                Console.ReadKey();
                Console.WriteLine("\r\n ▄▄▄▄▄▄▄  ▄▄▄▄ ▄▄▄▄▄▄▄ \r\n █ ▄▄▄ █  █ ▀  █ ▄▄▄ █ \r\n █ ███ █ █▀██▄ █ ███ █ \r\n █▄▄▄▄▄█ ▄ █ █ █▄▄▄▄▄█ \r\n ▄▄   ▄▄▄ █▀▀█   ▄▄    \r\n ▄▀█▄▀ ▄████▄▀▄▀ █ ▀█  \r\n ██ ▀█▄▄ █▄█   ▄ ▀█▀ █ \r\n ▄▄▄▄▄▄▄ █▄▀▀█▀█▄ ▄▄▄  \r\n █ ▄▄▄ █ ▀▀█▀█▀ ██▀▀▄  \r\n █ ███ █  ▄█ ▀ ▄▀███▄▄ \r\n █▄▄▄▄▄█ █ ▀▄ ▄ █ ▀▀▄ \r\n");

                //Generate QR number
                QR Friday = new QR();
                int FridayCode = Friday.CodeGenerator();
                Console.WriteLine("Code: " + FridayCode.ToString() + "\n");

                Console.WriteLine("Have you scanned your code? (Yes/No)");
                Scanned = Console.ReadLine();

                if (FridayReply == true)
                {
                    if (Scanned == "Yes")
                    {
                        FridayPoints += 20;
                    }
                    else
                    {
                        FridayPoints -= 20;
                    }
                }
                else
                {
                    if (Scanned == "Yes")
                    {
                        FridayPoints += 10;
                    }
                }

                TotalPoints += FridayPoints;

                if (Scanned == "Yes")
                {
                    if (NoPlasticDays != "")
                    {
                        NoPlasticDays += ", ";
                    }
                    NoPlasticDays += "Friday";
                }

                //Saturday

                Console.Clear();
                Console.WriteLine("Saturday");
                Console.WriteLine("Waiting for input to activate QR Code... (Press any key)");
                Console.ReadKey();
                Console.WriteLine("\r\n ▄▄▄▄▄▄▄   ▄ ▄ ▄▄▄▄▄▄▄ \r\n █ ▄▄▄ █ █ █▄▀ █ ▄▄▄ █ \r\n █ ███ █ ▄▄▄▄█ █ ███ █ \r\n █▄▄▄▄▄█ █▀█ ▄ █▄▄▄▄▄█ \r\n ▄▄ ▄  ▄▄▀ ▄▄▄ ▄▄▄ ▄▄  \r\n █ █ ██▄▀▀▀██ ▀█▄▀█▄▀█ \r\n ▀ ▄███▄▀█▄ ▄▀▀█ ▄█  ▄ \r\n ▄▄▄▄▄▄▄ █  ▄▄▀██▄▄▄█  \r\n █ ▄▄▄ █  ▀▀ ▄▄██ ▄ █  \r\n █ ███ █ ▀█▀▄ █████▄▀█ \r\n █▄▄▄▄▄█ █  ▀▀▄ ▀▄  ▄  \r\n");

                //Generate QR number
                QR Saturday = new QR();
                int SaturdayCode = Saturday.CodeGenerator();
                Console.WriteLine("Code: " + SaturdayCode.ToString() + "\n");

                Console.WriteLine("Have you scanned your code? (Yes/No)");
                Scanned = Console.ReadLine();

                if (SatursdayReply == true)
                {
                    if (Scanned == "Yes")
                    {
                        SaturdayPoints += 20;
                    }
                    else
                    {
                        SaturdayPoints -= 20;
                    }
                }
                else
                {
                    if (Scanned == "Yes")
                    {
                        SaturdayPoints += 10;
                    }
                }

                TotalPoints += SaturdayPoints;

                if (Scanned == "Yes")
                {
                    if (NoPlasticDays != "")
                    {
                        NoPlasticDays += ", ";
                    }
                    NoPlasticDays += "Saturday";
                }

                //Sunday

                Console.Clear();
                Console.WriteLine("Sunday");
                Console.WriteLine("Waiting for input to activate QR Code... (Press any key)");
                Console.ReadKey();
                Console.WriteLine("\r\n ▄▄▄▄▄▄▄ ▄▄▄▄▄ ▄▄▄▄▄▄▄ \r\n █ ▄▄▄ █ ▀█▄█▀ █ ▄▄▄ █ \r\n █ ███ █ ▄▀ ▀█ █ ███ █ \r\n █▄▄▄▄▄█ █ █ ▄ █▄▄▄▄▄█ \r\n ▄▄▄  ▄▄ ████▄▄▄▄▄  ▄▄ \r\n ▄▀ ██▀▄▄▀▀█   ▄  ▀▄▀█ \r\n ▀ █ █▀▄████ ▀ ▄ ▀█ ██ \r\n ▄▄▄▄▄▄▄ ▀███▄█▀▄▄█▀▀▄ \r\n █ ▄▄▄ █ ▀▄▄█▄███ █  █ \r\n █ ███ █ ▄▄█   ▄▀██▄▄▄ \r\n █▄▄▄▄▄█ █ ▀ ▀ ▄█▄█  ▄ \r\n");

                //Generate QR number
                QR Sunday = new QR();
                int SundayCode = Sunday.CodeGenerator();
                Console.WriteLine("Code: " + SundayCode.ToString() + "\n");

                Console.WriteLine("Have you scanned your code? (Yes/No)");
                Scanned = Console.ReadLine();

                if (SundayReply == true)
                {
                    if (Scanned == "Yes")
                    {
                        SundayPoints += 20;
                    }
                    else
                    {
                        SundayPoints -= 20;
                    }
                }
                else
                {
                    if (Scanned == "Yes")
                    {
                        SundayPoints += 10;
                    }
                }

                TotalPoints += SundayPoints;

                if (Scanned == "Yes")
                {
                    if (NoPlasticDays != "")
                    {
                        NoPlasticDays += ", ";
                    }
                    NoPlasticDays += "Sunday";
                }

                Console.Clear();

                //Breakdown of points for the week
                Console.WriteLine("+-----------------------------------------------------------------------------------------------------------+\r\n|                                                   Points                                                  |\r\n+-------------------------------+-----------------------------------+---------------------------------------+\r\n| Conditions                    | The day is a selected grocery day | The day is not a selected grocery day |\r\n+-------------------------------+-----------------------------------+---------------------------------------+\r\n| Did not opt for a plastic bag | 20                                | 10                                    |\r\n+-------------------------------+-----------------------------------+---------------------------------------+\r\n| Opted for a plastic bag       | -20                               | 0                                     |\r\n+-------------------------------+-----------------------------------+---------------------------------------+\n");

                Console.WriteLine("\nThese are the days that you have selected: " + SelectedDays);
                Console.WriteLine("These are the days you did not take a plastic bag: " + NoPlasticDays + "\n");

                Console.WriteLine("Breakdown of points for the week: \n");
                Console.WriteLine("Monday: " + MondayPoints.ToString());
                Console.WriteLine("Tuesday: " + TuesdayPoints.ToString());
                Console.WriteLine("Wednesday: " + WednesdayPoints.ToString());
                Console.WriteLine("Thursday: " + ThursdayPoints.ToString());
                Console.WriteLine("Friday: " + FridayPoints.ToString());
                Console.WriteLine("Saturday: " + SaturdayPoints.ToString());
                Console.WriteLine("Sunday: " + SundayPoints.ToString());
                Console.WriteLine();

                //Points reset if negative
                if (TotalPoints < 0)
                {
                    TotalPoints = 0;
                    NegativePoints = true;
                }

                if (NegativePoints == true)
                {
                    Console.WriteLine("Since your total points is negative, it has been resetted to 0.");
                    NegativePoints = false;
                }

                //Computation of total points
                Console.WriteLine("Total points: " + TotalPoints.ToString() + "\n");

                //Voucher redemption if accumulated points is sufficient
                if (TotalPoints >= 100)
                {
                    if ((TotalPoints / 100) > 1)
                    {
                        Console.WriteLine("You have enough points to exchange " + TotalPoints / 100 + " vouchers");
                    }
                    else
                    {
                        Console.WriteLine("You have enough points to exchange " + TotalPoints / 100 + " voucher");
                    }

                    Console.WriteLine("Do you want to exchange for these vouchers? (Yes/No)");
                    ExchangePoints = Console.ReadLine();
                    Console.Clear();

                    //Input verification
                    while (ExchangePoints != "Yes" && ExchangePoints != "No")
                    {
                        Console.WriteLine("Invalid Input!\n");

                        if ((TotalPoints / 100) > 1)
                        {
                            Console.WriteLine("You have enough points to exchange " + TotalPoints / 100 + " vouchers");
                        }
                        else
                        {
                            Console.WriteLine("You have enough points to exchange " + TotalPoints / 100 + " voucher");
                        }

                        Console.WriteLine("Do you want to exchange for these vouchers? (Yes/No)");
                        ExchangePoints = Console.ReadLine();
                        Console.Clear();
                    }
                }

                //Exchange of vouchers
                if (ExchangePoints == "Yes")
                {
                    if ((TotalPoints / 100) > 1)
                    {
                        Console.WriteLine("You have enough points to exchange " + TotalPoints / 100 + " vouchers");
                    }
                    else
                    {
                        Console.WriteLine("You have enough points to exchange " + TotalPoints / 100 + " voucher");
                    }

                    Console.WriteLine("How many vouchers do you want to exchange? ");
                    NumberOfVouchers = int.Parse(Console.ReadLine());

                    Console.Clear();

                    //Input verification
                    while (NumberOfVouchers > (TotalPoints/100))
                    {
                        Console.Clear();

                        Console.WriteLine("Invalid Input!");

                        if ((TotalPoints / 100) > 1)
                        {
                            Console.WriteLine("You have enough points to exchange " + TotalPoints / 100 + " vouchers");
                        }
                        else
                        {
                            Console.WriteLine("You have enough points to exchange " + TotalPoints / 100 + " voucher");
                        }

                        Console.WriteLine("How many vouchers do you want to exchange? ");
                        NumberOfVouchers = int.Parse(Console.ReadLine());
                    }

                    Console.Clear();

                    Console.WriteLine("Partner supermarkets");
                    Console.WriteLine("1)Fairprice\n" + "2)Giant\n" + "3)Sheng Siong\n" + "4)Prime\n");
                    Console.WriteLine("Enter the supermarket of your choice: ");
                    ExchangeSupermarket = Console.ReadLine();

                    while (ExchangeSupermarket != "Fairprice" && ExchangeSupermarket != "Giant" && ExchangeSupermarket != "Sheng Siong" && ExchangeSupermarket != "Prime")
                    {
                        Console.Clear();

                        Console.WriteLine("Invalid Input!\n");

                        Console.WriteLine("Partner supermarkets");
                        Console.WriteLine("1)Fairprice\n" + "2)Giant\n" + "3)Sheng Siong\n" + "4)Prime\n");
                        Console.WriteLine("Enter the supermarket of your choice: ");

                        ExchangeSupermarket = Console.ReadLine();
                    }

                    Console.Clear();

                    TotalPoints -= NumberOfVouchers * 100;

                    if (NumberOfVouchers > 1)
                    {
                        Console.WriteLine("You have exchanged " + NumberOfVouchers + " " + ExchangeSupermarket + " vouchers");
                        Console.WriteLine("Your remaining points is " + TotalPoints + "\n");
                    }
                    else
                    {
                        Console.WriteLine("You have exchanged " + NumberOfVouchers + " " + ExchangeSupermarket + " voucher");
                        Console.WriteLine("Your remaining points is " + TotalPoints + "\n");
                    }


                    NumberOfVouchers = 0;
                    ExchangePoints = "";
                }

                //Set grocery days
                Console.WriteLine("Waiting for input to set grocery days for the next week... (Press any key)");
                Console.ReadKey();

                Console.Clear();

                MondayPoints = 0; TuesdayPoints = 0; WednesdayPoints = 0; ThursdayPoints = 0; FridayPoints = 0; SaturdayPoints = 0; SundayPoints = 0;
                NoPlasticDays = "";

                //Confirmation of grocery days
                Console.Write("These are the grocery days that you have selected: ");
                Console.WriteLine(SelectedDays);
                Console.WriteLine("\nDo you want to set it again? (Yes/No)");
                string reply = Console.ReadLine();

                //Resetting grocery days
                if (reply == "Yes")
                {
                    Setting = true;

                    MondayReply = false;
                    TuesdayReply = false;
                    WednesdayReply = false;
                    ThursdayReply = false;
                    FridayReply = false;
                    SatursdayReply = false;
                    SundayReply = false;

                    SelectedDays = "";
                }
                Console.Clear();
            }
        }
    }
}
