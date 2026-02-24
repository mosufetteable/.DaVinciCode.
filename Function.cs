using System;
using main;
using dire;
using comp;

namespace met
{
    class hods
    {
        public static void Preparer()
        {
            waker();
            shuffle(main.app.Count);
            aligner();
        }
        public static void waker()
        {
            main.app.Count.Clear();

            for (main.app.ea = 1; main.app.ea <= 12; main.app.ea++)
            {
                main.app.Count.Add(-main.app.ea); // 검
                main.app.Count.Add(+main.app.ea); // 흰
            }
        }
        public static void aligner() //패를 각각 배분해놓고 정렬하는 함수
        {

        }
        
        public static void shuffle(List<int> deck)
        {
            for (main.app.a = deck.Count - 1; main.app.a > 0; main.app.a--)
            {
                main.app.b = main.app.R.Next(main.app.b + 1);
                main.app.Temp = deck[main.app.a];
                deck[main.app.a] = deck[main.app.b];
                deck[main.app.b] = main.app.Temp;
            }
        }
    }
}