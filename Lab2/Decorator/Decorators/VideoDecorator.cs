using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.DecoratedClass;

namespace Decorator.Decorators
{
    public abstract class VideoDecorator : YoutubeVideo
    {
        protected YoutubeVideo _video;

        public VideoDecorator(YoutubeVideo video)
        {
            _video = video;
        }

        public override string ShowVideo()
        {
            if (_video != null)
            {
                return _video.ShowVideo();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
