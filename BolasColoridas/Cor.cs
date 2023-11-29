using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BolasColoridas
{
    public class Cor
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Cor(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
    
        public Cor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            int alpha = 255;
        }

        public void SetRed(int red)
        {
            this.red = red;
        }

        public int GetRed()
        {
            return red;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }

        public int 
        }
    }
}   