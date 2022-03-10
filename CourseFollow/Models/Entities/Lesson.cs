using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFollow.Models
{
    public class Lesson:BaseEntity
    {
        public string LessonName { get; set; } // Ders Adı
        public string Description { get; set; } // Ders Açıklaması
        public int Minute { get; set; } // Anlık oturum için veri tutulacağından dolayı sadece dakika şeklinde veri tutulmasına karar verilmiştir
        public int TopicID { get; set; }

        //Relational Properties

        public virtual Topic Topic { get; set; }


        public override string ToString()
        {
            return LessonName;
        }
    }
}
