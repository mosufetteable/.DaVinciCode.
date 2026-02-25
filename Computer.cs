using System;
using System.Security.Cryptography;
using main;
using met;
using dire;

namespace comp //알고리즘 개쩔게 짜본다
{
    class uter
    {
        public static void shuffer(List<int> phae) //섞은 다음에 4장씩 뿌리는 함수
        {
            for (int i = 0; i < 4; i++)
            {
                main.app.Trigger.Add(phae[main.app.a]); //하나 가져오고
                main.app.a = RandomNumberGenerator.GetInt32(phae.Count);
                phae.RemoveAt(main.app.a); //그거 지우래이
            }
        }
    }
}