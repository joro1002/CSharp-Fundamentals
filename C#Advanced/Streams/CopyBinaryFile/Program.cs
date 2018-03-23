﻿using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("copyMe.png", FileMode.Open))
            using (FileStream writer = new FileStream("copy.png", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[4096];

                while (true)
                {
                    int readBytes = reader.Read(buffer, 0, buffer.Length);

                    if (readBytes == 0)
                    {
                        break;
                    }

                    writer.Write(buffer, 0, readBytes);
                }
            }
        }
    }
}
