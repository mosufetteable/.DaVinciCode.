using System;
using System.Security.Cryptography;
using main;
using met;
using comp;

namespace dire
{
    class ctor
    {
        Phae AvrilPhae = new Phae();
        Phae TriggerPhae = new Phae();
        public static void Starfighter() //메인 함수
        {
            met.hods.waker(main.app.Count); //카드부터 섞고...
            Selector(); //유저가 선택하게 하기!!
            comp.uter.shuffer(main.app.Count); //컴퓨터도 고르기!!
            while (main.app.Agg != true && main.app.Tgg != true)
            {
                Phae TriggerPhae = Phae.Judge(main.app.Trigger);

                for (int i = 0; i < TriggerPhae.Num.Count; i++)
                {
                    string color = TriggerPhae.Isblack[i] ? "○" : "●"; //속이 빈 것이 검은색, 꽉 찬 것이 흰색
                    Console.WriteLine($"Cards-{i+1}:{color}{TriggerPhae.Num[i]}");
                }
                break;
            }
        }

        public static void Selector()
        {

        }

        public static void Datalizer()
        {

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
        public List<int> Num = new List<int>(); //패 숫자
        public List<bool> Isblack = new List<bool>(); //패 색깔
        public List<bool> IsOpen = new List<bool>(); //패가 들켰나 안 들켰나
        public static Phae Judge(List<int> keys) //판정 함수
        {
            Phae result = new Phae();
            for (int i = 0; i < keys.Count; i++)
            {
                main.app.b = keys[i]; 
                result.Num.Add(Math.Abs(main.app.b)); //숫자부터(절댓값 조심)
                result.Isblack.Add(main.app.b < 0); //흰색 검은색도
            }
            return result;
        }
    }
}