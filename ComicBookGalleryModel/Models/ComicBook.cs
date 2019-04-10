using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Models
{
    public class ComicBook
    {
        // you can use ID, ComicBookId or ComicBookID to name the primaryKey of a table
        public int Id { get; set; }
        public Series Series{ get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal Rating { get; set; }

    }
}
