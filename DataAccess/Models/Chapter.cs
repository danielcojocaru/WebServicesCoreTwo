using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            InverseIdChapterParentNavigation = new HashSet<Chapter>();
        }

        public string IdChapter { get; set; }
        public string IdChapterParent { get; set; }
        public string ChapterName { get; set; }
        public string ChapterShortName { get; set; }
        public string Class { get; set; }
        public int? TotalQuestion { get; set; }
        public string Details { get; set; }

        public virtual Chapter IdChapterParentNavigation { get; set; }
        public virtual ICollection<Chapter> InverseIdChapterParentNavigation { get; set; }
    }
}
