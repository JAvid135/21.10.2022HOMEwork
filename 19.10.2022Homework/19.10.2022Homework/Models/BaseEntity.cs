using System;
using System.Collections.Generic;
using System.Text;

namespace _19._10._2022Homework.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; } 
    }
}
