using System;
using met;
using dire;
using comp;

namespace main
{
    class app  //-12,12 == 조커(각각 흰/검) / -11~-1 == 검은색카드 / 1~11 == 흰색 카드
    {
        public static int bw = 2; //검/흰
        public static int ea = 12; //갯수
        public static List<int> Avril = new List<int>(); //플레이어 패
        public static List<int> Trigger = new List<int>(); //컴퓨터 패 
        public static List<List<int>> Count = new List<List<int>>(); //공용 패
        public static void Main(string[] args)
        {
            dire.ctor.Starfighter(); //메인함수 구동
        }
    }
}