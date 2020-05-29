using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulGhiFile
{
    public class GHIFILE
    {
        //int i = 0;
        public void GhiFile(String dulieunhap)
        {

            //String tenfile = "txtfile" + i;
            //i++;
            String tenfile = "TextFile1.txt";
            String path = @"D:\1.MonHoc\PhatTrienPhanMem\BaiTap\BaiTapBamThoiGian\"+tenfile;
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
         
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
                sWriter.WriteLine("Hello My Bro");
                sWriter.WriteLine(dulieunhap);
                // Ghi và đóng file
                sWriter.Flush();
                fs.Close();

        }
    }
}
