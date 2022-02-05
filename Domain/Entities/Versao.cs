using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors.Domain.Entities
{
    public class Versao 
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int MakeID { get; set; }
    }
}
