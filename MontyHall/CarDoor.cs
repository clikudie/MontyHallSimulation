using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class CarDoor : Door
    {
        private readonly string _type;
        private int _doorId;
        private Prize _prize;

        public CarDoor(int id, Prize prize)
        {
            _type = "car";
            _doorId = id;
            _prize = prize;
        }
        public override string Type
        {
            get { return _type; }
        }

        public override int Id
        {
            get { return _doorId; }
            set { _doorId = value; }
        }

        public override Prize Prize
        {
            get { return _prize; }
            set { _prize = value; }
        }
    }
}
