﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSequence_7
{
    class Program
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            bool isCorrect = Validator.Validate(args, out string message);
            if (!isCorrect)
            {
                if (!string.IsNullOrEmpty(message))
                {
                    UI.PrintMessage(message);
                    log.Error(message);
                }
                UI.ShowInstruction();
            }

            int number = int.Parse(args[0]);

            ISequence sequence = new SquareSequence(number);
            UI.PrintMessage(sequence.GetStringResult(sequence.GetSequence()));

            Console.ReadLine();
        }
    }
}
