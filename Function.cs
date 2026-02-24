using System;
using main;
using dire;
using comp;

namespace met
{
    class hods
    {
        public static void waker() //초기화 함수
        {
            main.app.Count.Clear();

            for (main.app.ea = 1; main.app.ea <= 12; main.app.ea++)
            {
                main.app.Count.Add(-main.app.ea); // 검은색 추가
                main.app.Count.Add(+main.app.ea); // 흰색 추가
            }
        }
        public static void shuffle(List<int> phae) //섞은 다음에 4장씩 뿌리는 함수
        {
            for (main.app.a = phae.Count - 1; main.app.a > 0; main.app.a--)
            {
                main.app.b = main.app.R.Next(main.app.a + 1);
                main.app.Temp = phae[main.app.a]; //스
                phae[main.app.a] = phae[main.app.b]; //와
                phae[main.app.b] = main.app.Temp; //핑
            }
            for(int i=0;i<4;i++)
            {
                main.app.Avril.Add(phae[0]); //하나 가져오고
                phae.RemoveAt(0); //그거 지우래이
                main.app.Trigger.Add(phae[0]);
                phae.RemoveAt(0);
            }
        }
    }
}