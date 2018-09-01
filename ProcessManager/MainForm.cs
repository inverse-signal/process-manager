using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ProcessManager
{
    public partial class MainForm : Form
    {
        public static Process SelectedProcess;
        public static bool RefreshInfo = true;

        public static bool RefreshModules = false;
        public static bool GotHandle = false;
        public MainForm()
        {
            InitializeComponent();
            RefreshProcessList();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ProcessRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        public void RefreshProcessList()
        {
            ProcessListBox.Items.Clear();
            Process[] proc_list = Process.GetProcesses();
            foreach (Process proc in proc_list)
            {
                ProcessItem process = new ProcessItem("PID: " + proc.Id + " Name: " + proc.ProcessName, proc);
                ProcessListBox.Items.Add(process);
            }
        }
        public void RefreshProcessInfo()
        {  // copying the process object will stop null errors in the timer.
            Process Tempprocess = SelectedProcess;
            if (SelectedProcess != null && !Tempprocess.HasExited )
            {
             
                ProcessInfoBox.Clear();
                ProcessInfoBox.AppendText("ProcessID: " + Tempprocess.Id + "\n");
                ProcessInfoBox.AppendText("Process Name" + Tempprocess.ProcessName + "\n");
                if (Tempprocess.MainWindowTitle != "")
                {
                    ProcessInfoBox.AppendText("Process Window " + Tempprocess.MainWindowTitle + "\n");
                }
                ProcessInfoBox.AppendText("Handle Count " + Tempprocess.HandleCount + "\n");
                ProcessInfoBox.AppendText("Memory Usage" + Tempprocess.WorkingSet.ToString() + "\n");
            }
            else if (SelectedProcess != null && SelectedProcess.HasExited)
            {
                ProcessInfoBox.Clear();
                ProcessInfoBox.AppendText("Process has exited");
            }
            else
            {
                ProcessInfoBox.Clear();
                ProcessInfoBox.AppendText("No Process..");
            }
        }
    

        private void SelectProcessButton_Click(object sender, EventArgs e)
        {
            // We cast the object into a processitem that is selected.
             ProcessItem selectedprocessbox = (ProcessItem)ProcessListBox.SelectedItem;
            if (selectedprocessbox != null)
            {
                SelectedProcess = selectedprocessbox.processvalue;
                RefreshProcessInfo();
                SelectedProcessLabel.Text = "Selected Process: " + SelectedProcess.Id.ToString();

            }
            else
            {
                SelectedProcessLabel.Text = "Selected Process: None";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void SearchProcessButton_Click(object sender, EventArgs e)
        {
            if (SearchProcessBox.Text != "")
            {
                ProcessListBox.Items.Clear();
                bool FoundResult = false;
                Process[] proc_list = Process.GetProcesses();
                string SearchTerm = SearchProcessBox.Text.ToLower();
                foreach (Process proc in proc_list)
                {
                    if (proc.Id.ToString() == SearchTerm || proc.ProcessName.ToLower().Contains(SearchTerm) || proc.MainWindowTitle.ToLower().Contains(SearchTerm))
                    {
                        ProcessItem process = new ProcessItem("PID: " + proc.Id + " Name: " + proc.ProcessName, proc);
                        ProcessListBox.Items.Add(process);
                        FoundResult = true;
                    }

                }
                if (!FoundResult)
                {
                    MessageBox.Show(null, "No results found for" + SearchProcessBox.Text, "Error");
                    ProcessListBox.Items.Clear();
                    SearchProcessBox.Clear();
                    RefreshProcessList();
                }
            }
            else
            {
                MessageBox.Show(null, "You cannot search for nothing", "Error");
            }
          
        }

        private void MainInformationTimer_Tick(object sender, EventArgs e)
        {
            
           
            if (SelectedProcess != null)
            {
                SelectedProcess.Refresh();
                if (RefreshInfo)
                {
                    RefreshProcessInfo();
                }
            }
           
        }

        private void refreshinfobox_CheckedChanged(object sender, EventArgs e)
        {
            if (refreshinfobox.Checked)
            {
                RefreshInfo = true;
            }
            else
            {
                RefreshInfo = false;
            }
        }

        private void RescanModuleButton_Click(object sender, EventArgs e)
        {
            if (SelectedProcess != null)
            {
                try
                {
                    ProcessModuleListBox.Items.Clear();
                    SelectedProcess.Refresh();
                    ProcessModuleCollection current_modules = SelectedProcess.Modules;

                    foreach (ProcessModule mod in current_modules)
                    {
                        ProcessModuleListBox.Items.Add(new ProcessModuleItem(mod.ModuleName, mod));
                    }
                }


                catch (System.ComponentModel.Win32Exception)
                {
                    MessageBox.Show(null, "You cannot view module information about this 64 bitprocess because you are in 32 bit mode \n Please recompile for x64 or use the x64 binary", "Error");
                }
            }

        }


        

        private void SaveModuleButton_Click(object sender, EventArgs e)
        {
            if (ProcessModuleListBox.SelectedItem != null)
            {
                ProcessModuleItem item = (ProcessModuleItem)ProcessModuleListBox.SelectedItem;
                ProcessModule module = item.processmodvalue;
                FileManager.SaveModule(module);
            }
        }

        private void ViewInfoButton_Click(object sender, EventArgs e)
        {
            if (ProcessModuleListBox.SelectedItem != null)
            {
                ProcessModuleItem item = (ProcessModuleItem)ProcessModuleListBox.SelectedItem;
                ProcessModule module = item.processmodvalue;
                MessageBox.Show(null, "Module name: " + module.ModuleName + "\n" +

                    "File path: " + module.FileName + "\n" + " Module size: " + module.ModuleMemorySize
                    + "\n" + "Base address: " + module.BaseAddress + "\n" +
                    "Entry point address: " + module.EntryPointAddress + "\n"
                    + module.FileVersionInfo  +"\n"
                    , "Module Information" + module.ModuleName);
                
            }
        }

        private void SaveAllInfoButton_Click(object sender, EventArgs e)
        {
            if (SelectedProcess != null)
            {
                FileManager.SaveModuleLogFile(SelectedProcess, SelectedProcess.Modules);
            }
         
        }

        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            if (SelectedProcess != null)
            {
                FileManager.SaveAllModules(SelectedProcess.Modules);
            }
        }

        private void RefreshModuleInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (RefreshModuleInfo.Checked)
            {
                RefreshModules = true;
            }
            else
            {
                RefreshModules = false;
            }
        }

        
        private void CreateProcessHandle_Click(object sender, EventArgs e)
        {
            if (SelectedProcess != null && !SelectedProcess.HasExited)
            {
                bool CreatedHandle = false;
                DialogResult Result = MessageBox.Show(null, "Would you like write access to this process?", "Memory Manager", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    CreatedHandle = Memory.InitMem(SelectedProcess, true);
                    if (CreatedHandle)
                    {
                        MessageBox.Show(null, "Successfuly created handle to Process " + SelectedProcess.ProcessName + " With write access", "Success");
                        WriteMemoryButton.Enabled = true;
                        ReadMemoryButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(null, "Could not create handle to " + SelectedProcess.ProcessName + " \n Try running ProcessManager as administrator." , "Error");
                        
                    }
                    
                }
                else
                {
                    CreatedHandle = Memory.InitMem(SelectedProcess, false);
                    if (CreatedHandle)
                    {
                        MessageBox.Show(null, "Successfuly created handle to Process " + SelectedProcess.ProcessName + " With read only access", "Success");
                        WriteMemoryButton.Enabled = true;
                        ReadMemoryButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(null, "Could not create handle to " + SelectedProcess.ProcessName + " \n Try running ProcessManager as administrator.", "Error");
                       

                    }
                    
                }
                GotHandle = CreatedHandle;

            }
           

        }

        // This is to disable controls of the memory manager if process is null or there is no handle to the process currently. 
        private void MemoryManagerTimer_Tick(object sender, EventArgs e)
        {
            if (SelectedProcess == null || SelectedProcess.HasExited)
            {
                CreateProcessHandle.Enabled = false;
                WriteMemoryButton.Enabled = false;
                ReadMemoryButton.Enabled = false;
            }
            else if (SelectedProcess != null && !SelectedProcess.HasExited)
            {
                CreateProcessHandle.Enabled = true;
            }

            if (SelectedProcess != null && !GotHandle && !SelectedProcess.HasExited)
            {
                WriteMemoryButton.Enabled = false;
                ReadMemoryButton.Enabled = false;
            }
            if (GotHandle && !SelectedProcess.HasExited)
            {
                MemoryStatusLabel.Text = "Status: Attached to " + SelectedProcess.ProcessName;
            }
            else
            {
                MemoryStatusLabel.Text = "Status: None";
            }

            
        }

        public  int GetInputValue(bool IsRead)
        {
            int InputValue;
            string NumberStr;
            if (IsRead)
            {
                 NumberStr = ReadMemoryBox.Text;
            }
            else
            {
                 NumberStr = WriteMemoryBox.Text;
            } 
            if (NumberStr.StartsWith("0x"))
            {
                NumberStr = NumberStr.Substring(2);
                InputValue = Int32.Parse(NumberStr, System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                InputValue = Int32.Parse(NumberStr);
            }

            return InputValue;
        }
        private void ReadMemoryButton_Click(object sender, EventArgs e)
        {

            if (GotHandle && ReadMemoryBox.Text != "")
            {
                string DataType = ReadMemDataTypeBox.Text; 
                int InputValue = GetInputValue(true); 
                if (DataType != null)
                {
                    if (DataType == "byte")
                    {
                        bool Result = Memory.ReadByte(InputValue);
                        MessageBox.Show(null, "Result: " + Result, "Memory of " + InputValue.ToString("X"));
                        ValueLabel.Text = "Value: " + Result;
                    }
                    if (DataType == "int")
                    {
                        int Result = Memory.ReadInteger(InputValue);
                        MessageBox.Show(null, "Result: " + Result, "Memory of " + InputValue.ToString("X"));
                        ValueLabel.Text = "Value: " + Result;
                    }
                    if (DataType == "float")
                    {
                        float Result = Memory.ReadFloat(InputValue);
                        MessageBox.Show(null, "Result: " + Result, "Memory of " + InputValue.ToString("X"));
                        ValueLabel.Text = "Value: " + Result;
                    }
                    if (DataType == "double")
                    {
                        double  Result = Memory.ReadDouble(InputValue);
                        MessageBox.Show(null, "Result: " + Result, "Memory of " + InputValue.ToString("X"));
                        ValueLabel.Text = "Value: " + Result;
                    }
                    if (DataType == "string")
                    {
                        int StringLen = (int)StringLengthUpDown.Value;
                        String Result = "";
                        DialogResult resultbox = MessageBox.Show(null, "Is your string unicode? ", "String options", MessageBoxButtons.YesNo);
                        if (resultbox == DialogResult.Yes)
                        {
                            Result = Memory.ReadString(InputValue, StringLen, true);
                        }
                        else if (resultbox == DialogResult.No)
                        {
                            Result = Memory.ReadString(InputValue, StringLen, false);
                        }
                        MessageBox.Show(null, "Result: " + Result, "Memory of " + InputValue.ToString("X"));
                        ValueLabel.Text = "Value: " + Result;
                    }
                }
            }
        }

        private void MemoryStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReadMemDataTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReadMemDataTypeBox.Text == "string")
            {
                StringLengthUpDown.Enabled = true;
            }
            else
            {
                StringLengthUpDown.Enabled = false;
            }
        }

        private void WriteMemDataTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void WriteMemoryButton_Click(object sender, EventArgs e)
        {
            string DataType = WriteMemDataTypeBox.Text;
            int InputValue = GetInputValue(false);
            if (DataType != null)
            {
                if (DataType == "byte")
                {
                    bool WriteValue = Convert.ToBoolean(WriteValueBox.Text);
                    Console.WriteLine(WriteValue);

                }
                if (DataType == "int")
                {
                   
                }
                if (DataType == "float")
                {
                   
                }
                if (DataType == "double")
                {
                 
                }
                if (DataType == "string")
                {
                   
                }
            }
        }

        private void WriteValueBoxFocused(object sender, EventArgs e)
        {
            WriteValueBox.Text = "";
        }

        private void WriteValueBoxNotFocused(object sender, EventArgs e)
        {
            if (WriteValueBox.Text == "")
            {
                WriteValueBox.Text = "Value";
            }
           
        }

        private void WriteAddressBoxFocus(object sender, EventArgs e)
        {
            WriteMemoryBox.Text = "";
        }

        private void WriteAddressBoxNotFocus(object sender, EventArgs e)
        {
            WriteMemoryBox.Text = "Address";
        }

        private void ReadAddressBoxFocus(object sender, EventArgs e)
        {
            ReadMemoryBox.Text = "";
        }

        private void ReadAddressBoxNotFocus(object sender, EventArgs e)
        {
            ReadMemoryBox.Text = "Address";
        }

        private void WriteValueBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
