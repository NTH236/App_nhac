using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_nhac
{
    public class song_info
    {
        public int id { get; set; }
        public string ten_baihat { get; set; }
        public string ten_ca_si { get; set; }
        //public string ten_album { get; set; }
        public string the_loai { get; set; }
        public string link_baihat { get; set; }
        //public string link_anh { get; set; }
        //public string link_anh_album { get; set; }
        //public string link_anh_ca_si { get; set; }

        public override string ToString()
        {
            return ten_baihat;
        }
    }
}
