﻿using System.IO;
namespace File_write
{
    class Files
    {
        static void Main(string[] args)
        {
            File.WriteAllText("D:\\KPYP_LECTION\\KPYP_LECTION\\File_write\\Primer.txt", "текст");
            File.AppendAllText("D:\\KPYP_LECTION\\KPYP_LECTION\\File_write\\Primer.txt", "текст метода AppendAllText ()");
        }
    }
}