using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFA_projLEDS
{
    class Leds
    {
        private byte estado;
        public Leds()
        {
            this.estado = 0;
        }
        public Leds(byte estado)
        {
            this.estado = estado;
        }
        public void acender(int led)
        {
            int potencia = led - 1;
            this.estado = (byte)((int)this.estado | (int)Math.Pow(2, potencia));
        }
        public void apagar(int led)
        {
            int potencia = led - 1;
            this.estado = (byte)((int)this.estado & (int)(255 - Math.Pow(2, potencia)));
        }
        public bool getEstado(int led)
        {
            if (this.estado == 1)
            {
                return (led == 1);
            }
            if (this.estado == 2)
            {
                return (led == 2);
            }
            if (this.estado == 4)
            {
                return (led == 3);
            }
            if (this.estado == 8)
            {
                return (led == 4);
            }
            if (this.estado == 16)
            {
                return (led == 5);
            }
            if (this.estado == 32)
            {
                return (led == 6);
            }
            if (this.estado == 64)
            {
                return (led == 7);
            }
            if (this.estado == 128)
            {
                return (led == 8);
            }
            else
            {
                return false;
            }
            
        }
        public byte getEstado()
        {
            return this.estado;
        }

    }
}
