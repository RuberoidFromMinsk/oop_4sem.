using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WindowsFormsApp2
{
    [DataContract]
    public class Adress
    {
        private string city;
        private string street;
        private int house;
        private int flat;

        [DataMember] 
        public string City { get => city; set => city = value; }
        [DataMember]
        public string Street { get => street; set => street = value; }
        [DataMember]
        public int House { get => house; set => house = value; }
        [DataMember]
        public int Flat { get => flat; set => flat = value; }
    }
}
