using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DoAn_Win.ClassUser
{
    public class MonHoc
    {

        public string MaMon { get; set; }

        public string TenMon {get; set;}

        public int SoTinChi {get; set;}

        public bool KTMaMon(string mamon)
        {
            if (Regex.IsMatch(mamon, @"[A-Z]{2}[0-9]{4}"))
                return true;
            else
                return false;
        }

    }
}
