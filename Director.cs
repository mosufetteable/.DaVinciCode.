using System;
using main;
using met;
using comp;

namespace dire
{
    class ctor
    {
        public static void Starfighter() //메인 함수
        {
            Preparer();
            while(main.app.Agg != true&&main.app.Tgg != true)
            {
                
            }
        }

        public static void Preparer()
        {
            met.hods.waker();
            met.hods.shuffle(main.app.Count);
        }

        public static void WinnerDinner()
        {
            if (main.app.Agg == true)
            {
                Console.WriteLine("\n\n::::::::::::::::::::::::::::::::");
                Console.WriteLine("당신이 이겼습니다!!!");
                Console.WriteLine("::::::::::::::::::::::::::::::::");
            }
            else if (main.app.Tgg == true)
            {
                Console.WriteLine("\n\n::::::::::::::::::::::::::::::::");
                Console.WriteLine("안타깝습니다... 패배하셨습니다.");
                Console.WriteLine("::::::::::::::::::::::::::::::::");
            }
        }
    }
}