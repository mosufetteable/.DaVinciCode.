using System;
using main;
using met;
using comp;

namespace dire
{
    class ctor
    {
        public static void Starfighter() //메인 함수
        {
            Preparer();
        }

        public static void Preparer()
        {
            met.hods.waker();
            met.hods.shuffle(main.app.Count);
        }

        
    }
}