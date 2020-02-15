using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class BusArrival
    {
        const int MAX_PASSENGERS = 50;

        private int line;
        private int passengers;
        private Time arrival;

        

        public BusArrival(int line, int hour, int minute, int second, int passengers)
            : this(line, new Time(hour, minute, second), passengers)
        {
        }

        public BusArrival(int line, Time arrival, int passengers)
        {
            this.passengers = 0;
            this.line = 1;
            this.arrival = null;

            Passengers = passengers;
            Line = line;
            Arrival = arrival;

        }



        //***********************************getters & setters
        public int Line
        {
            get
            {
                return this.line;
            }
            set
            {
                if (value >= 1 && value <= 99)
                    this.line = value;
            }
        }
        public int Passengers
        {
            get
            {
                return this.passengers;
            }
            set
            {
                if (value >= 0 && value <= MAX_PASSENGERS)
                    this.passengers = value;
            }
        }
        public Time Arrival
        {
            get
            {
                return new Time(this.arrival);
            }
            set
            {
                this.arrival = new Time(value);
            }
        }
        //******************************************************


        public void ToString()
        {
            Console.WriteLine("Line: " + this.line.ToString() + " Passengers: " + this.passengers.ToString() + " Arrival time: " + this.arrival.ToString());
        }

        public bool Equals(BusArrival other)
        {
            if (other == null) //needs to be taken into account
                return false;
            else if (other == this) //compares only the reference adresses
                return true;
            else if (this.line == other.line && this.passengers == other.passengers && this.arrival.Equals(other.arrival))
                return true;
            else return false;
        }

        public bool IsFullerThan(BusArrival other)
        {
            if (other.passengers == null)
                return true;
            if (this.passengers > other.passengers)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (passengers == null)
                return false;
            return passengers == MAX_PASSENGERS;
        }

        public int EllapsedMinutes(BusArrival other)
        {
            return this.arrival.DifferenceByMinutes(other.arrival);
        }



    }

}



