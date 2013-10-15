using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternMagic.BehaviorInterfaces;
using RunPattern;

namespace PatternMagic.Entity
{
    class Mp3Player:Device, IMusicPlayer
    {
        public Mp3Player(IOutputWritter writter) : base(writter)
        {

        }

        public string NowPlaying()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Prev()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
