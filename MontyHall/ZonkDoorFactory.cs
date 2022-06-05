using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class ZonkDoorFactory : DoorFactory
    {
        private int _doorId;
        private Prize _prize;

        public ZonkDoorFactory(int id, Prize prize)
        {
            _doorId = id;
            _prize = prize;
        }
        public override Door GetDoor()
        {
            return new ZonkDoor(_doorId, _prize);
        }
    }
}
