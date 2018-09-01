using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessManager
{
    public static class FileManager
    {
        public static void SaveModuleLogFile(Process process, ProcessModuleCollection modules)
        {
            StringBuilder log_contents = new StringBuilder();
            SaveFileDialog dialog1 = new SaveFileDialog();
            dialog1.Title = "Save All Module information";
            dialog1.FileName = process.ProcessName + "_modulelogs.txt";
            dialog1.Filter = "All files (*.*)|*.*";
            dialog1.FilterIndex = 1;
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                log_contents.AppendLine("Process Name" + process.ProcessName);
                DateTime localDate = DateTime.Now;
                log_contents.AppendLine("Log time: " + localDate.ToLocalTime());
                log_contents.AppendLine();
              foreach (ProcessModule module in modules)
                {
                    log_contents.AppendLine("Module Name: " + module.ModuleName);
                    log_contents.AppendLine("File Path: " + module.FileName);
                    log_contents.AppendLine("Total Memory Size: " + module.ModuleMemorySize);
                    log_contents.AppendLine("Base Memory Address: " + module.BaseAddress.ToString("X"));
                    log_contents.AppendLine("Entry point Address: " + module.EntryPointAddress.ToString("X"));
                    log_contents.AppendLine(module.FileVersionInfo.ToString());
                    log_contents.AppendLine();
                    log_contents.AppendLine();
                  
                }
                Stream save_file = dialog1.OpenFile();
                StreamWriter sw = new StreamWriter(save_file);
                sw.Write(log_contents);
                sw.Close();
            }
        }

        public static void SaveAllModules(ProcessModuleCollection modules)
        {
            FolderBrowserDialog folderialog = new FolderBrowserDialog();
            folderialog.Description = "Choose save location for Modules";
            if (folderialog.ShowDialog() == DialogResult.OK)
            {
                string folderpath = folderialog.SelectedPath;
                if (folderpath != null)
                {
                    Console.WriteLine("Reached here");
                    foreach (ProcessModule module in modules)
                    {
                        File.Copy(module.FileName, folderpath + "/" + module.ModuleName);
                    }
                    MessageBox.Show(null, "Successfuly Saved All modules to " + folderpath + "Saved Modules", "Saved");
                }
            }
        }

        public static String GetFileDirectory()
        {
           
            return null;
        }

        public static void SaveModule(ProcessModule module)
        {
            SaveFileDialog dialog1 = new SaveFileDialog();
            dialog1.Title = "Save Module" + module.ModuleName;
            dialog1.FileName = module.ModuleName;
            dialog1.Filter = "All files (*.*)|*.*";
            dialog1.FilterIndex = 1;
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(module.FileName, dialog1.FileName);
                MessageBox.Show(null, "Saved " + module.ModuleName + " To " + Path.GetDirectoryName(dialog1.FileName), "Saved" + module.ModuleName);
            }
        }

       
       
    }
}
