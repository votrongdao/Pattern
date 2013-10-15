using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternMagic.Entity;
using RunPattern;

namespace PatternMagic.Impl
{
    class SamsungGalaxyMobile:SmartPhone
    {
        public SamsungGalaxyMobile(IOutputWritter writter) : base(writter)
        {
        }
    }
}
