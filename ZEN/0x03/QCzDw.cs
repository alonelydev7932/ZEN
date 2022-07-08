using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections    ;
using System.Threading;

namespace ZEN._0x03
{
    internal class QCzDw
    {
        private static HashSet<string> BadProcessnameList = new HashSet<string>();
        private static HashSet<string> BadWindowTextList = new HashSet<string>();

        public static void ScanAndKill()
        {
            if (Scan(true) != 0)
            {
                // Trigger commands if ban process or window name is found below.

                vYFEC.whLOn.ban(); // Bans users <THEY MUST BE LOGGED IN TO BAN>
                System.Threading.Thread.Sleep(5000); // Sleep before force closing.
                Environment.Exit(0); // Exit with out warning
            }
        }

        private static int Scan(bool KillProcess)
        {
            int isBadProcess = 0;

            if (BadProcessnameList.Count == 0 && BadWindowTextList.Count == 0)
            {
                Init();
            }

            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                if (BadProcessnameList.Contains(process.ProcessName) || BadWindowTextList.Contains(process.MainWindowTitle))
                {
                    isBadProcess = 1;

                    if (KillProcess)
                    {
                        try
                        {
                            process.Kill();
                        }
                        catch (System.ComponentModel.Win32Exception w32ex)
                        {
                            break;
                        }
                        catch (System.NotSupportedException nex)
                        {
                            break;
                        }
                        catch (System.InvalidOperationException ioex)
                        {
                            break;
                        }
                    }

                    break;
                }
            }

            return isBadProcess;
        }

        private static int Init()
        {
            if (BadProcessnameList.Count > 0 && BadWindowTextList.Count > 0)
            {
                return 1;
            }

            BadProcessnameList.Add("ollydbg");
            BadProcessnameList.Add("ida");
            BadProcessnameList.Add("ida64");
            BadProcessnameList.Add("idag");
            BadProcessnameList.Add("idag64");
            BadProcessnameList.Add("idaw");
            BadProcessnameList.Add("idaw64");
            BadProcessnameList.Add("idaq");
            BadProcessnameList.Add("idaq64");
            BadProcessnameList.Add("idau");
            BadProcessnameList.Add("idau64");
            BadProcessnameList.Add("scylla");
            BadProcessnameList.Add("scylla_x64");
            BadProcessnameList.Add("scylla_x86");
            BadProcessnameList.Add("protection_id");
            BadProcessnameList.Add("x64dbg");
            BadProcessnameList.Add("x32dbg");
            BadProcessnameList.Add("windbg");
            BadProcessnameList.Add("reshacker");
            BadProcessnameList.Add("ImportREC");
            BadProcessnameList.Add("IMMUNITYDEBUGGER");
            BadProcessnameList.Add("MegaDumper");
            BadProcessnameList.Add("dnSpy");
            BadWindowTextList.Add("HTTPDebuggerUI");
            BadWindowTextList.Add("HTTPDebuggerSvc");
            BadWindowTextList.Add("HTTP Debugger");
            BadWindowTextList.Add("HTTP Debugger (32 bit)");
            BadWindowTextList.Add("HTTP Debugger (64 bit)");
            BadWindowTextList.Add("OLLYDBG");
            BadWindowTextList.Add("ida");
            BadWindowTextList.Add("disassembly");
            BadWindowTextList.Add("scylla");
            BadWindowTextList.Add("Debug");
            BadWindowTextList.Add("[CPU");
            BadWindowTextList.Add("Immunity");
            BadWindowTextList.Add("WinDbg");
            BadWindowTextList.Add("x32dbg");
            BadWindowTextList.Add("x64dbg");
            BadWindowTextList.Add("Import reconstructor");
            BadWindowTextList.Add("MegaDumper");
            BadWindowTextList.Add("MegaDumper 1.0 by CodeCracker / SnD");

            return 0;
        }
    }
}
