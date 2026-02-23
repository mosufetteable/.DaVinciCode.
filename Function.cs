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
            for(int a=0; a < main.app.bw; a++)
            {
                main.app.Count.Add(new List<int>());
                for(int b=0; b < main.app.ea; b++)
                {
                    main.app.Count[a].Add(b+1); //1~12가 들어가야지
                }
            }
        }
        public static void Aligner() //패를 각각 배분해놓고 정렬하는 함수
        {   
        
        }
    }
}