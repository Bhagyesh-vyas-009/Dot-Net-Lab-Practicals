using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
     class Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine(this.GetType().Name + " class");
        }
    }

    class Apollo:Hospital {
        public void HospitalDetails()
        {
            Console.WriteLine($"Details of {this.GetType().Name} hospital");
        }
    }
    class Wockhardt :Hospital{
        public void HospitalDetails()
        {
            Console.WriteLine($"Address of {this.GetType().Name} Hospital : Kalawad Road Near St. Mary's High School, Rajkot, Gujarat 360007");
        }
    }
    class Gokul_Superspeciality : Hospital {
        public void HospitalDetails()
        {
            Console.WriteLine($"Address of {this.GetType().Name} Hospital : 14, Sadgurunagar, nr. Ranchhoddasbapu ashram, Kuvadava Rd, Rajkot, Gujarat 360003");
        }
    }

    class Prog5
    {
        public void run()
        {
            new Apollo().HospitalDetails();
            new Wockhardt().HospitalDetails();
            new Gokul_Superspeciality().HospitalDetails();
        }
    }

}
