using System;
using main;
using dire;
using comp;

namespace met
{
    class hods
    {
        public static void Waker() //공용 패부터 먼저 만들어두고
        {
            for (int i = -12; i <= 12; i++)
            {
                if (i == 0) continue; //0은 건너뛰기
                main.app.Count.Add(i);
            }
        }
        public static void Aligner() //패를 각각 배분해놓고 정렬하는 함수
        {   
        
        }
    }
}