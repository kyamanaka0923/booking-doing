using System;
using System.Collections.Generic;
using System.Linq;
using booking.ExampleLib.Domain.Model.Type;
namespace booking.ExampleLib.Domain.Model.Cargo
{
    public class CargoList
    {
        private List<Cargo> _CargoList;
        public CargoList(IEnumerable<Cargo> cargoList)
        {
            _CargoList = cargoList as List<Cargo>;
        }

        public CargoList AddCargo(Cargo cargo)
        {
            var result = new List<Cargo>();

            result.AddRange(_CargoList.AsEnumerable());

            return new CargoList(result);
        }

        public Size Total()
        {
            var size = new Size(0);

            foreach(var cargo in _CargoList)
            {
                size = size.Add(cargo.Size);
            }
            return size;
        }

        public static CargoList Empty {get{
                return new CargoList(new List<Cargo>());
        }
        }
    }
}