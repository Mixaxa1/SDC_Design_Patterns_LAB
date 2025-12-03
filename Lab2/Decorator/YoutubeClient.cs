using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.DecoratedClass;

namespace Decorator
{
    public class YoutubeClient
    {
        public void WatchVideo(YoutubeVideo video)
        {
            Console.WriteLine(video.ShowVideo());
        }
    }
}
