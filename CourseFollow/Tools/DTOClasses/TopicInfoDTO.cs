using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFollow.Tools.DTOClasses
{
    public class TopicInfoDTO:BaseDTO
    {
        public string KonuAdi { get; set; }
        public int? KonuSuresi { get; set; }
    }
}
