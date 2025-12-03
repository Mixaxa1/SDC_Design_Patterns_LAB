using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratedClass
{
    public class SomeTutorialVideo : YoutubeVideo
    {
        public override string ShowVideo()
        {
            return "video>>>>>Hello everyone and today i will show you how to install youtube AdBlock";
        }
    }
}
