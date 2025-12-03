using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.DecoratedClass;

namespace Decorator.Decorators
{
    public class PrerollAdDecorator : VideoDecorator
    {
        public PrerollAdDecorator(YoutubeVideo video) : base(video)
        {
        }

        public override string ShowVideo()
        {
            string preroll = "Some nonsense AD\n";
            return preroll + base.ShowVideo();
        }
    }
}
