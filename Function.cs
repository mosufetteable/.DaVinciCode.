using System;
using main;
using dire;
using comp;

namespace met
{
    class hods
    {
        public static void waker()
        {
            main.app.Count.Clear();

            for (main.app.ea = 1; main.app.ea <= 12; main.app.ea++)
            {
                main.app.Count.Add(-main.app.ea); // 검
                main.app.Count.Add(+main.app.ea); // 흰
            }
        }
        public static void shuffle(List<int> phae)
        {
            for (main.app.a = phae.Count - 1; main.app.a > 0; main.app.a--)
            {
                main.app.b = main.app.R.Next(main.app.b + 1);
                main.app.Temp = phae[main.app.a];
                phae[main.app.a] = phae[main.app.b];
                phae[main.app.b] = main.app.Temp;
            }
            main.app.ea = 1;
            for(int i=0;i<4;i++)
            {
                main.app.Avril.Add(phae[main.app.ea++]);
                main.app.Trigger.Add(phae[main.app.ea++]);
            }
        }
    }
}