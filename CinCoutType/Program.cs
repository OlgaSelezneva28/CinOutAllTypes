using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinCoutType
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Привести к Byte");
            Console.WriteLine("2. Привести к SByte");
            Console.WriteLine("3. Привести к Int16");
            Console.WriteLine("4. Привести к Int32");
            Console.WriteLine("5. Привести к Int64");
            Console.WriteLine("6. Привести к uInt16");
            Console.WriteLine("7. Привести к uInt32");
            Console.WriteLine("8. Привести к uInt64");
            Console.WriteLine("9. Привести к Single");
            Console.WriteLine("10. Привести к Double");
            Console.WriteLine("11. Привести к Boolean");
            Console.WriteLine("12. Привести к Char");
            Console.WriteLine("13. Привести к Decimal");
            Console.WriteLine("14. Привести к DateTime");
            Console.WriteLine("15. Привести к String");
            Console.WriteLine(" ");


            Console.WriteLine("Введите число, которое надо преобразовать: ");
            string str;
            str = Console.ReadLine();
            Console.WriteLine("Введите тип данных (соответствующий таблице), к которому нужно преобразовать число: ");
            string str2;
            str2 = Console.ReadLine();

            switch (str2)
            {
                case "Byte":
                    Console.WriteLine(Convert.ToByte(str));
                    break;
                case "SByte":
                    Console.WriteLine(Convert.ToSByte(str));
                    break;
                case "Int16":
                    Console.WriteLine(Convert.ToInt16(str));
                    break;
                case "Int32":
                    Console.WriteLine(Convert.ToInt32(str));
                    break;
                case "Int64":
                    Console.WriteLine(Convert.ToInt64(str));
                    break;
                case "uInt16":
                    Console.WriteLine(Convert.ToUInt16(str));
                    break;
                case "uInt32":
                    Console.WriteLine(Convert.ToUInt32(str));
                    break;
                case "uInt64":
                    Console.WriteLine(Convert.ToUInt64(str));
                    break;
                case "Single":
                    Console.WriteLine(Convert.ToSingle(str));
                    break;
                case "Double":
                    Console.WriteLine(Convert.ToDouble(str));
                    break;
                case "Boolean":
                    Console.WriteLine(Convert.ToBoolean(str));
                    break;
                case "Char":
                    Console.WriteLine(Convert.ToChar(str));
                    break;
                case "Decimal":
                    Console.WriteLine(Convert.ToDecimal(str));
                    break;
                case "DateTime":
                    Console.WriteLine(Convert.ToDateTime(str));
                    break;
                case "String":
                    Console.WriteLine(Convert.ToString(str));
                    break;


                default:
                    Console.WriteLine("Не удалось определить тип данных");
                    break;
            }

            Console.ReadKey(true);
        }
    }
}
