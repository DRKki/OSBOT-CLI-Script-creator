using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FSManager;

namespace OSBotCreator
{
    public abstract class FormLogic
    {
        public static void switchPanels(Panel pnl1, Panel pnl2)
        {
            Point locCreate = pnl1.Location;
            Point locOverview = pnl2.Location;
            
            pnl1.Location = locOverview;
            pnl2.Location = locCreate;
        }

        public static string getPermissionString(CheckBox cbReflection, CheckBox cbCpu, CheckBox cbResource, CheckBox cbRandoms, CheckBox cbInterface, CheckBox cbRender)
        {
            string permissionString = "";
            List<string> permissionList = new List<string>();
            if (cbReflection.Checked)
                permissionList.Add("reflection");
            if (cbCpu.Checked)
                permissionList.Add("lowcpu");
            if (cbResource.Checked)
                permissionList.Add("lowresource");

            if(cbRandoms.Checked)
                permissionList.Add("norandoms");
            if (cbInterface.Checked)
                permissionList.Add("nointerface");
            if (cbRender.Checked)
                permissionList.Add("norender");


            for (int i = 0; i < permissionList.Count; i++)
            {
                permissionString += permissionList[i];
                if (i < (permissionList.Count -1))
                    permissionString += ",";
            }

            return permissionString + " ";
        }
        public static void activateTextbox(TextBox tb)
        {
            if (tb.ForeColor == SystemColors.ScrollBar)
            {
                tb.Text = "";
                tb.ForeColor = SystemColors.WindowText;
            }
        }
        public static void deactivateTextbox(TextBox tb,string text)
        {
            if (tb.ForeColor == SystemColors.WindowText)
            {
                tb.ForeColor = SystemColors.ScrollBar;
                tb.Text = text;                
            }
        }

        public static void setDefaultTextboxValue(TextBox tb,string value)
        {
            if (tb.ForeColor == SystemColors.ScrollBar) //empty textbox
                tb.Text = value;
        }
        public static bool isTextboxFilledIn(TextBox tb)
        {
            if (tb.ForeColor != SystemColors.ScrollBar)
                return true;
            else
                return false;
        }

