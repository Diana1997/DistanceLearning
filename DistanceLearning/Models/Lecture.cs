//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistanceLearning.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lecture
    {
        public int LectureID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int LessonID { get; set; }
        public string Links { get; set; }
        
        public virtual Lesson Lesson { get; set; }
    }
}
