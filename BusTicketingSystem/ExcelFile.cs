using System;
using System.Collections.Generic;
using LoginForm;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ExcelSpace
{

    class ExcelFile
    {
        string dirFile = "";
        public List<string> rowsToRead = new List<string>();

        public ExcelFile (String _FilePath)
        {
            this.dirFile = _FilePath;
        }
        
        public void ReadFile(string inBusName, string inClassName)
        {
            int classBus;
            if (inClassName == "Economic") classBus = (int)BisClass.Economic;
            else if (inClassName == "Bussiness") classBus = (int)BisClass.Bussiness;
            else classBus = (int)BisClass.Executive;
            string filePath1 = dirFile + "/{0}.xlsx";
            string fixedFilePath = string.Format(filePath1, inBusName);
            Excel.Application excel = new Excel.Application();
            Excel.Workbook myWB = excel.Workbooks.Open(fixedFilePath);
            Excel.Worksheet myWS = new Excel.Worksheet();
            myWS = myWB.Worksheets[classBus];
            Excel.Range usedRange = myWS.UsedRange;
            int numberOfRows = usedRange.Rows.Count;
            int numberOfColumn = usedRange.Columns.Count;           
            for (int i = 1; i <= numberOfRows; i++)
            {
                if (usedRange.Cells[i,1].Value2 != null)
                {
                    rowsToRead.Add(usedRange.Cells[i, 1].Value2.ToString());
                }
            }
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
            excel.Quit();
            if (excel != null)
            {
                Marshal.FinalReleaseComObject(excel);
                excel = null;
            }

            Process[] processes = Process.GetProcessesByName("EXCEL");
            foreach (Process p in processes) p.Kill();
        }
    }
}
