using System;
using DWORD = System.UInt32;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System;
using LibreHardwareMonitor.Hardware;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = false;
            bool y = false;
            bool z = false;
            for (int i = 0; i < 8; i++)
            {

            x = (i & 4) != 0;
            y = (i & 2) != 0;    
            z = (i & 1) != 0;

            Console.Write(x);
            Console.Write(y);
                Console.WriteLine(z);
            }

        }
    }
}
