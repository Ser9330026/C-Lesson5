using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte operand1 = 0, operand2 = 0;
            int result;

            #region Коньюкция
            operand1 = 0xff;//255
            operand2 = 0x01;//01
            result = operand1 & operand2;//01
            Console.WriteLine(result);
            #endregion

            #region Дизъюнкция
            operand1 = 0x02;//02
            operand2 = 0x01;//01
            result = operand1 | operand2;//03
            Console.WriteLine(result);
            #endregion

            #region Исключающее или
            operand1 = 0x03;//03
            operand2 = 0x01;//01
            result = operand1 ^ operand2;//02
            Console.WriteLine(result);
            #endregion

            #region Отрицание
            operand1 = 0x01;//03
            //operand2 = 0x01;//01
            result = ~operand1;//-2
            Console.WriteLine(result);
            #endregion

            #region Изменение знака числа
            operand1 = 0x01;//01
            result = ~operand1;
            result++;
            Console.WriteLine(result);
            #endregion

            ////////////////////////////////////


            byte port = 0xF0;
            byte mask = 0x02;
            Console.WriteLine("port = {0:X}", port);

            port = (byte)(port | mask);
            Console.WriteLine("port = {0:X}", port);

            mask = 0xFD;

            port = (byte)(port & mask);
            Console.WriteLine("port = {0:X}", port);
        }
    }
}
