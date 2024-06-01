using System;

    public class InputModule
    {

        public static int inputIntValue()
        {
            int ret;

            while (true)
            {

                try
                {
                    ret = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный формат ввода. Повторите ввод. ");
                }
            }

            return ret;
        }

        
        //--.
        public static int inputPositiveValue()
        {
            while (true)
            {
                int size = inputIntValue();

                if (size > 0)
                {
                    
                    return size;
                }

                Console.WriteLine("Размер массива не может быть нулём или отрицательным числом, повторите ввод... ");
            }
        }
    }
