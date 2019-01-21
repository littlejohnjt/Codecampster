﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codecamp.Models
{
    public class Announcement
    {
        public int AnnouncementId { get; set; }

        public int? EventId { get; set; }

        public string Message { get; set; }

        [Display(Name = "Display Order")]
        public int Rank { get; set; }

        [Display(Name = "Publish On")]
        [DataType(DataType.Date)]
        public DateTime PublishOn { get; set; }

        [Display(Name = "Expires On")]
        [DataType(DataType.Date)]
        public DateTime? ExpiresOn { get; set; }
    }
}
