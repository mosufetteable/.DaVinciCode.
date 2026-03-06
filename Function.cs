using System;
using System.Security.Cryptography;
using main;
using dire;
using comp;

namespace met
{
    class hods
    {
        public static void waker(List<int> phae) //초기화 함수
        {
            main.app.Count.Clear();

            for (main.app.ea = 1; main.app.ea <= 12; main.app.ea++)
            {
                main.app.Count.Add(-main.app.ea); // 검은색 추가
                main.app.Count.Add(+main.app.ea); // 흰색 추가
            }
            for (main.app.a = phae.Count - 1; main.app.a > 0; main.app.a--)
            {
                main.app.b = RandomNumberGenerator.GetInt32(main.app.a + 1);
                main.app.Temp = phae[main.app.a]; //스
                phae[main.app.a] = phae[main.app.b]; //와
                phae[main.app.b] = main.app.Temp; //핑
            }
        }

        public static void Selector()
        {
            Console.WriteLine("비어있으면 컴파일러가 뭐라고 하길래 임시로 채워놨습네다");
        }
        
        public static void Indicator()
        {

        }

        public static void Visualizer()
        {

        }

        public static void RSP() //Rock Scissors Paper
        {
            main.app.a = RandomNumberGenerator.GetInt32(1, 4);
            while (true)
            {
                Fi:
                Console.WriteLine("가위==1, 바위==2, 보==3");
                Console.Write(">> ");
                if (int.TryParse(Console.ReadLine(), out int v) && v >= 1 && v <= 3)
                {
                    if (v == 1)
                    {
                        if (main.app.a == 1)
                        {
                            Console.WriteLine("비겼습니다!!!");
                            goto Fi;
                        }

                        else if (main.app.a == 2)
                        {
                            main.app.Turn = false;
                        }
                        
                        else if (main.app.a == 3)
                        {
                            main.app.Turn = true;
                        }
                    }

                    else if (v == 2)
                    {
                        if (main.app.a == 1)
                        {

                        }

                        else if (main.app.a == 2)
                        {

                        }
                        
                        else if (main.app.a == 3)
                        {
                            
                        }
                    }
                    
                    else if (v == 3)
                    {
                        if (main.app.a == 1)
                        {

                        }

                        else if (main.app.a == 2)
                        {

                        }
                        
                        else if (main.app.a == 3)
                        {
                            
                        }
                    }
                }
                Console.WriteLine("입력값이 올바르지 않습니다.");
            }
        }
    }
}