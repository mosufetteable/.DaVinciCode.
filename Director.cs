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
            Greet();
            while (main.app.Agg != true && main.app.Tgg != true)
            {

            }
        }

        public static void Greet()
        {
            Console.WriteLine("::::::::다빈치코드(를 구현한 프로그램)에 오신 것을 환영합니다!!!");
            Menu:
            Console.WriteLine("\n\n원하시는 선택을 해주세요...(1,2,3)");
            Console.WriteLine("1.게임 설명");
            Console.WriteLine("2.게임 시작");
            Console.WriteLine("3.나가기");
            while (true)
            {
                Console.Write(">> ");
                if (int.TryParse(Console.ReadLine(), out int v) && v >= 1 && v <= 3)
                {
                    if (v == 1)
                    {
                        Explain();
                        goto Menu;
                    }

                    else if (v == 2)
                    {
                        Ready();
                    }

                    else if (v == 3)
                    {
                        Environment.Exit(0);
                    }
                }
                Console.WriteLine("\n\n::::::::입력값이 올바르지 않습니다.");
                Console.ReadLine();
                Console.WriteLine("\n\n원하시는 선택을 해주세요...(1,2,3)");
                Console.WriteLine("1.게임 설명");
                Console.WriteLine("2.게임 시작");
                Console.WriteLine("3.나가기");
            }
        }
        
        public static void Explain()
        {
            Console.WriteLine("여기에는 각각 흰색과 검정색의 패가 있습니다.");
            Console.ReadLine();
            Console.WriteLine("당신과 알파고(컴퓨터)는 주머니에서 패를 4개씩 가져와서 시작합니다.");
            Console.ReadLine();
            Console.WriteLine("시작하기 전에는 가위바위보로 순서를 정하게 됩니다.");
            Console.ReadLine();
            Console.WriteLine("그 후, 각자 패를 주머니에서 4개씩 가져가야 합니다.");
            Console.ReadLine();
            Console.WriteLine("상대(컴퓨터)는 랜덤으로 패를 가져가게 되고, 당신은 선택을 해야합니다.");
            Console.ReadLine();
            Console.WriteLine("패의 정렬 방식이 정해져 있습니다. 숫자가 큰 것들이 오른쪽으로 가게 되어있습니다.");
            Console.ReadLine();
            Console.WriteLine("다만, 같은 수지만 색이 다른 패 2개가 있다면 흰색이 앞으로 와야합니다.");
            Console.ReadLine();
            Console.WriteLine("알파고(컴퓨터)의 패와 당신의 패는 자동으로 정렬됩니다.");
            Console.ReadLine();
            Console.WriteLine("조커는 어디에든 넣을 수 있습니다. 알파고(컴퓨터)는 추론을 이용해서, 당신의 경우에는 당신이 선택해서 정렬됩니다.");
            Console.ReadLine();
            Console.WriteLine("순서에 따라, 주머니에 패가 남아있을 경우에는 주머니에서 패를 하나 가져갑니다.");
            Console.ReadLine();
            Console.WriteLine("그리고, 상대의 패 하나를 맞혀야 합니다.");
            Console.ReadLine();
            Console.WriteLine("성공한 경우에는 계속 한 번 더 맞힐 수 있게 됩니다.");
            Console.ReadLine();
            Console.WriteLine("실패한 경우에는 가장 마지막에 가져간 카드를 공개됩니다.");
            Console.ReadLine();
            Console.WriteLine("처음 4개의 카드만 남았을 경우에는 오른쪽에서부터 패가 공개됩니다.");
            Console.ReadLine();
            Console.WriteLine("패가 모두 공개된 플레이어는 패배하게 됩니다.");
            Console.WriteLine("\n\n::::::::메뉴로 돌아가려면 Enter를 누르세요.");
            Console.ReadLine();
        }
        
        public static void Ready()
        {
            Console.WriteLine("\n먼저 가위바위보를 통해서 순서를 정하겠습니다.");
            met.hods.RSP();
            met.hods.waker(main.app.Count); //카드부터 섞고...
            met.hods.Selector(); //유저가 선택하게 하기!!
            comp.uter.shuffer(main.app.Count); //컴퓨터도 고르기!!
        }

        public static void Datalizer()
        {

        }

        public static void WinnerDinner() //김칫국 함수
        {
            if (main.app.Tgg == true)
            {
                Console.WriteLine("\n\n::::::::::::::::::::::::::::::::");
                Console.WriteLine("당신이 이겼습니다!!!");
                Console.WriteLine("::::::::::::::::::::::::::::::::");
            }
            else if (main.app.Agg == true)
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