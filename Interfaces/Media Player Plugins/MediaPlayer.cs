using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Media_Player_Plugins
{
    internal class MediaPlayer
    {
        private IMedia media;


        public IMedia Media
        {
            get { return media; }
            set { media = value; }
        }
    }
}
