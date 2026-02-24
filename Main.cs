using System;
using met;
using dire;
using comp;

namespace main
{
    class app  //-12,12 == 조커(각각 흰/검) / -11~-1 == 검은색카드 / 1~11 == 흰색 카드
    {
        public static int ea = 12; //갯수
        public static Random R = new Random();
        public static int a;
        public static int b;
        public static int Temp;
        public static List<int> Avril = new List<int>(); //플레이어 패
        public static List<int> Trigger = new List<int>(); //컴퓨터 패 
        public static bool Agg; //Avril GG
        public static bool Tgg; //Trigger GG
        public static List<int> Count = new List<int>(); //공용 패
        public static void Main(string[] args)
        {
            dire.ctor.Starfighter(); //메인함수 구동
            dire.ctor.WinnerDinner();
            Console.WriteLine("\n\n\n아무 키나 눌러 종료하시길 바랍니다...");
            Console.ReadKey();
        }
    }
}