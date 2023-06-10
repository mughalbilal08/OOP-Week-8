using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08_lab.BL
{
    class bicycle
    {
        private int cadence;
        private int gear;
        private int speed;
        public bicycle()
        {

        }
        public bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void SetCadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void SetGear(int gear)
        {
            this.gear = gear;
        }
        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }
        public void applyBrake(int decreement)
        {

            speed = speed - decreement;
        }
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
    }
    class MountainBike : bicycle
    {
        private int seatHeight;
        public MountainBike()
        {

        }
        public MountainBike(int seatHeight, int cadence, int speed, int gear) : base(cadence, gear, speed)
        {
            this.seatHeight = seatHeight;
        }
        public void setseatheight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
    }
}
