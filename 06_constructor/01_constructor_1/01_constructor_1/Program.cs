using System;

namespace _01_constructor_1
{
    class Program
    {
        class demo
        {
            int x, y;
            public demo(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public demo()
            {

            }
            public void setxy(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            demo d1=new demo();
            d1.setxy(20, 30);
            demo d2 = new demo(40, 50);
            Console.Read();
        }
    }
}
