using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFollow.Models
{
    public class Topic:BaseEntity
    {
        public string TopicName { get; set; } // Konu ismi
        public string Description { get; set; } // Konu açıklaması
        public int Hour { get; set; } // Bu konuda çalışan toplam süre

        //Relational Properties

        public virtual List<Lesson> Lessons { get; set; }


        public override string ToString()
        {
            return TopicName;
        }
    }
}
