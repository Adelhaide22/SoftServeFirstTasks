using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesSorting_3
{
    class Program
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            bool repeat;
            
            do
            {
                args = ReadTriangle();
                try
                {
                    triangles.Add(Triangle.Create(args[0], double.Parse(args[1]), double.Parse(args[2]), double.Parse(args[3])));
                }
                catch (InvalidTriangleException ex)
                {
                    UI.PrintErrorMessage(ex.Message);                   
                    log.Error(ex.Message);
                }
                repeat = UI.ProposeAgain();

            } while (repeat);

            try
            {
                triangles.Sort(new TriangleDescBySquareComparer());
                UI.PrintTriangleList(triangles);
            }
            catch (CantCompareException ex)
            {
                UI.PrintErrorMessage(ex.Message);
                log.Error(ex.Message);
            }

            Console.Read();
        }

        public static string[] ReadTriangle()
        {
            bool isCorrect;
            string[] args;

            do
            {
                args = UI.ReadParameters();
                isCorrect = Validator.Validate(args, out string message);
                if (!isCorrect)
                {
                    if (!string.IsNullOrEmpty(message))
                    {
                        UI.PrintErrorMessage(message);
                        log.Error(message);
                    }
                    UI.ShowInstruction();
                }
            } while (!isCorrect);

            return args;
        }
    }
}
