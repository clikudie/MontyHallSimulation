using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class CarDoorFactory : DoorFactory
    {
        private int _doorId;
        private Prize _prize;

        public CarDoorFactory(int id, Prize prize)
        {
            _doorId = id;
            _prize = prize;
        }

        public override Door GetDoor()
        {
            return new CarDoor(_doorId, _prize);
        }
    }
}
