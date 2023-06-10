using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08_lab.BL
{
    class truck
    {
        List<driver> drive = new List<driver>();
        public ladder L = new ladder();
        public horsePipe H;
        public void setPipe(horsePipe objH)
        {
            this.H = objH;
        }
    }
    class ladder
    {
        public int lengthL;
        public int colorL;
    }
    class horsePipe
    {
        public int diameterH;
        public int waterFlowRate;
        public string shape;
        public string material;
    }
    class driver
    {
        public string name;
        public void drive()
        {

        }
        public void extuingishFire()
        {

        }
    }
    class fireFighter : driver
    {

    }
    class fireChief : driver
    {
        public void giveResponsibility()
        {

        }
    }
}
