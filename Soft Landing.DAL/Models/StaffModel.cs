using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Landing.DAL.Models
{
    public class StaffModel : BaseModel
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
    }
}
