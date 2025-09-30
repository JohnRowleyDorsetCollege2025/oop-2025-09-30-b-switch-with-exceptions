using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_09_30_b_switch_with_exceptions.Models
{
    public static class ExceptionDriver
    {
        public static void Run()
        {
            Console.WriteLine("Exception Demos");
            IOExceptionDemo();
            InvalidOperationExceptionDemo();
        }
        public static void IOExceptionDemo()
        {

            string filePath = "this-file-does-not-exist.txt";
            try
            {
                string content = File.ReadAllText(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IOException\t caught:\t [ {ex.Message} ]");
            }
        }
        public static void InvalidOperationExceptionDemo()
        {
            Queue<int> numbersQueue = new Queue<int>();


            try
            {
                int number = numbersQueue.Dequeue();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException\t caught:\t [ {ex.Message} ]");
            }

        }

    }
}
