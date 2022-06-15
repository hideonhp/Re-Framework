using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Models
{
    public class UserDetailReq
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public List<Books> Books { get; set; }
    }
    public partial class Books
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public string Publisher { get; set; }
        public long Pages { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
    }
}
