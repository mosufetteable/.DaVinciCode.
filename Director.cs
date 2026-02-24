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
            while (main.app.Agg != true && main.app.Tgg != true)
            {

            }
        }

        public static void Preparer() //준비 함수
        {
            met.hods.waker();
            met.hods.shuffle(main.app.Count);
        }

        public static void WinnerDinner() //김칫국 함수
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

    public class Phae //판정을 위한 클래스
    {
        public int Num; //패 숫자
        public bool Isblack; //패 색깔
        public bool IsOpen; //패가 들켰나 안 들켰나
    }
}