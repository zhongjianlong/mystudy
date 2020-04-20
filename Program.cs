using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("开始 ...");

            try
            {
                throw new Exception("测试错误");
            }
            catch (Exception e)
            {
                for (int i = 0; i < 10; i++)
                {
                    Log.Error(e.Message);

                    Console.WriteLine($"执行了{i + 1}条记录 ...");
                }
            }
            Console.ReadKey();
        }

    }
}
