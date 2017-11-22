using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DoAn_Win
{
    public class sinhvien
    {
        public static bool kttendangnhap(string use)
        {
            if (Regex.IsMatch(use, "^1[0-9]{7}$"))
                return true;
            else return false;
        }
        public static bool ktmatkhau(string mk1, string mk2)
        {
            if (mk1 == mk2)
                return true;
            else
                return false;

        }
        public static bool ngaysinh(DateTime ns)
        {
            DateTime getday = DateTime.Now;
            if (getday.Year - ns.Year >= 18 && getday.Year - ns.Year <= 120)
                return true;
            else return false;
        }
        public static bool ktten(string ten)
        {
            if (ten.Trim() != "")
            {
                if (Regex.IsMatch(ten.Trim(), "^.*[0-9]+.*$"))
                    return false;
                else return true;
            }
            else
                return false;
        }
        public static bool ktmamon(string mm)
        {
            if (Regex.IsMatch(mm, "^[A-Z]{2}[0-9]{4}$"))
                return true;
            else return false;
        }
        public static bool ktdiem(string diem)
        {
            try
            {
                float d = Convert.ToSingle(diem);
                if (d <= 10f)
                {
                    if (Regex.IsMatch(diem, @"[0-9]{1}.?[0-9]{1}") || Regex.IsMatch(diem, @"[0-9]{1}"))
                        return true;
                    else return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool ktkhoahoc(int khoahoc, DateTime ns)
        {
            int tuoi = khoahoc - ns.Year;
            if (tuoi >= 18)
                return true;
            else return false;
        }
    }
}
