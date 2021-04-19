using System;
using RectangleApplication;

namespace start
{
    class Program
    {
        //类的解释
        static void Main(string[] args)
        {
            //打印hello world
            Console.WriteLine("Hello World!");
            
            /*
                C# 是大小写敏感的。
                所有的语句和表达式必须以分号（;）结尾。
                程序的执行从 Main 方法开始。
            */
            // 暂停，等待键盘响应
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}