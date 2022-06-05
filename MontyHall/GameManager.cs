using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class GameManager
    {
        private int _carPos;
        private int _doorCount;
        private int _userDoor;
        private IList<Door> _doors;
        private int _lastChoiceDoor;

        public GameManager(int doorCount)
        {
            var random = new Random();
            _carPos = random.Next(1, doorCount + 1);
            _doorCount = doorCount;
            _doors = new List<Door>();
        }

        public void CreateDoors()
        {
            for (int i = 0; i < _doorCount; ++i)
            {
                DoorFactory doorFactory;
                if (i == _carPos - 1)
                {
                    doorFactory = new CarDoorFactory(i, Prize.Car);
                    _doors.Add(doorFactory.GetDoor());
                    continue;
                }

                doorFactory = new ZonkDoorFactory(i, Prize.Zonk);
                _doors.Add(doorFactory.GetDoor());
            }
        }

        public void SetUserDoor(int userDoor)
        {
            _userDoor = userDoor;
        }

        public Prize GetPrize(int doorId)
        {
            Console.WriteLine("Door {0} has prize {1}", doorId, _doors.ElementAt(doorId -1).Prize);
            return _doors.ElementAt(doorId - 1).Prize;
        }

        public void SelectLastChoiceDoor()
        {
            if (_userDoor == _carPos)
            {
                var random = new Random();
                _lastChoiceDoor = random.Next(1, _doorCount + 1);
                while (_lastChoiceDoor == _userDoor)
                {
                    _lastChoiceDoor = random.Next(1, _doorCount + 1);
                }
            }
            else
            {
                _lastChoiceDoor = _carPos;
            }
        }

        public void KeepOrSwitchPrompt()
        {
            Console.WriteLine("You chose door {0}. You can switch to door {1}, would you like to keep your number or switch?", _userDoor, _lastChoiceDoor);
        }

        public Prize SelectSwitchOrKeep(string choice)
        {
            Console.WriteLine("You chose to {0}", choice);
            return choice switch
            {
                "keep" => GetPrize(_userDoor),
                "switch" => GetPrize(_lastChoiceDoor),
                _ => Prize.Zonk,
            };
        }
    }
}
