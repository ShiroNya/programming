﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
/*==============================*
 *          TJ Liggett  
 *          Exam 1
 *          CIS-151
 * =============================*/
namespace Exam1
{
    class Program
    {
        #region main method
        static void Main(string[] args)
        {
            //variables
            int id, monthsOverdue;
            DateTime today = new DateTime(); //sets DateTime
            decimal oLoan, interest;
            char choice;
            bool lever = true;
            
            //This section gathers user input
            Write("\nEnter loan ID: ");
            id = Convert.ToInt32(ReadLine());
            Write("Enter original loan amount: ");
            oLoan = Convert.ToDecimal(ReadLine());
            Write("Enter interest rate: ");
            interest = Convert.ToDecimal(ReadLine());
            Write("How many months overdue is the loan? ");
            monthsOverdue = Convert.ToInt32(ReadLine());
            while (lever) {//user stuck in loop until they choose valid choice
                //displays console menu
                choice = ConsoleMenu();
                if (choice == '1')
                {
                    lever = false;
                    AutoLoan(id, today, oLoan, interest, monthsOverdue);
                    break;
                }
                if (choice == '2')
                {
                    lever = false;
                    Mortgage(id, today, oLoan, interest, monthsOverdue);
                    break;
                }
                if (choice == '3')
                {
                    lever = false;
                    PersonalLoan newClient = new PersonalLoan(id, today, oLoan, interest, monthsOverdue);
                    WriteLine(newClient.ToString());
                    break;
                }
                else
                {
                    WriteLine("Invalid selection. Please try again");
                }
            }
            
            WriteLine("Press any key to exit");
            ReadKey(); //keeps program open after running
        }
        #endregion
        #region called methods

        /// <summary>
        /// Calls subclass for auto loan
        /// </summary>
        /// <param name="id"></param>
        /// <param name="today"></param>
        /// <param name="balance"></param>
        /// <param name="interest"></param>
        public static void AutoLoan(int id, DateTime today, decimal balance, decimal interest, int monthsOverdue)
        {
            Write("Enter any downpayments: ");
            decimal downPayment = Convert.ToDecimal(ReadLine());
            AutoLoan newClient = new AutoLoan(downPayment, id, today, balance, interest, monthsOverdue);
            WriteLine(newClient.ToString());
        }

        /// <summary>
        /// Calls subclass for mortgage
        /// </summary>
        /// <param name="id"></param>
        /// <param name="today"></param>
        /// <param name="balance"></param>
        /// <param name="interest"></param>
        public static void Mortgage(int id, DateTime today, decimal balance, decimal interest, int monthsOverdue)
        {
            Write("Enter any downpayments: ");
            decimal downPayment = Convert.ToDecimal(ReadLine());
            Write("Enter the property value: ");
            decimal propertyValue = Convert.ToDecimal(ReadLine());
            Mortgage newClient = new Mortgage(downPayment, propertyValue,  id, today, balance, interest, monthsOverdue);
            WriteLine(newClient.ToString());
        }
        /* -------------------------*     
         *       Console Menu       *
         * -------------------------*/
        public static char ConsoleMenu()
        {
            WriteLine("Select the loan type");
            WriteLine("\t1 - Auto Loan");
            WriteLine("\t2 - Mortgage");
            WriteLine("\t3 - Personal Loan");
            char choice = ReadKey().KeyChar;
            WriteLine();
            for(int x = 1; x <= 3; x++)
            {
                WriteLine(".");
            }
            WriteLine();
            return choice;
        }
        #endregion
    }
}
