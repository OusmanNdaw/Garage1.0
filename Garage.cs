﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage1.Vehicle;
using static Garage1.Vehicle.Garage;

namespace Garage1.Vehicle
{
    class Garage
    {
        static void Main(string[] args)
        {internal class Garage<T> where T : Garage, Open };
             //{
internal interface Open
    {
    }

    // I vårt fall här vill vi kunna itterera på en instans av Garage klassen.
    // Tex.

    var garage = new Garage <Vehicle>(6); (// Där Vehicle är typen och 6 är antal platser)

                foreach(var vehicle in garage)

                {
                Console.WriteLine(vehicle.Color);
                }
            }
                //Eller: var result = garage.Where(v => v.Color == "Red");


       
                        // Boolean close open;
                        Console.WriteLine("Är Garaget oppet? ");
                    Console.Readline();
                        if (JA) {
                            Garage Open;
                            Console.WriteLine("Välkomna att parkera!");
                            Console.WriteLine("Var god välj ett parkeringsplats!");
                            Garage.IUI.Menu;
                        } else if {
                            Garage Closed;
                            Console.WriteLine("Kom gärna en annan gång.");
                        }

                        if (JA) 
                        {
                            DriveIn();
                            TakeParkingLot();
                            Park();
                        } 
                        else
                        {
                            if (Closed)
                                {
                                    DriveOut();
                                    driveAway();
                                 } 
                                else 
                                 {   
                                    Garage closed();
                                    NoParking();
                        }
                    }
               }

             }
            }
void NoParking()
{
   if (closed)
    {
        NoParking = true;
    }
}

void TakeParkingLot()
{
    if (Open)
    {
        TakeParkingLot() = true;
    }
}

// all vehicles parked in the Garage at the moment. How Many?
// What are the type of vehicles in the Garage at the moment.
// Lägga till eller ta Bort vehicle
// MaxCapacitet av Garaget


void DriveIn()
            {
    if (Open)


        DriveIn();
            }

            void Park()
            {
    if (closed && (TakeParkingLot() = true))
        Park() = true;
            }

            void DriveOut()
            {
                if (Open && // (fordon not stolen ))
    {
        DriveOut() = true;


    }
            }

            void driveAway()
            {
                exit();
}
}