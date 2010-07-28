using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WB.Library
{
    public class FileUtil
    {
        public static long TotalLinesOfFile(String fileName)
        {
            if (System.IO.File.Exists(fileName))
                return System.IO.File.ReadAllLines(fileName).Length;
            return 0;
        }
        public static byte[] ReadByteArrayFromFile(string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            br.Close();
            fs.Close();
            return buff;
        }

    }
}
