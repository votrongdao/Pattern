using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternMagic.Entity;
using RunPattern;

namespace PatternMagic.Impl
{
    class RockMp3:Mp3Player
    {
        public RockMp3(IOutputWritter writter) : base(writter)
        {
        }
    }
}
