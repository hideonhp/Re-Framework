using System;

namespace Re_Framework.CoreBase.Models
{
    public class TokenReq
    {
        public string Token { get; set; }
        public string Expires { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
    }
}
