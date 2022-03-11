using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFollow.Tools.DTOClasses
{
    public class LessonInfoDTO:BaseDTO
    {
        public string KonuAdi { get; set; }
        public string DersAdi { get; set; }
        public int? DersSuresi { get; set; }
    }
}
