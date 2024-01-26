﻿using System;


namespace RefactorSlotMachine
{
    internal class UIMethods
    {
      /// <summary>
      /// Welcome Message
      /// </summary>
      /// <returns></returns>
        public static bool WelcomeMessage()
        {
            
            //First messages
            Console.WriteLine("Welcome to the Amazing Slot Machine!");
            Console.WriteLine("Spin the reels and win big!");
            //Display betting options
            //Display betting options
            Console.WriteLine("To Spin, Press......");
            Console.WriteLine("- (A) Play all three horizontal lines with $2: Earn $20 for one line wins, $40 for two lines win, and $60 for three lines win");
            Console.WriteLine("- (H) Play all vertical lines with $2: Earn $20 for first line wins, $40 for two lines win, and $60 for three lines win");
            Console.WriteLine("- (V) Play horizontal center line alone with $2: Earn $30.");
            Console.WriteLine("- (C) Play vertical center line with $2: Earn $30.");
            Console.WriteLine("- (D) Play diagonals with $2: Earn $20 for any and $60 for the two winning combination.");
            return true;
        }

        /// <summary>
        /// Choose Bet
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public static char ChooseBet()
        {
            //Betting amount
            Console.Write("\nPlease choose a betting option (A, H, V, C, D): ");
            char bettingOption = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            ////Check if the betting option is valid
            if (bettingOption != Constants.HORIZONTAL_LINE && bettingOption != Constants.VERTICAL_LINE && bettingOption != Constants.HOR_CENTER_LINE && bettingOption != Constants.VER_CENTER_LINE && bettingOption != Constants.DIAGONAL_LINE)
            {
                Console.WriteLine("Invalid betting option. Please try again.");
            }
            
          return bettingOption;        
        }

        public static char[,] BettingResult()
        { 
            //Display the result
            Console.WriteLine("\nSlot Machine Results: \n");

            //Ramdom Pick Generator

            for (int row = 0; row < Constants.ROW_COUNT; row++)
             {
                 for (int col = 0; col < Constants.COLUMN_COUNT; col++)
                 {
                    //int randomIndex = Logics.randomPickGenerator.Next(Logics.slotSymbols.Count);
                    //Logics.slots_Output[row, col] = Logics.slotSymbols[randomIndex];
                   Logics.slots_Output = new char[,] { { '1', '1', '1' }, { '1', '1', '1' }, { '1', '0', '1' } };
                    Console.Write(Logics.slots_Output[row, col] + "\t");
                 }
                 Console.WriteLine();

             }
            //Check if the betting option is valid


            return Logics.slots_Output;
        }
    }
}