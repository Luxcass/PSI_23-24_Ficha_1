using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolasColoridas
{
    public class Bolas
    {
        private Cor cor;
        private float raio;
        private int nvezes;

        public Bolas(float raio, Cor cor )
        {
            this.cor = cor;
            this.raio = raio;
            nvezes = 0;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Atirar()
        {
            if(raio > 0) nvezes++;
        }

        public int NVezes()
        {
            
        }
    }
}