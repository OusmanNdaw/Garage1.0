using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Vehicle 
    {

        Vehicle Vehicle = new Vehicle();

        // Vehicle Boat = new Vehicle();
        internal Vehicle Airplane { get => this.Airplane; set => this.Airplane = value; }
        internal Vehicle MotorCycle { get => this.MotorCycle; set => this.MotorCycle = value; }
        internal Vehicle Bus { get => this.Bus; set => this.Bus = value; }
        internal Vehicle Boat { get => this.Boat; set => this.Boat = value; }

        /*Det måste minst finnas följande subklasser:
            Airplane
            Motorcycle
            Car
            Bus
            Boat  */

        /* Different models of cars
           Volvo,Kia,Mercedes,Jeep,Porsche,Nissan,Toyota,...
           Numberplate, color, number of wheels
           Numberplate must be unique
           Other subclasses: Airplane, Motorcycle, Car, Bus, Boat */


        class Airplane
            {
            // two wheels
            // Color
            // Model
        }

        class MotorCycle
            {
            // two wheels
            // Color
            // Model
        }

        class Car

            {
            // four wheels
            // Color
            // Model
        }
        class Bus

            {
            // six wheels
            // Color
            // Model
        }


        class Boat
            {
            // no wheels
            // Color
            // Model
        }

        class SpaceShuttle
            {
            // no wheels
            // Color
            // Model
        }
    }

}

