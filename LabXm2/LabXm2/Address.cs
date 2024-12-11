using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXm2
{
    internal class Address
    {
        public int HouseNo { get; set; }
        public int RoadNo { get; set; }
        public string Area { get; set; }
        public string District { get; set; }
        public Address(int house, int road, string area, string district)
        {
            HouseNo = house;
            RoadNo = road;
            Area = area;
            District = district;
        }
        public override string ToString()
        {
            return $"HouseNo: {HouseNo}, \n\t\t RoadNo: {RoadNo}, \n\t\t Area: {Area}, \n\t\t District: {District}";
        }
    }
}
