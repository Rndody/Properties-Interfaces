using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Media_Player_Plugins
{
    public class Video : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Playing video");
            
        }

        public void Stop()
        {
            Console.WriteLine("Stopping video");
           
        }
    }
}
