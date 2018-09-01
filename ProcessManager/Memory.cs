using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManager
{
    class Memory
    {
        public static IntPtr ProcHandle;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress,
          byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);


        public static bool InitMem(Process process, bool WriteAccess )
        {
            if (WriteAccess)
            {
                ProcHandle = OpenProcess(0x1F0FFF, false, process.Id);
            }
            else
            {
                ProcHandle = OpenProcess(0x0010, false, process.Id);
            }
            
            if (ProcHandle.ToInt32() != 0)
            {
                return true;
            }
            return false;
          
        }

        public static bool ReadByte(int memaddress)
        {
            byte[] byteinfo = new byte[1];
            int read = 0;
            ReadProcessMemory(ProcHandle, memaddress, byteinfo, 1, ref read);
            if (read == 1)
            {
                return BitConverter.ToBoolean(byteinfo, 0);
            }
            return false;
        }
        public static int ReadInteger(int memaddress)
        {
            byte[] byteinfo = new byte[4];
            int read = 0;
            ReadProcessMemory(ProcHandle, memaddress, byteinfo, 4, ref read);
            if (read == 4)
            {
                return BitConverter.ToInt32(byteinfo, 0);
            }
            return 0;
        }

        public static float ReadFloat(int memaddress)
        {
            byte[] byteinfo = new byte[4];
            int read = 0;
            ReadProcessMemory(ProcHandle, memaddress, byteinfo, 4, ref read);
            if (read == 4)
            {
                return BitConverter.ToSingle(byteinfo, 0);
            }
            return 0;
        }

        public static double ReadDouble(int memaddress)
        {
            byte[] byteinfo = new byte[8];
            int read = 0;
            ReadProcessMemory(ProcHandle, memaddress, byteinfo, 8, ref read);
            if (read == 8)
            {
                return BitConverter.ToDouble(byteinfo, 0);
            }
            return 0;
        }




        public static bool WriteByte(int memaddress, bool value)
        {
            byte[] bytewriter = BitConverter.GetBytes(value);
            int writen = 0;
            WriteProcessMemory(ProcHandle, memaddress, bytewriter, 1, ref writen);
            if (writen == 1)
            {
                return true;
            }
            return false;
        }



        public static bool  WriteInt(int memaddress, int value)
        {
            byte[] bytewriter = BitConverter.GetBytes(value);
            int writen = 0;
            WriteProcessMemory(ProcHandle, memaddress, bytewriter, 4, ref writen);
            if (writen == 4)
            {
                return true;
            }
              return false;
        }


        public static bool  WriteFloat(int memaddress, float value)
        {
            byte[] bytewriter = BitConverter.GetBytes(value);
            int writen = 0;
            WriteProcessMemory(ProcHandle, memaddress, bytewriter, 4, ref writen);
            if (writen == 4)
            {
                return true;
            }
            return false;
        }

        public static bool WriteDouble(int memaddress, double value)
        {
            byte[] bytewriter = BitConverter.GetBytes(value);
            int writen = 0;
            WriteProcessMemory(ProcHandle, memaddress, bytewriter, 8, ref writen);
            if (writen == 8)
            {
                return true;
            }
            return false;
        }


        public static String ReadString(int memaddress, int len, bool isunicode)
        {
            byte[] byteinfo = new byte[len];
            int read = 0;
            ReadProcessMemory(ProcHandle, memaddress, byteinfo, len, ref read);
            if (read == len)
            {
                if (isunicode)
                {
                    return Encoding.Unicode.GetString(byteinfo);
                }
                else
                {
                    return Encoding.ASCII.GetString(byteinfo);
                }
               
            }
            return "Invalid";
        }



        public static bool WriteString(int memaddress, string value, bool isunicode)
        {
            byte[] byteinfo;
            if (isunicode)
            {
                byteinfo = Encoding.Unicode.GetBytes(value);
            }
            else
            {
               byteinfo = Encoding.ASCII.GetBytes(value);
            }

            int writen = 0;
            ReadProcessMemory(ProcHandle, memaddress, byteinfo, byteinfo.Length, ref writen);
            if (writen == byteinfo.Length)
            {
                return true; 
            }
            return false;
        }

    }
}
