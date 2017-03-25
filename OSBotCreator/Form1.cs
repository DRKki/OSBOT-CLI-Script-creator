using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FSManager;
using System.IO;
using System.Diagnostics;

namespace OSBotCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Variables.editing = false;
            button1.Text = "Create";
            lblNameScript.Visible = true;
            tbNameScript.Visible = true;
            lblBlacklist.Visible = true;

            pnlCreate.Visible = true;
            pnlOverview.Visible = false;
            FormLogic.switchPanels(pnlCreate, pnlOverview);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbOsbotJar.Text != "" && tbNameScript.Text != "" && !Variables.illegalCharacters)
            {
                //check port number

                FormLogic.setDefaultTextboxValue(tbBotPin, "0000");


                if (tbMem.Text != "")
                    Variables.memory = "-mem " + tbMem.Text + " ";

                if (tbDebugPort.Text == "")
                    Variables.debugPort = "-debug 5005 ";
                else
                    Variables.debugPort = "-debug " + tbDebugPort.Text + " ";

                if (FormLogic.isTextboxFilledIn(tbData))
                    Variables.allowDataCollection = "-data " + tbData.Text + " ";
                else
                    Variables.allowDataCollection = "";

                if (!cbReflection.Checked && !cbCpu.Checked && !cbResource.Checked && !cbRandoms.Checked && !cbInterface.Checked && !cbRender.Checked)
                    Variables.allowPermission = "";
                else
                    Variables.allowPermission = "-allow " + FormLogic.getPermissionString(cbReflection, cbCpu, cbResource,cbRandoms,cbInterface,cbRender);




                if (!FormLogic.isTextboxFilledIn(tbProxyPort) || !FormLogic.isTextboxFilledIn(tbProxyIp))
                {
                    Variables.proxy = "";
                }
                else
                {
                    if (FormLogic.isTextboxFilledIn(tbProxyUsername) && FormLogic.isTextboxFilledIn(tbProxyPassword))
                        Variables.proxy = "-proxy " + tbProxyIp.Text + ":" + tbProxyPort.Text + ":" + tbProxyUsername.Text + ":" + tbProxyPassword.Text + " ";
                    else
                        Variables.proxy = "-proxy " + tbProxyIp.Text + ":" + tbProxyPort.Text + " ";
                }

                Variables.osbotLogin = "-login " + "\"" + tbOsbotUsername.Text + "\"" + ":" + tbOsbotPassword.Text + " ";
                Variables.osbotUsername = tbOsbotUsername.Text;
                Variables.osbotPassword = tbOsbotPassword.Text;

                Variables.botLogin = "-bot " + tbBotUsername.Text + ":" + tbBotPassword.Text + ":" + tbBotPin.Text + " ";


                if (FormLogic.isTextboxFilledIn(tbScriptIdName))
                {
                    if (FormLogic.isTextboxFilledIn(tbScriptParams))
                    {
                        //    "\"planker at varrock\":0"
                        if(rbLocalScript.Checked)
                            Variables.script = "-script " + "\"\"" + tbScriptIdName.Text + "\"" + ":" + tbScriptParams.Text + "\" ";
                        else
                            Variables.script = "-script " + tbScriptIdName.Text + ":" + tbScriptParams.Text + " ";

                        Variables.scriptIdName = tbScriptIdName.Text;
                        Variables.scriptParams = tbScriptParams.Text;
                    }
                    else
                    {
                        if(rbLocalScript.Checked)                        
                            Variables.script = "-script " + "\"\\\"" + tbScriptIdName.Text + "\\\"" + ":0\" ";
                        else
                            Variables.script = "-script " + tbScriptIdName.Text + ":0 ";
                    }
                }
                else
                    Variables.script = "";


                if (tbWorld.Text != "")
                    Variables.world = "-world " + tbWorld.Text + " ";
                else
                    Variables.world = "";

                Variables.cliString = "java -jar \"" + tbOsbotJar.Text + "\" " + Variables.memory + Variables.debugPort + Variables.allowDataCollection + Variables.allowPermission + Variables.proxy + Variables.osbotLogin + Variables.botLogin + Variables.script + Variables.world;


                if (System.IO.File.Exists(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + tbNameScript.Text + ".bat"))
                    System.IO.File.WriteAllText(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + tbNameScript.Text + ".bat", "");

                //Write the .bat
                using (FileStream fs = new FileStream(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + tbNameScript.Text + ".bat", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(Variables.cliString);
                }

                //Variables.collectionFile
                if (!Variables.editing)
                {
                    List<string> collectionIni = new List<string>();
                    if(!File.Exists(Variables.collectionFile))
                    {
                        using (FileStream fs = new FileStream(Variables.collectionFile, FileMode.Append, FileAccess.Write))
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            
                        }
                    }
                    using (StreamReader read = new StreamReader(Variables.collectionFile))
                    {
                        while (!read.EndOfStream)//go through all the lines
                        {
                            collectionIni.Add(read.ReadLine());//put them in a string list
                        }

                    }

                    using (FileStream fs = new FileStream(Variables.collectionFile, FileMode.Append, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        if(!collectionIni.Contains(tbNameScript.Text))
                            sw.WriteLine(tbNameScript.Text);
                    }
                }


                if (System.IO.File.Exists(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\" + tbNameScript.Text + ".ini"))
                    System.IO.File.WriteAllText(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\" + tbNameScript.Text + ".ini", ""); // clear the file before writing   

                //Write the .ini, used to easily edit existing files
                using (FileStream fs = new FileStream(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\" + tbNameScript.Text + ".ini", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("OSBot jar = [" + tbOsbotJar.Text + "]");
                    sw.WriteLine("Memory = [" + tbMem.Text + "]");
                    sw.WriteLine("Debug port = [" + tbDebugPort.Text + "]");
                    sw.WriteLine("Collect data = [" + tbData.Text + "]");
                    sw.WriteLine("OSBot username = [" + tbOsbotUsername.Text + "]");
                    sw.WriteLine("OSBot password = [" + tbOsbotPassword.Text + "]");

                    sw.WriteLine("Proxy ip = [" + tbProxyIp.Text + "]");
                    sw.WriteLine("Proxy port = [" + tbProxyPort.Text + "]");
                    sw.WriteLine("Proxy username = [" + tbProxyUsername.Text + "]");
                    sw.WriteLine("Proxy password = [" + tbProxyPassword.Text + "]");


                    sw.WriteLine("Osrsbot username = [" + tbBotUsername.Text + "]");
                    sw.WriteLine("Osrsbot password = [" + tbBotPassword.Text + "]");
                    sw.WriteLine("Osrsbot pin = [" + tbBotPin.Text + "]");
                    sw.WriteLine("Permission = [" + FormLogic.getPermissionString(cbReflection, cbCpu, cbResource, cbRandoms, cbInterface, cbRender) + "]");

                    if (rbLocalScript.Checked)
                        sw.WriteLine("Scripttype = [Local] ");
                    else
                        sw.WriteLine("Scripttype = [SDN] ");

                    sw.WriteLine("Script = [" + tbScriptIdName.Text + "]");
                    sw.WriteLine("Script params = [" + tbScriptParams.Text + "]");

                    sw.WriteLine("World = [" + tbWorld.Text + "]");

                    sw.WriteLine("Name = [" + tbNameScript.Text + "]");
                }

                FormLogic.fillListview(listView1);

                pnlCreate.Visible = false;
                pnlOverview.Visible = true;
                FormLogic.switchPanels(pnlCreate, pnlOverview);

            }
            else
            {
                if (tbOsbotJar.Text == "")
                    tbOsbotJar.BackColor = Color.Red;
                else
                    tbNameScript.BackColor = Color.Red;
            }
        }

        private void tbProxyPassword_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword))
                tbOsbotUsername.Focus();
            else
            {
                FormLogic.activateTextbox(tbProxyPassword);
                tbProxyPassword.PasswordChar = '*';
            }


            
        }

        private void tbProxyPassword_Leave(object sender, EventArgs e)
        {
            if(tbProxyPassword.Text == "")
            tbProxyPassword.PasswordChar = '\0';

            if (tbProxyPassword.Text == "")
                FormLogic.deactivateTextbox(tbProxyPassword, "Password");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbOsbotJar.BackColor = SystemColors.Control;

            Variables.osbotJarPath = Files.getSelectedFileWithPath("OSBot jars","*.jar");
            tbOsbotJar.Text = Variables.osbotJarPath;            
        }

        private void rbLocalScript_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLocalScript.Checked)
                tbScriptIdName.Text = "Name";
            else
                tbScriptIdName.Text = "ID";

            tbScriptIdName.ForeColor = SystemColors.ScrollBar;
        }

        private void rbSdnScript_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSdnScript.Checked)
                tbScriptIdName.Text = "ID";
            else
                tbScriptIdName.Text = "Name";

            tbScriptIdName.ForeColor = SystemColors.ScrollBar;
        }


        private void cbResource_CheckedChanged(object sender, EventArgs e)
        {
            if (cbResource.Checked)
            {
                if (FormLogic.isTextboxFilledIn(tbBotPassword) && FormLogic.isTextboxFilledIn(tbBotUsername) && FormLogic.isTextboxFilledIn(tbOsbotUsername) && FormLogic.isTextboxFilledIn(tbOsbotPassword))                
                    cbResource.Checked = true;                
                else
                    cbResource.Checked = false;
            }
            
        }

        private void tbProxyIp_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword))
                tbOsbotUsername.Focus();
            else
                FormLogic.activateTextbox(tbProxyIp);            
        }

        private void tbProxyIp_Leave(object sender, EventArgs e)
        {
            if (tbProxyIp.Text == "")
                FormLogic.deactivateTextbox(tbProxyIp, "IP");
        }

        private void tbProxyPort_Leave(object sender, EventArgs e)
        {
            if (tbProxyPort.Text == "")
                FormLogic.deactivateTextbox(tbProxyPort, "Port");
        }

        private void tbProxyUsername_Leave(object sender, EventArgs e)
        {
            if (tbProxyUsername.Text == "")
                FormLogic.deactivateTextbox(tbProxyUsername, "Username");
        }

        private void tbOsbotUsername_Leave(object sender, EventArgs e)
        {
            if (tbOsbotUsername.Text == "")
            {
                cbResource.Checked = false;
                FormLogic.deactivateTextbox(tbOsbotUsername, "Username");
            }
        }

        private void tbOsbotPassword_Leave(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotPassword) || tbOsbotPassword.Text == "")
            {
                cbResource.Checked = false;
                FormLogic.deactivateTextbox(tbOsbotPassword, "Password");
                tbOsbotPassword.PasswordChar = '\0';
            }            
                
        }

        private void tbBotUsername_Leave(object sender, EventArgs e)
        {
            if (tbBotUsername.Text == "")
            {
                cbResource.Checked = false;
                FormLogic.deactivateTextbox(tbBotUsername, "Username");
            }
        }

        private void tbBotPassword_Leave(object sender, EventArgs e)
        {

            if (tbBotPassword.Text == "")
            {
                cbResource.Checked = false;
                FormLogic.deactivateTextbox(tbBotPassword, "Password");
                tbBotPassword.PasswordChar = '\0';
            }            
        }

        private void tbBotPin_Leave(object sender, EventArgs e)
        {
            if (tbBotPin.Text == "")
                FormLogic.deactivateTextbox(tbBotPin, "Pin");
        }

        private void tbScriptIdName_Leave(object sender, EventArgs e)
        {
            string tbString;
            if (rbLocalScript.Checked)
                tbString = "Name";
            else
                tbString = "ID";

            if (tbScriptIdName.Text == "")
                FormLogic.deactivateTextbox(tbScriptIdName, tbString);
        }

        private void tbData_Leave(object sender, EventArgs e)
        {
            if (tbData.Text == "")
                FormLogic.deactivateTextbox(tbData, "0 or 1");
        }

        private void tbProxyUsername_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword))
                tbOsbotUsername.Focus();
            else
                FormLogic.activateTextbox(tbProxyUsername);

        }

        private void tbProxyPort_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword))
                tbOsbotUsername.Focus();
            else
                FormLogic.activateTextbox(tbProxyPort);            
        }

        private void tbOsbotUsername_Enter(object sender, EventArgs e)
        {
            FormLogic.activateTextbox(tbOsbotUsername);
        }

        private void tbOsbotPassword_Enter(object sender, EventArgs e)
        {
            FormLogic.activateTextbox(tbOsbotPassword);
            tbOsbotPassword.PasswordChar = '*';
        }

        private void tbBotUsername_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword))
                tbOsbotUsername.Focus();
            else
                FormLogic.activateTextbox(tbBotUsername);

        }

        private void tbBotPassword_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword))
                tbOsbotUsername.Focus();
            else
            {
                tbBotPassword.PasswordChar = '*';
                FormLogic.activateTextbox(tbBotPassword);
            }
        }

        private void tbBotPin_Enter(object sender, EventArgs e)
        {            
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword))                       
                tbOsbotUsername.Focus();                            
            else
                FormLogic.activateTextbox(tbBotPin);
        }

        private void tbScriptIdName_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword) || !FormLogic.isTextboxFilledIn(tbBotUsername) || !FormLogic.isTextboxFilledIn(tbBotPassword))
            {
                tbOsbotUsername.Focus();
            }
            else
                FormLogic.activateTextbox(tbScriptIdName);
        }

        private void tbData_Enter(object sender, EventArgs e)
        {
            FormLogic.activateTextbox(tbData);
        }

        private void tbWorld_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword) || !FormLogic.isTextboxFilledIn(tbBotUsername) || !FormLogic.isTextboxFilledIn(tbBotPassword))
            {
                tbOsbotUsername.Focus();
            }
        }

        private void tbNameScript_Enter(object sender, EventArgs e)
        {
            tbNameScript.BackColor = SystemColors.Window;
        }

        private void tbData_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormLogic.makeNumericTextbox(sender, e);            
        }

        private void tbProxyIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbProxyPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbWorld_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormLogic.makeNumericTextbox(sender, e);
        }

        private void tbDebugPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormLogic.makeNumericTextbox(sender, e);
        }

        private void tbMem_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormLogic.makeNumericTextbox(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCreate.Visible = false;
            pnlOverview.Visible = true;
            this.Size = new Size(520, 671);
            Directory.CreateDirectory(Variables.userProfile + "\\Documents\\OSBot Script Creator");
            Directory.CreateDirectory(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Presets");
            Folders.CreateHiddenFolder(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config");

            FormLogic.fillListview(listView1);
            FormLogic.fillPresetsCombobox(cbPresets);       
        }

        private void tbScriptParams_Enter(object sender, EventArgs e)
        {
            if (!FormLogic.isTextboxFilledIn(tbOsbotUsername) || !FormLogic.isTextboxFilledIn(tbOsbotPassword) || !FormLogic.isTextboxFilledIn(tbBotUsername) || !FormLogic.isTextboxFilledIn(tbBotPassword))
            {
                tbOsbotUsername.Focus();
            }
            else
                FormLogic.activateTextbox(tbScriptParams);
        }

        private void tbScriptParams_Leave(object sender, EventArgs e)
        {       
            if (tbScriptParams.Text == "")
                FormLogic.deactivateTextbox(tbScriptParams, "param1,param2");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlCreate.Visible = false;
            pnlOverview.Visible = true;
            FormLogic.switchPanels(pnlCreate, pnlOverview);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var si = new ProcessStartInfo("http://osbot.org/forum/user/27074-the-hero-of-time/");
            Process.Start(si);
            linkLabel1.LinkVisited = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tbPreset.Text != "" && tbPreset.BackColor != Color.Red)
            {
                if (System.IO.File.Exists(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Presets\\" + tbPreset.Text + ".ini"))
                    System.IO.File.WriteAllText(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Presets\\" + tbPreset.Text + ".ini", ""); // clear the file before writing   

                using (FileStream fs = new FileStream(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Presets\\" + tbPreset.Text + ".ini", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("OSBot jar = [" + tbOsbotJar.Text + "]");
                    sw.WriteLine("Memory = [" + tbMem.Text + "]");
                    sw.WriteLine("Debug port = [" + tbDebugPort.Text + "]");
                    sw.WriteLine("Collect data = [" + tbData.Text + "]");
                    sw.WriteLine("OSBot username = [" + tbOsbotUsername.Text + "]");
                    sw.WriteLine("OSBot password = [" + tbOsbotPassword.Text + "]");

                    sw.WriteLine("Proxy ip = [" + tbProxyIp.Text + "]");
                    sw.WriteLine("Proxy port = [" + tbProxyPort.Text + "]");
                    sw.WriteLine("Proxy username = [" + tbProxyUsername.Text + "]");
                    sw.WriteLine("Proxy password = [" + tbProxyPassword.Text + "]");


                    sw.WriteLine("Osrsbot username = [" + tbBotUsername.Text + "]");
                    sw.WriteLine("Osrsbot password = [" + tbBotPassword.Text + "]");
                    sw.WriteLine("Osrsbot pin = [" + tbBotPin.Text + "]");
                    sw.WriteLine("Permission = [" + FormLogic.getPermissionString(cbReflection, cbCpu, cbResource, cbRandoms, cbInterface, cbRender) + "]");
                    sw.WriteLine("Script = [" + tbScriptIdName.Text + "]");
                    sw.WriteLine("Script params = [" + tbScriptParams.Text + "]");

                    sw.WriteLine("World = [" + tbWorld.Text + "]");

                    sw.WriteLine("Name = [" + tbNameScript.Text + "]");
                }

                tbPreset.Text = "";
                FormLogic.fillPresetsCombobox(cbPresets);
            }
        }



        private void cbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string preset = cbPresets.SelectedItem.ToString();

            List<string> lines = new List<string>();

            if (File.Exists(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Presets\\" + preset + ".ini"))
            {
                using (StreamReader read = new StreamReader(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Presets\\" + preset + ".ini"))
                {
                    while (!read.EndOfStream)//go through all the lines
                    {
                        lines.Add(read.ReadLine());//put them in a string list
                    }
                }
            }
            else
            {
                MessageBox.Show("Could not find preset " + preset);
                FormLogic.fillPresetsCombobox(cbPresets);
            }


            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains("OSBot jar = ["))
                {
                    string result = Path.GetFileName(FormLogic.stripString(lines[i]));
                    tbOsbotJar.Text = FormLogic.stripString(lines[i]);                    
                }
                if (lines[i].Contains("Memory = ["))
                {                   
                    string result = FormLogic.stripString(lines[i]);
                    tbMem.Text = result;

                    if (result != "")
                        tbMem.ForeColor = SystemColors.WindowText;
                }
                if (lines[i].Contains("Debug port = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbDebugPort.Text = result;

                    if (result != "")
                        tbDebugPort.ForeColor = SystemColors.WindowText;
                }
                if (lines[i].Contains("Collect data = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbData.Text = result;

                    if (result != "" && result != "0 or 1")
                        tbData.ForeColor = SystemColors.WindowText;
                    else
                        tbData.ForeColor = SystemColors.ScrollBar;
                }
                if (lines[i].Contains("OSBot username = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbOsbotUsername.Text = result;

                    if (result != "" && result != "Username")
                        tbOsbotUsername.ForeColor = SystemColors.WindowText;
                    else
                        tbOsbotUsername.ForeColor = SystemColors.ScrollBar;
                }
                if (lines[i].Contains("OSBot password = ["))
                {
                    

                    string result = FormLogic.stripString(lines[i]);
                    tbOsbotPassword.Text = result;

                    if (result != "" && result != "Password")
                    {
                        tbOsbotPassword.PasswordChar = '*';
                        tbOsbotPassword.ForeColor = SystemColors.WindowText;
                    }
                    else
                    {
                        tbOsbotPassword.PasswordChar = '\0';
                        tbOsbotPassword.ForeColor = SystemColors.ScrollBar;
                    }
                }
                if (lines[i].Contains("Proxy ip = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbProxyIp.Text = result;

                    if (result != "" && result != "IP")
                        tbProxyIp.ForeColor = SystemColors.WindowText;
                    else
                        tbProxyIp.ForeColor = SystemColors.ScrollBar;
                }
                if (lines[i].Contains("Proxy port = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbProxyPort.Text = result;

                    if (result != "" && result != "Port")
                        tbProxyPort.ForeColor = SystemColors.WindowText;
                    else
                        tbProxyPort.ForeColor = SystemColors.ScrollBar;
                }
                if (lines[i].Contains("Proxy username = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbProxyUsername.Text = result;

                    if (result != "" && result != "Username")
                        tbProxyUsername.ForeColor = SystemColors.WindowText;
                    else
                        tbProxyUsername.ForeColor = SystemColors.ScrollBar;
                }
                if (lines[i].Contains("Proxy password = ["))
                {
                    

                    string result = FormLogic.stripString(lines[i]);
                    tbProxyPassword.Text = result;

                    if (result != "" && result != "Password")
                    {
                        tbProxyPassword.PasswordChar = '*';
                        tbProxyPassword.ForeColor = SystemColors.WindowText;
                    }
                    else
                    {
                        tbProxyPassword.PasswordChar = '\0';
                        tbProxyUsername.ForeColor = SystemColors.ScrollBar;
                    }
                }
                if (lines[i].Contains("Osrsbot username = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbBotUsername.Text = result;

                    if (result != "" && result != "Username")
                        tbBotUsername.ForeColor = SystemColors.WindowText;
                    else
                        tbBotUsername.ForeColor = SystemColors.ScrollBar;
                }
                if (lines[i].Contains("Osrsbot password = ["))
                {
                    
                    string result = FormLogic.stripString(lines[i]);
                    tbBotPassword.Text = result;

                    if (result != "" && result != "Password")
                    {
                        tbBotPassword.PasswordChar = '*';
                        tbBotPassword.ForeColor = SystemColors.WindowText;
                    }
                    else
                    {
                        tbBotPassword.PasswordChar = '\0';
                        tbBotPassword.ForeColor = SystemColors.ScrollBar;
                    }
                }
                if (lines[i].Contains("Osrsbot pin = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbBotPin.Text = result;

                    if (result != "" && result != "Pin")
                        tbBotPin.ForeColor = SystemColors.WindowText;
                    else
                        tbBotPin.ForeColor = SystemColors.ScrollBar;
                }
                if (lines[i].Contains("Permission = ["))
                {
                    string result = FormLogic.stripString(lines[i]);

                    if (result.Contains("reflection"))
                        cbReflection.Checked = true;
                    else
                        cbReflection.Checked = false;

                    if (result.Contains("lowcpu"))
                        cbCpu.Checked = true;
                    else
                        cbCpu.Checked = false;

                    if (result.Contains("lowresource"))
                        cbResource.Checked = true;
                    else
                        cbResource.Checked = false;
                }
                if (lines[i].Contains("Script params = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbScriptParams.Text = result;

                    if (result != "" && result != "param1,param2")
                        tbScriptParams.ForeColor = SystemColors.WindowText;
                    else
                        tbScriptParams.ForeColor = SystemColors.ScrollBar;
                }
                if (lines[i].Contains("World = ["))
                {
                    string result = FormLogic.stripString(lines[i]);
                    tbWorld.Text = result;

                    if (result != "")
                        tbWorld.ForeColor = SystemColors.WindowText;
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cbPresets.Text = "";
            System.IO.File.Delete(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Presets\\" + cbPresets.SelectedItem.ToString() + ".ini");
            FormLogic.fillPresetsCombobox(cbPresets);
        }

        private void btnRunBat_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string file = listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0])].Text + ".bat";
                if (File.Exists(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + file))
                    System.Diagnostics.Process.Start(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + file);
                else
                    MessageBox.Show("Can't find file: \"" + file + "\"\r\nHave you moved/deleted the file?","File missing!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {                            
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Selected)
                    {
                        string file = item.Text + ".bat";
                        System.Diagnostics.Process.Start(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + file);
                    }
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            btnRunBat_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string item = listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0])].Text;

                Variables.editing = true;
                button1.Text = "Edit";
                lblNameScript.Visible = false;
                tbNameScript.Visible = false;
                lblBlacklist.Visible = false;
                tbNameScript.Text = item;

                pnlCreate.Visible = true;
                pnlOverview.Visible = false;
                FormLogic.switchPanels(pnlOverview, pnlCreate);


                List<string> lines = new List<string>();

                if (File.Exists(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\" + item + ".ini"))
                {
                    using (StreamReader read = new StreamReader(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config\\" + item + ".ini"))
                    {
                        while (!read.EndOfStream)//go through all the lines
                        {
                            lines.Add(read.ReadLine());//put them in a string list
                        }
                    }
                }


                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains("OSBot jar = ["))
                    {
                        string result = Path.GetFileName(FormLogic.stripString(lines[i]));
                        tbOsbotJar.Text = FormLogic.stripString(lines[i]);
                    }
                    if (lines[i].Contains("Memory = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbMem.Text = result;

                        if (result != "")
                            tbMem.ForeColor = SystemColors.WindowText;
                    }
                    if (lines[i].Contains("Debug port = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbDebugPort.Text = result;

                        if (result != "")
                            tbDebugPort.ForeColor = SystemColors.WindowText;
                    }
                    if (lines[i].Contains("Collect data = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbData.Text = result;

                        if (result != "" && result != "0 or 1")
                            tbData.ForeColor = SystemColors.WindowText;
                        else
                            tbData.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("OSBot username = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbOsbotUsername.Text = result;

                        if (result != "" && result != "Username")
                            tbOsbotUsername.ForeColor = SystemColors.WindowText;
                        else
                            tbOsbotUsername.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("OSBot password = ["))
                    {


                        string result = FormLogic.stripString(lines[i]);
                        tbOsbotPassword.Text = result;

                        if (result != "" && result != "Password")
                        {
                            tbOsbotPassword.PasswordChar = '*';
                            tbOsbotPassword.ForeColor = SystemColors.WindowText;
                        }
                        else
                        {
                            tbOsbotPassword.PasswordChar = '\0';
                            tbOsbotPassword.ForeColor = SystemColors.ScrollBar;
                        }
                    }
                    if (lines[i].Contains("Proxy ip = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbProxyIp.Text = result;

                        if (result != "" && result != "IP")
                            tbProxyIp.ForeColor = SystemColors.WindowText;
                        else
                            tbProxyIp.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("Proxy port = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbProxyPort.Text = result;

                        if (result != "" && result != "Port")
                            tbProxyPort.ForeColor = SystemColors.WindowText;
                        else
                            tbProxyPort.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("Proxy username = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbProxyUsername.Text = result;

                        if (result != "" && result != "Username")
                            tbProxyUsername.ForeColor = SystemColors.WindowText;
                        else
                            tbProxyUsername.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("Proxy password = ["))
                    {


                        string result = FormLogic.stripString(lines[i]);
                        tbProxyPassword.Text = result;

                        if (result != "" && result != "Password")
                        {
                            tbProxyPassword.PasswordChar = '*';
                            tbProxyPassword.ForeColor = SystemColors.WindowText;
                        }
                        else
                        {
                            tbProxyPassword.PasswordChar = '\0';
                            tbProxyUsername.ForeColor = SystemColors.ScrollBar;
                        }
                    }
                    if (lines[i].Contains("Osrsbot username = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbBotUsername.Text = result;

                        if (result != "" && result != "Username")
                            tbBotUsername.ForeColor = SystemColors.WindowText;
                        else
                            tbBotUsername.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("Osrsbot password = ["))
                    {

                        string result = FormLogic.stripString(lines[i]);
                        tbBotPassword.Text = result;

                        if (result != "" && result != "Password")
                        {
                            tbBotPassword.PasswordChar = '*';
                            tbBotPassword.ForeColor = SystemColors.WindowText;
                        }
                        else
                        {
                            tbBotPassword.PasswordChar = '\0';
                            tbBotPassword.ForeColor = SystemColors.ScrollBar;
                        }
                    }
                    if (lines[i].Contains("Osrsbot pin = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbBotPin.Text = result;

                        if (result != "" && result != "Pin")
                            tbBotPin.ForeColor = SystemColors.WindowText;
                        else
                            tbBotPin.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("Permission = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);

                        if (result.Contains("reflection"))
                            cbReflection.Checked = true;
                        else
                            cbReflection.Checked = false;

                        if (result.Contains("lowcpu"))
                            cbCpu.Checked = true;
                        else
                            cbCpu.Checked = false;

                        if (result.Contains("lowresource"))
                            cbResource.Checked = true;
                        else
                            cbResource.Checked = false;
                    }
                    if (lines[i].Contains("Scripttype = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);

                        if (result == "Local")
                            rbLocalScript.Checked = true;
                        else
                            rbSdnScript.Checked = true;
                    }
                    if (lines[i].Contains("Script = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbScriptIdName.Text = result;

                        if (result != "" && result != "ID" && result != "Name")
                            tbScriptIdName.ForeColor = SystemColors.WindowText;
                        else
                            tbScriptIdName.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("Script params = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbScriptParams.Text = result;

                        if (result != "" && result != "param1,param2")
                            tbScriptParams.ForeColor = SystemColors.WindowText;
                        else
                            tbScriptParams.ForeColor = SystemColors.ScrollBar;
                    }
                    if (lines[i].Contains("World = ["))
                    {
                        string result = FormLogic.stripString(lines[i]);
                        tbWorld.Text = result;

                        if (result != "")
                            tbWorld.ForeColor = SystemColors.WindowText;
                    }

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string item = listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0])].Text;
                FormLogic.deleteRecord(item);
                listView1.Items.RemoveAt(listView1.Items.IndexOf(listView1.SelectedItems[0]));
            }
            else
            {
                //multiple deletes
                if(listView1.SelectedItems.Count > 1)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.Selected)
                        {
                            string file = item.Text;
                            FormLogic.deleteRecord(file);
                            listView1.Items.RemoveAt(listView1.Items.IndexOf(listView1.SelectedItems[0]));
                        }
                    }
                }
            }
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (listView1.SelectedItems.Count > 0)
                    btnDelete_Click(sender, e);
            }
        }

        private void tbNameScript_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> blackList = new List<string> { "\\", "/", ":", "*", "?", "\"", "<", ">", "|", "[", "]", "Collection" };


            for (int i = 0; i < blackList.Count; i++)
            {
                if (tbNameScript.Text.Contains(blackList[i]) || tbNameScript.Text.Count() >= 240)
                {
                    tbNameScript.BackColor = Color.Red;
                    Variables.illegalCharacters = true;
                    break;
                }
                else
                {
                    tbNameScript.BackColor = SystemColors.Window;
                    Variables.illegalCharacters = false;

                }
            }
        }

        private void tbPreset_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> blackList = new List<string> { "\\", "/", ":", "*", "?", "\"", "<", ">", "|", "[", "]" };


            for (int i = 0; i < blackList.Count; i++)
            {
                if (tbPreset.Text.Contains(blackList[i]) || tbPreset.Text.Count() >= 240)
                {
                    tbPreset.BackColor = Color.Red;                    
                    break;
                }
                else
                {
                    tbPreset.BackColor = SystemColors.Window;                    

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will update every script with the new selected OSBot jar. Do you wish to do this?","Update All",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {//Hij skipt de messagebox gewoon
                try
                {
                    string newOsbotJar = FSManager.Files.getSelectedFileWithPath("OSBot jars", "*.jar");
                    string[] iniFiles = FSManager.Files.getFilesWithPathInFolder(Variables.userProfile + "\\Documents\\OSBot Script Creator\\Config");

                    if (newOsbotJar != "")
                    {
                        for (int i = 0; i < iniFiles.Length; i++)
                        {
                            if (!iniFiles[i].Contains("Collection.ini"))
                                FormLogic.updateOsbotJarSettingsFile(iniFiles[i], newOsbotJar);
                        }

                        FormLogic.fillListview(listView1);


                        //.Bats
                        string[] batFiles = Files.getFileNamesInFolder(Variables.userProfile + "\\Documents\\OSBot Script Creator", "*.bat");
                        for (int i = 0; i < batFiles.Count(); i++)
                        {
                            string batText = File.ReadAllText(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + batFiles[i]);
                            string oldJar = FormLogic.stripString(batText, "-jar", ".jar", 6);
                            batText = batText.Replace((oldJar + ".jar"), newOsbotJar);




                            if (System.IO.File.Exists(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + batFiles[i]))
                                System.IO.File.WriteAllText(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + batFiles[i], "");

                            //Write the .bat
                            using (FileStream fs = new FileStream(Variables.userProfile + "\\Documents\\OSBot Script Creator\\" + batFiles[i], FileMode.Append, FileAccess.Write))
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.WriteLine(batText);
                            }
                        }
                    }                    
                }
                catch
                {

                }
            }
        }

        private void cbRandoms_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRandoms.Checked)
                lblRandomWarning.Visible = true;
            else
                lblRandomWarning.Visible = false;
        }

        private void cbInterface_CheckedChanged(object sender, EventArgs e)
        {
            if(cbInterface.Checked)
            {
                cbResource.Checked = false;
                cbResource.Enabled = false;
            }
            else
            {
                cbResource.Checked = true;
                cbResource.Enabled = true;
            }
        }
    }
}
