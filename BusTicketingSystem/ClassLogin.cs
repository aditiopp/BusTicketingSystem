using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginForm
{
    public enum City
    {
        Jakarta_ProvinsiDKI = 1,
        Surabaya_JawaTimur = 2,
        Yogyakarta_DIY = 3,
        Bandung_JawaBarat = 4,
        Bogor_JawaBarat = 5
    }
    
    public enum BisClass
    {
        Economic = 1,
        Bussiness = 2 ,
        Executive = 3
    }

    public enum BusTime
    {        
        _10AM = 1,      
        _10PM = 2
    }

    public enum NameBus
    {
        LongJourney = 1,
        NeverGiveup = 2,
        WildWildWest = 3,
        Tayoo = 4
    }
    
    public enum DirectionJak
    {
        // 1 for the longest until 4 for the shortest
        JakSur = 1,
        JakYok = 2,
        JakBan = 3,
        JakBog = 4
    }

    public enum DirectionSur
    {
        // 1 for the longest until 4 for the shortest
        SurJak = 2,
        SurYok = 4 ,
        SurBan = 3,
        SurBog = 1
    }

    public enum DirectionYok
    {
        // 1 for the longest until 4 for the shortest
        YokJak = 3,
        YokSur = 1,
        YokBan = 4,
        YokBog = 2
    }

    public enum DirectionBan
    {
        // 1 for the longest until 4 for the shortest
        BanJak = 2,
        BanSur = 1,
        BanYok = 4,
        BanBog = 3
    }

    public enum DirectionBog
    {
        // 1 for the longest until 4 for the shortest
        BogJak = 4 ,
        BogYok = 2,
        BogSur = 1,
        BogBan = 3
    }

    class ClassLogin
    {
        public struct UserData
        {
            public static string userID;
            public string _userID
            {
                get { return userID; }
                set { userID = value; }
            }
        }
    }

    class MainUI
    {
        // variable
        public string[,,] fullStackRandom = new string[5, 4, 5];
        
        public void ReverseButton(int inIndexPanel, List<Panel> myPanel)
        {
            if (inIndexPanel > 0)
                myPanel[--inIndexPanel].BringToFront();
        }

        public void NextButton(int inIndexPanel, List<Panel> myPanel)
        {
            if (inIndexPanel < myPanel.Count - 1)
                myPanel[++inIndexPanel].BringToFront();
        }

        public int FindCaseCost(int inComBox1, int inComBox2)
        {
            if (inComBox1 == 1)
            {
                if (inComBox2 == 1) return (int)DirectionJak.JakSur; // highest
                else if (inComBox2 == 2) return (int)DirectionJak.JakYok;
                else if (inComBox2 == 3) return (int)DirectionJak.JakBan;
                else if (inComBox2 == 4) return (int)DirectionJak.JakBog; // lowest
                else return 0; // Selected same city
            }
            else if (inComBox1 == 2)
            {
                if (inComBox2 == 2) return (int)DirectionSur.SurJak;
                else if (inComBox2 == 4) return (int)DirectionSur.SurYok;
                else if (inComBox2 == 3) return (int)DirectionSur.SurBan;
                else if (inComBox2 == 1) return (int)DirectionSur.SurBog;
                else return 0; // Selected same city
            }
            else if (inComBox1 == 3)
            {
                if (inComBox2 == 3) return (int)DirectionYok.YokJak;
                else if (inComBox2 == 1) return (int)DirectionYok.YokSur;
                else if (inComBox2 == 4) return (int)DirectionYok.YokBan;
                else if (inComBox2 == 2) return (int)DirectionYok.YokBog;
                else return 0; // Selected same city
            }
            else if (inComBox1 == 4)
            {
                if (inComBox2 == 2) return (int)DirectionBan.BanJak;
                else if (inComBox2 == 1) return (int)DirectionBan.BanSur;
                else if (inComBox2 == 4) return (int)DirectionBan.BanYok;
                else if (inComBox2 == 3) return (int)DirectionBan.BanBog;
                else return 0; // Selected same city
            }
            else if (inComBox1 == 5)
            {
                if (inComBox2 == 4) return (int)DirectionBog.BogJak;
                else if (inComBox2 == 2) return (int)DirectionBog.BogSur;
                else if (inComBox2 == 1) return (int)DirectionBog.BogYok;
                else if (inComBox2 == 3) return (int)DirectionBog.BogBan;
                else return 0; // Selected same city
            }
            else return -1; // City out of index
        }

        public int FindCaseBox(int inComBox1, int inComBox2)
        {
            if (inComBox1 == 1)
            {
                if (inComBox2 == 2) return (int)DirectionJak.JakSur; // highest
                else if (inComBox2 == 3) return (int)DirectionJak.JakYok;
                else if (inComBox2 == 4) return (int)DirectionJak.JakBan;
                else if (inComBox2 == 5) return (int)DirectionJak.JakBog; // lowest
                else return 0; // Selected same city
            }
            else if (inComBox1 == 2)
            {
                if (inComBox2 == 1) return (int)DirectionSur.SurJak;
                else if (inComBox2 == 3) return (int)DirectionSur.SurYok;
                else if (inComBox2 == 4) return (int)DirectionSur.SurBan;
                else if (inComBox2 == 5) return (int)DirectionSur.SurBog;
                else return 0; // Selected same city
            }
            else if (inComBox1 == 3)
            {
                if (inComBox2 == 1) return (int)DirectionYok.YokJak;
                else if (inComBox2 == 2) return (int)DirectionYok.YokSur;
                else if (inComBox2 == 4) return (int)DirectionYok.YokBan;
                else if (inComBox2 == 5) return (int)DirectionYok.YokBog;
                else return 0; // Selected same city
            }
            else if (inComBox1 == 4)
            {
                if (inComBox2 == 1) return (int)DirectionBan.BanJak;
                else if (inComBox2 == 2) return (int)DirectionBan.BanSur;
                else if (inComBox2 == 3) return (int)DirectionBan.BanYok;
                else if (inComBox2 == 5) return (int)DirectionBan.BanBog;
                else return 0; // Selected same city
            }
            else if (inComBox1 == 5)
            {
                if (inComBox2 == 1) return (int)DirectionBog.BogJak;
                else if (inComBox2 == 2) return (int)DirectionBog.BogSur;
                else if (inComBox2 == 3) return (int)DirectionBog.BogYok;
                else if (inComBox2 == 4) return (int)DirectionBog.BogBan;
                else return 0; // Selected same city
            }
            else return -1; // City out of index
        }

        public bool CheckingTextBox(TextBox firstName, TextBox lastName, TextBox phoneNum, TextBox residentID)
        {
            // if everything is filled, return true
            // if there is one text box which is not filled, return false
            if (!String.IsNullOrEmpty(firstName.Text))
            {
                if (!String.IsNullOrEmpty(lastName.Text))
                {
                    if (!String.IsNullOrEmpty(phoneNum.Text))
                    {
                        if (!String.IsNullOrEmpty(residentID.Text))
                        {
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            return false;
        }

        public void DoingRandom()
        {
            Random numRand = new Random();
            int busOptionInOneDay = 5;
            int cityCount = Enum.GetValues(typeof(City)).Length;
            string busName, busClass, busTime, nameClassTimePrice;
            string checkingString2;
            string priceBus = "NT$0";
            for (int i = 0; i < cityCount; i++) // combobox 1
            {
                for (int j = 0; j < cityCount - 1; j++) // combobox 2
                {
                    string[] checkingString = new string[busOptionInOneDay];
                    for (int k = 0; k < busOptionInOneDay; k++)
                    {
                        bool checkStringOK = true;
                        busName = Enum.GetName(typeof(NameBus), numRand.Next(1, 5));
                        busClass = Enum.GetName(typeof(BisClass), numRand.Next(1, 4));
                        busTime = Enum.GetName(typeof(BusTime), numRand.Next(1, 2));

                        //Enum.GetName(typeof(BusTime), numRand.Next(1, 2));
                        switch (FindCaseCost(i + 1, j + 1))
                        {
                            // 1 for the longest until 4 for the shortest
                            case 1:
                                if (busClass == BisClass.Economic.ToString()) priceBus = "NT$500";
                                else if (busClass == BisClass.Bussiness.ToString()) priceBus = "NT$600";
                                else priceBus = "NT$700";
                                break;
                            case 2:
                                if (busClass == BisClass.Economic.ToString()) priceBus = "NT$400";
                                else if (busClass == BisClass.Bussiness.ToString()) priceBus = "NT$450";
                                else priceBus = "NT$500";
                                break;
                            case 3:
                                if (busClass == BisClass.Economic.ToString()) priceBus = "NT$300";
                                else if (busClass == BisClass.Bussiness.ToString()) priceBus = "NT$350";
                                else priceBus = "NT$400";
                                break;
                            case 4:
                                if (busClass == BisClass.Economic.ToString()) priceBus = "NT$200";
                                else if (busClass == BisClass.Bussiness.ToString()) priceBus = "NT$250";
                                else priceBus = "NT$300";
                                break;
                        }
                        nameClassTimePrice = busName + "," + busClass + "," + busTime + "," + priceBus;
                        checkingString[k] = checkingString2 = nameClassTimePrice;
                        for (int check = 0; check < k; check++)
                        {
                            if (checkingString[check] == checkingString2)
                            {
                                k--;
                                checkStringOK = false;
                            }
                            else continue;
                        }
                        if (checkStringOK) fullStackRandom[i, j, k] = nameClassTimePrice;
                        else continue;
                    }
                    // checking if we have same
                }
            }
        }
        
        public struct OrderTrip
        {
            private string _FirstName;
            private string _LastName;
            private string _ResidentID;
            private string _PhoneNumber;
            private string _DateDeparture;
            private string _CityDepart;
            private string _CityArrival;
            private string _BusName;
            private string _BusClass;
            private string _Price;
            private string _Time;
            private string _Seat;
            private bool _CheckFirst, _CheckLast, _CheckID, _CheckPhone, _CheckDepart, _CheckName, _CheckSeat;

            public OrderTrip(string inFirst, string inLast, string inID, string inPhone, string inDepart, string inCityDepart, string inCityArrival,
                string inPrice, string inTime, string inName, string inClass, string inSeat) : this()
            {
                firstName = inFirst;
                lastName = inLast;
                residentID = inID;
                phoneNumber = inPhone;
                dateDepart = inDepart;
                busName = inName;
                busPrice = inPrice;
                busTime = inTime;
                busSeat = inSeat;
                cityDeparture = inCityDepart;
                cityArrival = inCityArrival;
                busClass = inClass;
            }

            public string firstName
            {
                get { return _FirstName; }
                set
                {
                    bool firstNameCheck = true;
                    char[] charFirstName = value.ToCharArray();
                    for (int i = 0; i < charFirstName.Length; i++)
                    {
                        if (charFirstName[i] >= 48 && charFirstName[i] <= 57)
                        {
                            MessageBox.Show("Fill first name box without number", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            firstNameCheck = false;
                            break;
                        }
                    }
                    if (value.Contains(" "))
                    {
                        MessageBox.Show("Fill first name box without space", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        firstNameCheck = false;
                    }
                    if (firstNameCheck) { _FirstName = value; _CheckFirst = true; }
                    else MessageBox.Show("Please fix first name box", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
            }
            public string lastName
            {
                get { return this._LastName; }
                set
                {
                    bool lastNameCheck = true;
                    char[] charLastName = value.ToCharArray();
                    for (int i = 0; i < charLastName.Length; i++)
                    {
                        if (charLastName[i] >= 48 && charLastName[i] <= 57)
                        {
                            MessageBox.Show("Fill last name box without number", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lastNameCheck = false;
                            break;
                        }
                    }
                    if (value.Contains(" "))
                    {
                        MessageBox.Show("Fill last name box without space", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lastNameCheck = false;
                    }
                    if (lastNameCheck) { _LastName = value; _CheckLast = true; }
                    else MessageBox.Show("Please fix last name box", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
            }
            public string residentID
            {
                get { return this._ResidentID; }
                set
                {
                    this._ResidentID = value;
                    _CheckID = true;
                }
            }
            public string phoneNumber
            {
                get { return _PhoneNumber; }
                set
                {
                    bool phoneCheck = true;
                    char[] charPhone = value.ToCharArray();
                    for (int i = 0; i < charPhone.Length; i++)
                    {
                        if (charPhone[0] != 48)
                        {
                            phoneCheck = false;
                            break;
                        }
                        else if (charPhone[i] >= 48 && charPhone[i] <= 57) continue;
                        else
                        {
                            phoneCheck = false;
                            break;
                        }
                    }
                    if (phoneCheck) { this._PhoneNumber = value; _CheckPhone = true; }
                    else MessageBox.Show("Phone number format is wrong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            public string dateDepart
            {
                get { return _DateDeparture; }
                set { _DateDeparture = value; _CheckDepart = true; }
            }
            public string busName
            {
                get { return _BusName; }
                set
                {
                    if (value == "None") MessageBox.Show("Please choose bus provider.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        _BusName = value;
                        _CheckName = true;
                    }

                }
            }
            public string busClass
            {
                get { return _BusClass; }
                set { _BusClass = value; }

            }
            public string busPrice
            {
                get { return _Price; }
                set { _Price = value; }
            }
            public string busTime
            {
                get { return _Time; }
                set { _Time = value; }
            }
            public string busSeat
            {
                get { return _Seat; }
                set
                {
                    if (value == "None") MessageBox.Show("Please choose your seat number", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else { _Seat = value; _CheckSeat = true; }
                }
            }
            public string cityArrival
            {
                get { return _CityArrival; }
                set { _CityArrival = value; }
            }
            public string cityDeparture
            {
                get { return _CityDepart; }
                set { _CityDepart = value; }
            }

            // HW - Constructor struct, bikin tombol check buat ngecek bisnya, bikin tombol submit di akhir form

            public bool CheckingInputData()
            {
                if (_CheckFirst && _CheckLast && _CheckID && _CheckPhone && _CheckDepart && _CheckName && _CheckSeat) return true;
                else return false;
            }

            public void SaveDataToExcel()
            {
                // Initiate variable
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
                for (int i = 1; i <= numberOfRows + 1; i++)
                {
                    // var cellValue = ().ToString();
                    if ((myWS.Cells[i, 1] as Excel.Range).Value != null) { continue; }
                    else
                    {
                        myExcelApp.Cells[i, 1] = firstName;
                        myExcelApp.Cells[i, 2] = lastName;
                        myExcelApp.Cells[i, 3] = residentID;
                        myExcelApp.Cells[i, 4] = phoneNumber;
                        myExcelApp.Cells[i, 5] = dateDepart;
                        myExcelApp.Cells[i, 6] = busTime;
                        myExcelApp.Cells[i, 7] = cityDeparture;
                        myExcelApp.Cells[i, 8] = cityArrival;
                        myExcelApp.Cells[i, 9] = busName;
                        myExcelApp.Cells[i, 10] = busClass;
                        myExcelApp.Cells[i, 11] = busSeat;
                        myExcelApp.Cells[i, 12] = busPrice;
                    }
                }

                // Close connection
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
            }

            public void UpdateExcelBusProvide()
            {
                // Initiate variable
                int classBus;
                string str = System.IO.Directory.GetCurrentDirectory();
                string filePath1 = str + "/{0}.xlsx";
                string fixedFilePath = string.Format(filePath1, busName);
                if (busClass == "Economic") classBus = (int)BisClass.Economic;
                else if (busClass == "Bussiness") classBus = (int)BisClass.Bussiness;
                else classBus = (int)BisClass.Executive;

                // Open Connection
                Excel.Application myExcelApp = new Excel.Application();
                Excel.Workbook myWB = myExcelApp.Workbooks.Open(fixedFilePath);
                Excel.Worksheet myWS = new Excel.Worksheet();
                myWS = myWB.Worksheets[classBus];
                Excel.Range usedRange = myWS.UsedRange;
                
                // Insert Data
                int numberOfRows = usedRange.Rows.Count;
                for (int i = 1; i <= numberOfRows + 1; i++)
                {
                    if ((myWS.Cells[i, 1] as Excel.Range).Value != null) { continue; }
                    else myExcelApp.Cells[i, 1] = busSeat;
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
            }
        }
        }
    }
