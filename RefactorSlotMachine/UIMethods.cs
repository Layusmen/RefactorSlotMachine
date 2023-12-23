﻿using System;
using Microsoft.VisualBasic;
using RefactorSlotMachine;
using System;


namespace RefactorSlotMachine
{
    internal class UIMethods
    {
      
        public static bool WelcomeMessage()
        {
            //First messages
            Console.WriteLine("Welcome to the Amazing Slot Machine!");
            Console.WriteLine("Spin the reels and win big!");

            //Display betting options
            Console.WriteLine("To Spin, Press......");
            Console.WriteLine("- (A) Play all three horizontal lines with $2: Earn $20 for top line wins, $5 for middle or base line wins.");
            Console.WriteLine("- (H) Play all vertical lines with $2: Earn $20 for first line wins, $5 for second or third line wins.");
            Console.WriteLine("- (V) Play horizontal center line alone with $2: Earn $30.");
            Console.WriteLine("- (C) Play vertical center line with $2: Earn $30.");
            Console.WriteLine("- (D) Play diagonals with $2: Earn $20 for any and $30 for the two winning combination.");
            return true;
        }

        public static char ChooseBet(decimal balance)
        {
          

            //Betting amount
            Console.Write("\nPlease choose a betting option (A, H, V, C, D): ");
            char bettingOption = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            //Display the result
            Console.WriteLine("\nSlot Machine Results: \n");


            //Ramdom Pick Generator

            for (int row = 0; row < Constants.ROW_COUNT; row++)
            {
                for (int col = 0; col < Constants.COLUMN_COUNT; col++)
                {
                    int randomIndex = logics.randomPickGenerator.Next(logics.slotSymbols.Count);
                    logics.slots_Output[row, col] = logics.slotSymbols[randomIndex];
                    Console.Write(logics.slots_Output[row, col] + "\t");
                }
                Console.WriteLine();

            }
            //Check if the betting option is valid
            //BET AMOUNT
            if (bettingOption != Constants.HORIZONTAL_LINE && bettingOption != Constants.VERTICAL_LINE && bettingOption != Constants.HOR_CENTER_LINE && bettingOption != Constants.VER_CENTER_LINE && bettingOption != Constants.DIAGONAL_LINE)
            {
                Console.WriteLine("Invalid betting option. Please try again.");
            }
            if (balance < Constants.BET_AMOUNT)
            {
                Console.WriteLine("\nInsufficient funds to play. Game over!");
            }
           return bettingOption;
        }
    }
}