        public static void makeNumericTextbox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static string stripString(string text)
        {
            string s = text;
            int start = s.IndexOf("[") + 1;
            int end = s.IndexOf("]", start);
            string result = s.Substring(start, end - start);
            return result;
        }
        public static string stripString(string text,string startChar,string endChar,int startIndex)
        {
            string s = text;
            int start = s.IndexOf(startChar) + startIndex;
            int end = s.IndexOf(endChar, start);
            string result = s.Substring(start, end - start);
            return result;
        }
        public static void updateOsbotJarSettingsFile(string path,string osbotJar)
        {
            try
            {         

                string jar = "", memory = "", debug = "", collectData = "", osbotUsername = "", osbotPassword = "", proxyIp = "", proxyPort = "", proxyUsername = "",
                proxyPassword = "", botUsername = "", botPassword = "", botPin = "", permission = "", scriptType = "", scriptName = "",
                scriptParams = "", world = "", name = "";


                List<string> iniFileLines = new List<string>();
                int count = 0;
                if (File.Exists(path))
                {
                    using (StreamReader read = new StreamReader(path))
                    {
                        while (!read.EndOfStream)//go through all the lines
                        {
                            iniFileLines.Add(read.ReadLine());//put them in a string list
                        }
                        count++;
                    }
                }                

                for (int i = 0; i < iniFileLines.Count; i++)
                {
                    if (iniFileLines[i].Contains("OSBot jar = ["))
                    {                        
                        jar = osbotJar;
                    }
                    if (iniFileLines[i].Contains("Memory = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        memory = result;
                    }
                    if (iniFileLines[i].Contains("Debug port = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        debug = result;
                    }
                    if (iniFileLines[i].Contains("Collect data = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        collectData = result;
                    }
                    if (iniFileLines[i].Contains("OSBot username = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        osbotUsername = result;
                    }
                    if (iniFileLines[i].Contains("OSBot password = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        osbotPassword = result;
                    }
                    if (iniFileLines[i].Contains("Proxy ip = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        proxyIp = result;
                    }
                    if (iniFileLines[i].Contains("Proxy port = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        proxyPort = result;
                    }
                    if (iniFileLines[i].Contains("Proxy username = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        proxyUsername = result;
                    }
                    if (iniFileLines[i].Contains("Proxy password = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        proxyPassword = result;
                    }
                    if (iniFileLines[i].Contains("Osrsbot username = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        botUsername = result;
                    }
                    if (iniFileLines[i].Contains("Osrsbot password = ["))
                    {

                        string result = FormLogic.stripString(iniFileLines[i]);
                        botPassword = result;
                    }
                    if (iniFileLines[i].Contains("Osrsbot pin = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        botPin = result;
                    }
                    if (iniFileLines[i].Contains("Permission = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        permission = result;
                    }
                    if (iniFileLines[i].Contains("Scripttype = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        scriptType = result;
                    }
                    if (iniFileLines[i].Contains("Script = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        scriptName = result;
                    }
                    if (iniFileLines[i].Contains("Script params = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        scriptParams = result;
                    }
                    if (iniFileLines[i].Contains("World = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        world = result;
                    }
                    if (iniFileLines[i].Contains("Name = ["))
                    {
                        string result = FormLogic.stripString(iniFileLines[i]);
                        name = result;
                    }
                }


                //write

                if (System.IO.File.Exists(path))
                    System.IO.File.WriteAllText(path, ""); // clear the file before writing   

                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("OSBot jar = [" + osbotJar + "]");
                    sw.WriteLine("Memory = [" + memory + "]");
                    sw.WriteLine("Debug port = [" + debug + "]");
                    sw.WriteLine("Collect data = [" + collectData + "]");
                    sw.WriteLine("OSBot username = [" + osbotUsername + "]");
                    sw.WriteLine("OSBot password = [" + osbotPassword + "]");

                    sw.WriteLine("Proxy ip = [" + proxyIp + "]");
                    sw.WriteLine("Proxy port = [" + proxyPort + "]");
                    sw.WriteLine("Proxy username = [" + proxyUsername + "]");
                    sw.WriteLine("Proxy password = [" + proxyPassword + "]");


                    sw.WriteLine("Osrsbot username = [" + botUsername + "]");
                    sw.WriteLine("Osrsbot password = [" + botPassword + "]");
                    sw.WriteLine("Osrsbot pin = [" + botPin + "]");
                    sw.WriteLine("Permission = [" + permission + "]");

                    if (scriptType == "Local")
                        sw.WriteLine("Scripttype = [Local] ");
                    else
                        sw.WriteLine("Scripttype = [SDN] ");

                    sw.WriteLine("Script = [" + scriptName + "]");
                    sw.WriteLine("Script params = [" + scriptParams + "]");

                    sw.WriteLine("World = [" + world + "]");

                    sw.WriteLine("Name = [" + name + "]");
                }
            }
            catch
            {

            }
        }
        public static void readSettings()
        {
            try
            {
                List<string> collectionIni = new List<string>();
                collectionIni.Clear(); // clear the list

                List<string> names = new List<string>();
                List<string> memories = new List<string>();
                List<string> accounts = new List<string>();
                List<string> scripts = new List<string>();
                List<string> jars = new List<string>();


                using (StreamReader read = new StreamReader(Variables.collectionFile))
                {
                    while (!read.EndOfStream)//go through all the lines
                    {
                        collectionIni.Add(read.ReadLine());//put them in a string list
                    }

                }

                List<string> iniFileLines = new List<string>();
                int count = 0;
                foreach (string t in collectionIni)
                {                    
                    if (File.Exists(Variables.configFolder + "\\" + collectionIni[count] + ".ini"))
                    {
                        using (StreamReader read = new StreamReader(Variables.configFolder + "\\" + collectionIni[count] + ".ini"))
                        {
                            while (!read.EndOfStream)//go through all the lines
                            {
                                iniFileLines.Add(read.ReadLine());//put them in a string list
                            }
                            count++;

                        }
                    }

                }

                for (int i = 0; i < iniFileLines.Count; i++)
                {
                    if (iniFileLines[i].Contains("Name = ["))
                    {
                        string result = stripString(iniFileLines[i]);
                        names.Add(result);
                    }
                    if (iniFileLines[i].Contains("Memory = ["))
                    {
                        string result = stripString(iniFileLines[i]);
                        memories.Add(result);
                    }
                    if (iniFileLines[i].Contains("Osrsbot username = ["))
                    {
                        string result = stripString(iniFileLines[i]);
                        accounts.Add(result);
                    }
                    if (iniFileLines[i].Contains("Script = ["))
                    {
                        string result = stripString(iniFileLines[i]);
                        scripts.Add(result);
                    }
                    if (iniFileLines[i].Contains("OSBot jar = ["))
                    {
                        string result = Path.GetFileName(stripString(iniFileLines[i]));
                        jars.Add(result);
                    }
                }

                Variables.listOfScripts.Clear();
                for (int i = 0; i < names.Count; i++)
                {
                    ListviewRecord lvRecord = new ListviewRecord(names[i], memories[i], accounts[i], scripts[i], jars[i]);
                    Variables.listOfScripts.Add(lvRecord);
                }
                
            }
            catch
            {

            }
        }

        public static void fillPresetsCombobox(ComboBox cb)
        {
            List<string> presets = new List<string>();
            presets = Files.getFileNamesInFolder(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Presets").ToList();

            //Clear the list before adding
            cb.Items.Clear();

            for (int i = 0; i < presets.Count; i++)
            {
                //remove file extension
                presets[i] = presets[i].Remove(presets[i].Length - 4);
                cb.Items.Add(presets[i]);
            }
        }

        public static void deleteRecord(string name)
        {
            File.Delete(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + name + ".bat");
            File.Delete(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\" + name + ".ini");

            //remove it from the collection
            List<string> collectionIni = new List<string>();
            using (StreamReader read = new StreamReader(Variables.collectionFile))
            {
                while (!read.EndOfStream)//go through all the lines
                {
                    collectionIni.Add(read.ReadLine());//put them in a string list
                }

            }
            //remove it from the list
            collectionIni.Remove(name);

            if (System.IO.File.Exists(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\Collection.ini"))
                System.IO.File.WriteAllText(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\Collection.ini", ""); // clear the file before writing   

            //write the file again
            using (FileStream fs = new FileStream(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\Collection.ini", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                for (int i = 0; i < collectionIni.Count; i++)
                {
                    sw.WriteLine(collectionIni[i]);
                }
            }


        }
        
        public static void fillListview(ListView lv)
        {            
            readSettings();

            lv.Items.Clear();

            for(int i = 0; i < Variables.listOfScripts.Count; i++)
            {
                ListViewItem lvItem = new ListViewItem(Variables.listOfScripts[i].name);

                if(Variables.listOfScripts[i].memory == "")
                    lvItem.SubItems.Add("default");
                else
                    lvItem.SubItems.Add(Variables.listOfScripts[i].memory + "MB");

                lvItem.SubItems.Add(Variables.listOfScripts[i].account);

                if(Variables.listOfScripts[i].script != "ID" && Variables.listOfScripts[i].script != "Name")
                    lvItem.SubItems.Add(Variables.listOfScripts[i].script);
                else
                    lvItem.SubItems.Add("None");

                lvItem.SubItems.Add(Variables.listOfScripts[i].jar);

                lv.Items.Add(lvItem);
            }
            

        }
    }
}

