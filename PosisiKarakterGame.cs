using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302213020
{
    class PosisiKarakterGame
    {
        private State state;
        private enum State
        {
            Berdiri,
            Terbang,
            Jongkok,
            Tengkurap
        }

        public PosisiKarakterGame()
        {
            state = State.Berdiri;
        }

        public void TombolW()
        {
            if (state == State.Berdiri)
            {
                state = State.Terbang;
                Console.WriteLine("posisi take off");
            }
            else if (state == State.Tengkurap)
            {
                state = State.Jongkok;
            }
            else if (state == State.Jongkok)
            {
                state = State.Berdiri;
            }
        }
        public void TombolS()
        {
            if (state == State.Terbang)
            {
                state = State.Berdiri;
            }
            else if (state == State.Berdiri)
            {
                state = State.Jongkok;
            }
            else if (state == State.Jongkok)
            {
                state = State.Tengkurap;
            }
        }
        public void TombolX()
        {
            if (state == State.Terbang)
            {
                state = State.Jongkok;
                Console.WriteLine("posisi landing");
            }
        }
    }
}
