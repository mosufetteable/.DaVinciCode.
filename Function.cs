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

        public static void UserInput()
        {

        }
        
        public static void Indicator()
        {

        }

        public static void Visualizer()
        {

        }

        public static void rsp() //Rock Scissors Paper
        {
            
        }
    }
}