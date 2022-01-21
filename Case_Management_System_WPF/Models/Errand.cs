using System;
using System.Collections.Generic;

namespace Case_Management_System_WPF.Models
{
    public partial class Errand
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public string ErrandDescription { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ChangedTime { get; set; }
        public string ErrandStatus { get; set; }
        public string Adminstrator { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
