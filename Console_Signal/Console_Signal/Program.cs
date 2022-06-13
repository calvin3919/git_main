
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp3
{
    class CSsignal
    {
        const bool True = true;
        const bool False = false;
        const bool ON = true;
        const bool OFF = true;

        void SetColor(ConsoleColor forground, ConsoleColor background)
        {

            Console.ForegroundColor = forground;
            Console.BackgroundColor = background;
        }

        public CSsignal()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Let's start program");
            Console.WriteLine("*********************");
        }

        void Lamp(ConsoleColor color, bool onoff)
        {

            if (onoff == ON)
            {
                SetColor(color, color);

            }

            else
            {
                SetColor(ConsoleColor.Gray, ConsoleColor.Gray);
            }
            Console.WriteLine("             ");
            Console.WriteLine("             ");
            Console.WriteLine("             ");
            Console.WriteLine("             ");
            Console.WriteLine("             ");
            SetColor(ConsoleColor.White, ConsoleColor.Black);
        }

        void RedLampOn()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, ON);
            Lamp(ConsoleColor.Yellow, OFF);
            Lamp(ConsoleColor.Green, OFF);
            Console.WriteLine("this is traffic signal");
        }
        void YelloLampon()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, OFF);
            Lamp(ConsoleColor.Yellow, ON);
            Lamp(ConsoleColor.Green, OFF);
            Console.WriteLine("this is traffic signal");
        }

        void GreenLampon()
        {
            Console.Clear();
            Lamp(ConsoleColor.Red, OFF);
            Lamp(ConsoleColor.Yellow, OFF);
            Lamp(ConsoleColor.Green, ON);
            Console.WriteLine("this is traffic signal");
        }

        int nStep;
        int nCount;
        public bool loop()
        {
            switch (nStep)
            {
                case 0:
                    nStep = 100;
                    nCount = 0;
                    RedLampOn();
                    break;

                case 100: //RedLamp on
                    if (nCount < 5)
                    {
                        nCount++;
                    }

                    else
                    {
                        nCount = 0;
                        nStep = 200;
                        YelloLampon();
                    }
                    break;


                case 200: //Yellow Lamp on
                    if (nCount < 5)
                    {
                        nCount++;
                    }
                    else
                    {
                        nCount = 0;
                        nStep = 300;
                        GreenLampon();
                    }

                    break;

                case 300: //Green Lamp on
                    if (nCount < 3)
                    {
                        nCount++;

                    }
                    else
                    {
                        nCount = 0;
                        nStep = 0;
                    }
                    break;

                default:
                    nStep = 0;
                    break;
            }

            Thread.Sleep(1000);
            return true;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            CSsignal sig = new CSsignal();
            while (sig.loop()) ;

        }

    }

}