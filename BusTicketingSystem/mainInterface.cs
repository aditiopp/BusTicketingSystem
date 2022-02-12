using System;
using System.Drawing;
using System.Windows.Forms;
using LoginForm;
using BusSeatSpace;
using ExcelSpace;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace badmintonProject
{
    public partial class mainInterface : Form
    {

        public mainInterface()
        {
            InitializeComponent();

        }
        
        private void mainInterface_Load(object sender, EventArgs e)
        {
            // Show the light indicator menu
            panelLight1.Visible = true;
            panelLight2.Visible = panelLight3.Visible = false;

            // Change the label name
            ClassLogin.UserData myObject = new ClassLogin.UserData();
            labelUserID.Text = myObject._userID;
            groupBoxReserv.Visible = true;
            groupBoxHelp.Visible = groupBoxRefund.Visible = false;

            // Radio button
            radioRoundNo.Checked = true;

            // Load panel list
            myListPanel.Add(panelIDForm);
            myListPanel.Add(panelDate);
            myListPanel.Add(panelListBus);
            myListPanel.Add(panelSeat);
            myListPanel[indexPanel].BringToFront();

            // Adding City to control box
            comboBox1.DataSource = Enum.GetValues(typeof(City));
            comboBox2.DataSource = Enum.GetValues(typeof(City));

            // Assign random value
            objectUI.DoingRandom();

            // Create Graphics
            g = this.panelDrawSeat.CreateGraphics();

            // Restrict datetimepicker of previous date
            dateTimePicker1.MinDate = DateTime.Now.Date;
        }

        private void buttonReserv_Click(object sender, EventArgs e)
        {
            // Show the light indicator menu
            panelLight1.Visible = true;
            panelLight2.Visible = panelLight3.Visible = false;
            groupBoxReserv.Visible = true;
            groupBoxHelp.Visible = groupBoxRefund.Visible = false;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // show the light indicator menu
            panelLight2.Visible = true;
            panelLight1.Visible = panelLight3.Visible = false;
            groupBoxRefund.Visible = true;
            groupBoxHelp.Visible = groupBoxReserv.Visible = false;

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Show the light indicator menu
            panelLight3.Visible = true;
            panelLight1.Visible = panelLight2.Visible = false;
            groupBoxHelp.Visible = true;
            groupBoxRefund.Visible = groupBoxReserv.Visible = false;

        }
        
        private void picBoxNext_Click(object sender, EventArgs e)
        {
            objectUI.NextButton(indexPanel, myListPanel);
            if (indexPanel == myListPanel.Count) indexPanel = myListPanel.Count;
            else if (indexPanel < myListPanel.Count) indexPanel++;
        }
        
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            labelDateBusList.Text = dateTimePicker1.Text;
        }

        private void radioRoundNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRoundYes.Checked == false)
                dateReturn.Enabled = labelReturnDate.Enabled = false;
            else
                dateReturn.Enabled = labelReturnDate.Enabled = true;
        }

        private void picPrev_Click(object sender, EventArgs e)
        {
            objectUI.ReverseButton(indexPanel, myListPanel);
            if (indexPanel == 0) indexPanel = 0;
            else if (indexPanel > 0) indexPanel--;
        }

        private void buttonSubmitBook_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != comboBox2.SelectedIndex)
            {
                if (objectUI.CheckingTextBox(textFirstName, textLastName, textPhoneNumber, textResidentID))
                {
                    if (radioRoundNo.Checked)
                    {
                        ListViewItem myItems = listViewBus.SelectedItems[0];
                        string _time = myItems.SubItems[3].Text;
                        string _price = myItems.SubItems[4].Text;
                        MainUI.OrderTrip myStruct = new MainUI.OrderTrip(textFirstName.Text, textLastName.Text, textResidentID.Text,
                            textPhoneNumber.Text, dateTimePicker1.Text, labelDeparture.Text, labelArrival.Text, _price,  _time, labelBusSelected.Text, labelClassSelected.Text, labelSeatSelectedShow.Text);
                        if (myStruct.CheckingInputData())
                        {
                            // Save data to excel
                            myStruct.SaveDataToExcel();
                            myStruct.UpdateExcelBusProvide();
                            MessageBox.Show("Your data has been successfully saved. Thank you.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // Reset everything once it saved
                            textFirstName.Text = textLastName.Text = textResidentID.Text = textPhoneNumber.Text = dateTimePicker1.Text = null;
                            labelBusSelected.Text = labelDeparture.Text = labelArrival.Text = labelClassSelected.Text = labelDateBusList.Text = labelSeatSelectedShow.Text = "None";
                            checkSeat = false;
                        }
                        else MessageBox.Show("Data error is not submitted. Please kindly check your input data again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    // Constructor without date return
                }
                else MessageBox.Show("Please fill all of the text box", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Please choose different destination", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDeparture.Text = Enum.GetName(typeof(City), comboBox1.SelectedIndex + 1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelArrival.Text = Enum.GetName(typeof(City), comboBox2.SelectedIndex + 1);
        }

        private void buttonCheckBus_Click(object sender, EventArgs e)
        {
            listViewBus.Items.Clear();
            if (comboBox1.SelectedIndex != comboBox2.SelectedIndex && labelDateBusList.Text == dateTimePicker1.Text)
            {
                for (int i = 0; i < 5; i++) // i = 1 = jakarta; 2 = surabaya
                {
                    for (int j = 0; j < 4; j++) // j = 
                    {
                        for (int loop = 0; loop < 5; loop++)
                        {
                            int jStack = objectUI.FindCaseCost(comboBox1.SelectedIndex + 1, objectUI.FindCaseBox(comboBox1.SelectedIndex + 1, comboBox2.SelectedIndex + 1));
                            if (comboBox1.SelectedIndex == i && jStack == j + 1)
                            {
                                String[] Piecewise;
                                string numSeq = (loop+1).ToString();
                                Piecewise = objectUI.fullStackRandom[i, j, loop].Split(',');
                                listViewBus.Items.Add(numSeq, i).SubItems.AddRange(Piecewise);
                            }
                            else break;
                        }
                    }
                }
            }
            else if (labelDateBusList.Text != dateTimePicker1.Text)
            {
                MessageBox.Show("Please choose date departure", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Please choose different city destination", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listViewBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Taking name of the bus into label of checking seat
            if (listViewBus.SelectedItems.Count == 0) return;
            ListViewItem myItems = listViewBus.SelectedItems[0];
            labelBusSelected.Text = myItems.SubItems[1].Text;
            labelClassSelected.Text = myItems.SubItems[2].Text;
        }

        private void buttonCheckSeat_Click(object sender, EventArgs e)
        {
            if (labelBusSelected.Text == "None")
                MessageBox.Show("Please choose bus first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                BusSeat mySeat = new BusSeat(g);
                string str = Directory.GetCurrentDirectory();
                ExcelFile myexcel = new ExcelFile(str);
                myexcel.ReadFile(labelBusSelected.Text, labelClassSelected.Text);
                mySeat.DrawBusData(myexcel.rowsToRead);
                checkSeat = true;
            }
        }
        
        private void panelDrawSeat_Paint(object sender, PaintEventArgs e)
        {
            if (labelBusSelected.Text != "None")
            {
                g.Clear(this.BackColor);
                BusSeat myBusSeat = new BusSeat(0, 0, g);
                myBusSeat.DrawBusSeat();
            }
        }

        private void panelDrawSeat_Click(object sender, EventArgs e)
        {
            if (labelBusSelected.Text != "None" && checkSeat)
            {
                panelDrawSeat_Paint(null, null);
                Point myPoint = panelDrawSeat.PointToClient(Cursor.Position);
                BusSeat myBus = new BusSeat(myPoint, g);
                string str = Directory.GetCurrentDirectory();
                ExcelFile myexcel = new ExcelFile(str);
                myexcel.ReadFile(labelBusSelected.Text, labelClassSelected.Text);
                myBus.DrawBusData(myexcel.rowsToRead);
                // Take pointer location
                myBus.SeatLocation(myPoint);
                // Check 
                myBus.AssignSeat(myexcel.rowsToRead);
                myBus.DrawSeatSelected();
                // Set Label
                labelSeatSelectedShow.Text = myBus.GetTextSeat();
            }
            else MessageBox.Show("Please click check seat first.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listviewRefresh.Enabled = true;
            listviewRefresh.Items.Clear();
            string str = System.IO.Directory.GetCurrentDirectory();
            string FilePath = str + "/DataBase.xlsx";

            // Open connection
            Excel.Application myExcelApp = new Excel.Application();
            Excel.Workbook myWB = myExcelApp.Workbooks.Open(FilePath);
            Excel.Worksheet myWS = new Excel.Worksheet();
            myWS = myWB.Worksheets[1];
            Excel.Range usedRange = myWS.UsedRange;

            // Insert Data
            int numberOfRows = usedRange.Rows.Count;
            rowItemOnExcel = numberOfRows;
            int numberOfColumn = usedRange.Columns.Count;
            
            for (int i = 1; i <= numberOfRows; i ++)
            {
                itemsToShow.Clear();
                for (int j = 1; j <= numberOfColumn; j++)
                {
                    if ((myWS.Cells[i, 1] as Excel.Range).Value == null) { continue; }
                    else
                    {
                        var cellValue = ((myWS.Cells[i, j] as Excel.Range).Value).ToString();
                        itemsToShow.Add(cellValue);
                    }
                }
                String[] piecewise = itemsToShow.ToArray();
                listviewRefresh.Items.Add(i.ToString()).SubItems.AddRange(piecewise);
            }
            // Close Connection
            myWB.Save();
            if (myWS != null)
            {
                Marshal.FinalReleaseComObject(myWS);
                myWS = null;
            }
            myWB.Close(0);
            if (myWB != null)
            {
                Marshal.FinalReleaseComObject(myWB);
                myWB = null;
            }
            myExcelApp.Quit();
            if (myExcelApp != null)
            {
                Marshal.FinalReleaseComObject(myExcelApp);
                myExcelApp = null;
            }

            Process[] processes = Process.GetProcessesByName("EXCEL");
            foreach (Process p in processes) p.Kill();

            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string str = System.IO.Directory.GetCurrentDirectory();
            string FilePath = str + "/DataBase.xlsx";
            int indexRowDelete = 0;

            // Open connection
            Excel.Application myExcelApp = new Excel.Application();
            Excel.Workbook myWB = myExcelApp.Workbooks.Open(FilePath);
            Excel.Worksheet myWS = new Excel.Worksheet();
            myWS = myWB.Worksheets[1];
            Excel.Range usedRange = myWS.UsedRange;

            // Insert Data
            int numberOfRows = usedRange.Rows.Count;
            int numberOfColumns = usedRange.Columns.Count;

            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= numberOfColumns; j++)
                {
                    var cellValue = ((myWS.Cells[i, j] as Excel.Range).Value).ToString();
                    if (selectedListDelete == cellValue)
                    {
                        indexRowDelete = i;
                        break;
                    }
                }
            }

            for (int i = 1; i <= numberOfRows; i++)
            {
                if (indexRowDelete == i)
                {
                    for (int j = numberOfColumns; j >= 1; j--)
                    {
                        Excel.Range cell = myWS.Cells[i, j];
                        cell.Delete();
                    }
                }
                else continue;
            }

            // Close Connection
            myWB.Save();
            if (myWS != null)
            {
                Marshal.FinalReleaseComObject(myWS);
                myWS = null;
            }
            myWB.Close(0);
            if (myWB != null)
            {
                Marshal.FinalReleaseComObject(myWB);
                myWB = null;
            }
            myExcelApp.Quit();
            if (myExcelApp != null)
            {
                Marshal.FinalReleaseComObject(myExcelApp);
                myExcelApp = null;
            }

            Process[] processes = Process.GetProcessesByName("EXCEL");
            foreach (Process p in processes) p.Kill();
            listviewRefresh.Items.Clear();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin fl = new fLogin();
            fl.Show();
        }

        private void listviewRefresh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewRefresh.SelectedItems.Count == 0) return;
            ListViewItem myItems = listviewRefresh.SelectedItems[0];
            selectedListDelete = myItems.SubItems[3].Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/aditiopp/");
        }
    }
}
