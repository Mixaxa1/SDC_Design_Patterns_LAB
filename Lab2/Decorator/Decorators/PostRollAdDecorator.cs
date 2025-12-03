using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.DecoratedClass;

namespace Decorator.Decorators
{
    public class PostRollAdDecorator : VideoDecorator
    {
        public PostRollAdDecorator(YoutubeVideo video) : base(video)
        {
        }

        public override string ShowVideo()
        {
            string postroll = "\nSome nonsense AD to piss you off if you AFK in bluetooth hedphones\n";
            return base.ShowVideo() + postroll;
        }
    }
}
