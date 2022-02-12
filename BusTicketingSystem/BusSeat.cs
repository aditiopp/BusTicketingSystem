using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ExcelSpace;

namespace BusSeatSpace
{
    public enum BusSeatNumber
    {
        none, A1, B1, C1, D1,
        A2, B2, C2, D2,
        A3, B3, C3, D3,
        A4, B4, C4, D4,
        A5, B5, C5, D5,
        A6, B6, C6, D6,
        A7, B7, C7, D7,
        A8, B8, C8, D8,
        A9, B9, C9, D9,
        A10, B10, C10, D10,
        A11, B11, C11, D11,
        A12, B12, C12, D12,
        A13, B13, C13, D13,
    }

    class BusSeat
    {
        public const int rowNum = 4;
        public const int columnNum = 13;
        public const int gapBetweenSeat = 10;
        public const int gapBetweenTwoRow = 9;
        public const int seatSizeX = 25;
        public const int seatSizeY = 18;
        public const int lineWidth = 1;
        public const int marginLower = 2;
        public const int marginUpper = 3;
        public Point StartPt;
        public Point Endpt;
        public Graphics g;
        public Point CursorLocation;
        public int rowSelected, columnSelected;
        public int colData, rowData;
        public bool allowDrawSelected = true;
        

        public BusSeat(int startPtPanelX, int startPtPanelY, Graphics gin)
        {
            this.StartPt.X = startPtPanelX;
            this.StartPt.Y = startPtPanelY;
            this.Endpt.X = startPtPanelX + seatSizeX;
            this.Endpt.Y = startPtPanelY + seatSizeY;
            this.g = gin;
        }

        public BusSeat(Point inCursor, Graphics gIn)
        {
            this.CursorLocation = inCursor;
            this.g = gIn;
        }

        public BusSeat(Graphics gIn)
        {
            this.g = gIn;
        }

        /// <summary>
        /// Draw grid bus seat
        /// </summary>
        public void DrawBusSeat()
        {
            Pen myPen = new Pen(Color.RoyalBlue, lineWidth);
            for (int i = 0; i < columnNum; i++)
            {
                for (int j = 0; j < rowNum / 2; j++)
                {
                    g.DrawRectangle(myPen, StartPt.X, StartPt.Y, Endpt.X - StartPt.X, Endpt.Y - StartPt.Y);
                    StartPt.Y = StartPt.Y + seatSizeY + gapBetweenSeat;
                    Endpt.Y = Endpt.Y + gapBetweenSeat + seatSizeY;
                }
                StartPt.Y = StartPt.Y + gapBetweenTwoRow;
                Endpt.Y = Endpt.Y + gapBetweenTwoRow;
                for (int j = 0; j < rowNum / 2; j++)
                {
                    g.DrawRectangle(myPen, StartPt.X, StartPt.Y, Endpt.X - StartPt.X, Endpt.Y - StartPt.Y);
                    StartPt.Y = StartPt.Y + seatSizeY + gapBetweenSeat;
                    Endpt.Y = Endpt.Y + gapBetweenSeat + seatSizeY;
                }
                StartPt.X = StartPt.X + seatSizeX + gapBetweenSeat;
                Endpt.X = Endpt.X + seatSizeX + gapBetweenSeat;
                StartPt.Y = 0;
                Endpt.Y = seatSizeY;
            }
        }


        /// <summary>
        /// To get pointer location from click event
        /// </summary>
        /// <param name="inLocSeat"></param>
        public void SeatLocation(Point inLocSeat)
        {
            // Searching column location
            for (int i = 0; i < columnNum; i++)
            {
                int lowerBoundColumn = i * (seatSizeX + gapBetweenSeat);
                int upperBoundColumn = lowerBoundColumn + seatSizeX;
                if (inLocSeat.X <= upperBoundColumn && inLocSeat.X >= lowerBoundColumn)
                {
                    columnSelected = i;
                    break;
                }
            }
            // Searching row location
            for (int j = 0; j < rowNum; j++)
            {
                if (j <= 1)
                {
                    int lowerBoundRow = j * (seatSizeY + gapBetweenSeat);
                    int upperBoundRow = lowerBoundRow + seatSizeY;
                    if (inLocSeat.Y >= lowerBoundRow && inLocSeat.Y <= upperBoundRow)
                    {
                        rowSelected = j;
                        break;
                    }
                }
                else
                {
                    int lowerBoundRow = (j * (seatSizeY + gapBetweenSeat)) + gapBetweenTwoRow;
                    int upperBoundRow = lowerBoundRow + seatSizeY;
                    if (inLocSeat.Y >= lowerBoundRow && inLocSeat.Y <= upperBoundRow)
                    {
                        rowSelected = j;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// To draw the seat from pointer location (click event)
        /// </summary>
        public void DrawSeatSelected()
        {
            if (allowDrawSelected)
            {
                for (int i = 0; i < columnNum; i++)
                {
                    for (int j = 0; j < rowNum; j++)
                    {
                        if (j <= 1)
                        {
                            if (j == rowSelected && i == columnSelected)
                            {
                                SolidBrush myBrush = new SolidBrush(Color.Green);
                                Point StartPoint = new Point(i * (seatSizeX + gapBetweenSeat), j * (seatSizeY + gapBetweenSeat));
                                Point EndPoint = new Point(i * (seatSizeX + gapBetweenSeat) + seatSizeX, j * (seatSizeY + gapBetweenSeat) + seatSizeY);
                                g.FillRectangle(myBrush, StartPoint.X + marginLower, StartPoint.Y + marginLower, EndPoint.X - StartPoint.X - marginUpper, EndPoint.Y - StartPoint.Y - marginUpper);
                            }
                        }
                        else
                        {
                            if (j == rowSelected && i == columnSelected)
                            {
                                SolidBrush myBrush = new SolidBrush(Color.Green);
                                Point StartPoint = new Point(i * (seatSizeX + gapBetweenSeat), (j * (seatSizeY + gapBetweenSeat)) + gapBetweenTwoRow);
                                Point EndPoint = new Point(i * (seatSizeX + gapBetweenSeat) + seatSizeX, (j * (seatSizeY + gapBetweenSeat)) + gapBetweenTwoRow + seatSizeY);
                                g.FillRectangle(myBrush, StartPoint.X + marginLower, StartPoint.Y + marginLower, EndPoint.X - StartPoint.X - marginUpper, EndPoint.Y - StartPoint.Y - marginUpper);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Draw the seat from database
        /// </summary>
        /// <param name="inRow"><NumberRowInDatabase>
        /// <param name="inCol"><NumberColumnInDataBase>
        public void DrawSeatData(int inRow, int inCol)
        {
            for (int i = 0; i < columnNum; i++)
            {
                for (int j = 0; j < rowNum; j++)
                {
                    if (j <= 1)
                    {
                        if (j == inRow && i == inCol)
                        {
                            SolidBrush myBrush = new SolidBrush(Color.Red);
                            Point StartPoint = new Point(i * (seatSizeX + gapBetweenSeat), j * (seatSizeY + gapBetweenSeat));
                            Point EndPoint = new Point(i * (seatSizeX + gapBetweenSeat) + seatSizeX, j * (seatSizeY + gapBetweenSeat) + seatSizeY);
                            g.FillRectangle(myBrush, StartPoint.X + marginLower, StartPoint.Y + marginLower, EndPoint.X - StartPoint.X - marginUpper, EndPoint.Y - StartPoint.Y - marginUpper);
                        }
                    }
                    else
                    {
                        if (j == inRow && i == inCol)
                        {
                            SolidBrush myBrush = new SolidBrush(Color.Red);
                            Point StartPoint = new Point(i * (seatSizeX + gapBetweenSeat), (j * (seatSizeY + gapBetweenSeat)) + gapBetweenTwoRow);
                            Point EndPoint = new Point(i * (seatSizeX + gapBetweenSeat) + seatSizeX, (j * (seatSizeY + gapBetweenSeat)) + gapBetweenTwoRow + seatSizeY);
                            g.FillRectangle(myBrush, StartPoint.X + marginLower, StartPoint.Y + marginLower, EndPoint.X - StartPoint.X - marginUpper, EndPoint.Y - StartPoint.Y - marginUpper);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// To retrieve data to draw the seat according to the database
        /// </summary>
        /// <param name="inList"></param>
        public void DrawBusData(List<string> inList)
        {
            BusSeatNumber seatsection = BusSeatNumber.none;
            for (int i = 0; i < inList.Count; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(BusSeatNumber)).Length; j++)
                {
                    if (inList[i].ToString() == Enum.GetName(typeof(BusSeatNumber), j))
                    {
                        seatsection = (BusSeatNumber)Enum.Parse(typeof(BusSeatNumber), Enum.GetName(typeof(BusSeatNumber), j));

                        if (seatsection == BusSeatNumber.A1) DrawSeatData(0, 0);
                        else if (seatsection == BusSeatNumber.B1) DrawSeatData(1, 0);
                        else if (seatsection == BusSeatNumber.C1) DrawSeatData(2, 0);
                        else if (seatsection == BusSeatNumber.D1) DrawSeatData(3, 0);

                        else if (seatsection == BusSeatNumber.A2) DrawSeatData(0, 1);
                        else if (seatsection == BusSeatNumber.B2) DrawSeatData(1, 1);
                        else if (seatsection == BusSeatNumber.C2) DrawSeatData(2, 1);
                        else if (seatsection == BusSeatNumber.D2) DrawSeatData(3, 1);

                        else if (seatsection == BusSeatNumber.A3) DrawSeatData(0, 2);
                        else if (seatsection == BusSeatNumber.B3) DrawSeatData(1, 2);
                        else if (seatsection == BusSeatNumber.C3) DrawSeatData(2, 2);
                        else if (seatsection == BusSeatNumber.D3) DrawSeatData(3, 2);

                        else if (seatsection == BusSeatNumber.A4) DrawSeatData(0, 3);
                        else if (seatsection == BusSeatNumber.B4) DrawSeatData(1, 3);
                        else if (seatsection == BusSeatNumber.C4) DrawSeatData(2, 3);
                        else if (seatsection == BusSeatNumber.D4) DrawSeatData(3, 3);

                        else if (seatsection == BusSeatNumber.A5) DrawSeatData(0, 4);
                        else if (seatsection == BusSeatNumber.B5) DrawSeatData(1, 4);
                        else if (seatsection == BusSeatNumber.C5) DrawSeatData(2, 4);
                        else if (seatsection == BusSeatNumber.D5) DrawSeatData(3, 4);

                        else if (seatsection == BusSeatNumber.A6) DrawSeatData(0, 5);
                        else if (seatsection == BusSeatNumber.B6) DrawSeatData(1, 5);
                        else if (seatsection == BusSeatNumber.C6) DrawSeatData(2, 5);
                        else if (seatsection == BusSeatNumber.D6) DrawSeatData(3, 5);

                        else if (seatsection == BusSeatNumber.A7) DrawSeatData(0, 6);
                        else if (seatsection == BusSeatNumber.B7) DrawSeatData(1, 6);
                        else if (seatsection == BusSeatNumber.C7) DrawSeatData(2, 6);
                        else if (seatsection == BusSeatNumber.D7) DrawSeatData(3, 6);

                        else if (seatsection == BusSeatNumber.A8) DrawSeatData(0, 7);
                        else if (seatsection == BusSeatNumber.B8) DrawSeatData(1, 7);
                        else if (seatsection == BusSeatNumber.C8) DrawSeatData(2, 7);
                        else if (seatsection == BusSeatNumber.D8) DrawSeatData(3, 7);

                        else if (seatsection == BusSeatNumber.A9) DrawSeatData(0, 8);
                        else if (seatsection == BusSeatNumber.B9) DrawSeatData(1, 8);
                        else if (seatsection == BusSeatNumber.C9) DrawSeatData(2, 8);
                        else if (seatsection == BusSeatNumber.D9) DrawSeatData(3, 8);

                        else if (seatsection == BusSeatNumber.A10) DrawSeatData(0, 9);
                        else if (seatsection == BusSeatNumber.B10) DrawSeatData(1, 9);
                        else if (seatsection == BusSeatNumber.C10) DrawSeatData(2, 9);
                        else if (seatsection == BusSeatNumber.D10) DrawSeatData(3, 9);

                        else if (seatsection == BusSeatNumber.A11) DrawSeatData(0, 10);
                        else if (seatsection == BusSeatNumber.B11) DrawSeatData(1, 10);
                        else if (seatsection == BusSeatNumber.C11) DrawSeatData(2, 10);
                        else if (seatsection == BusSeatNumber.D11) DrawSeatData(3, 10);

                        else if (seatsection == BusSeatNumber.A12) DrawSeatData(0, 11);
                        else if (seatsection == BusSeatNumber.B12) DrawSeatData(1, 11);
                        else if (seatsection == BusSeatNumber.C12) DrawSeatData(2, 11);
                        else if (seatsection == BusSeatNumber.D12) DrawSeatData(3, 11);

                        else if (seatsection == BusSeatNumber.A13) DrawSeatData(0, 12);
                        else if (seatsection == BusSeatNumber.B13) DrawSeatData(1, 12);
                        else if (seatsection == BusSeatNumber.C13) DrawSeatData(2, 12);
                        else if (seatsection == BusSeatNumber.D13) DrawSeatData(3, 12);
                    }
                }
            }

        }

        public void AssignSeat(List<string> inList)
        {
            BusSeatNumber seatsection = BusSeatNumber.none;
            for (int i = 0; i < inList.Count; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(BusSeatNumber)).Length; j++)
                {
                    if (inList[i].ToString() == Enum.GetName(typeof(BusSeatNumber), j))
                    {
                        seatsection = (BusSeatNumber)Enum.Parse(typeof(BusSeatNumber), Enum.GetName(typeof(BusSeatNumber), j));

                        if (seatsection == BusSeatNumber.A1) { rowData = 0; colData = 0; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B1) { rowData = 1; colData = 0; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C1) { rowData = 2; colData = 0; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D1) { rowData = 3; colData = 0; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A2) { rowData = 0; colData = 1; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B2) { rowData = 1; colData = 1; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C2) { rowData = 2; colData = 1; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D2) { rowData = 3; colData = 1; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A3) { rowData = 0; colData = 2; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B3) { rowData = 1; colData = 2; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C3) { rowData = 2; colData = 2; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D3) { rowData = 3; colData = 2; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A4) { rowData = 0; colData = 3; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B4) { rowData = 1; colData = 3; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C4) { rowData = 2; colData = 3; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D4) { rowData = 3; colData = 3; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A5) { rowData = 0; colData = 4; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B5) { rowData = 1; colData = 4; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C5) { rowData = 2; colData = 4; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D5) { rowData = 3; colData = 4; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A6) { rowData = 0; colData = 5; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B6) { rowData = 1; colData = 5; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C6) { rowData = 2; colData = 5; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D6) { rowData = 3; colData = 5; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A7) { rowData = 0; colData = 6; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B7) { rowData = 1; colData = 6; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C7) { rowData = 2; colData = 6; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D7) { rowData = 3; colData = 6; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A8) { rowData = 0; colData = 7; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B8) { rowData = 1; colData = 7; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C8) { rowData = 2; colData = 7; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D8) { rowData = 3; colData = 7; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A9) { rowData = 0; colData = 8; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B9) { rowData = 1; colData = 8; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C9) { rowData = 2; colData = 8; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D9) { rowData = 3; colData = 8; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A10) { rowData = 0; colData = 9; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B10) { rowData = 1; colData = 9; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C10) { rowData = 2; colData = 9; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D10) { rowData = 3; colData = 9; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A11) { rowData = 0; colData = 10; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B11) { rowData = 1; colData = 10; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C11) { rowData = 2; colData = 10; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D11) { rowData = 3; colData = 10; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A12) { rowData = 0; colData = 11; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B12) { rowData = 1; colData = 11; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C12) { rowData = 2; colData = 11; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D12) { rowData = 3; colData = 11; CheckSeat(); }

                        else if (seatsection == BusSeatNumber.A13) { rowData = 0; colData = 12; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.B13) { rowData = 1; colData = 12; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.C13) { rowData = 2; colData = 12; CheckSeat(); }
                        else if (seatsection == BusSeatNumber.D13) { rowData = 3; colData = 12; CheckSeat(); }
                    }
                }
            }
        }

        public void CheckSeat()
        {
            if (rowData == rowSelected && colData == columnSelected) { allowDrawSelected = false; }
            else return;
        }
        public string GetTextSeat()
        {
            string seatString = "None";
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < columnNum; j++)
                {
                    if (i == rowSelected && j == columnSelected)
                    {
                        if (i == 0 && j == 0) { seatString = "A1"; }
                        else if (i == 1 && j == 0) { seatString = "B1"; }
                        else if (i == 2 && j == 0) { seatString = "C1"; }
                        else if (i == 3 && j == 0) { seatString = "D1"; }

                        else if (i == 0 && j == 1) { seatString = "A2"; }
                        else if (i == 1 && j == 1) { seatString = "B2"; }
                        else if (i == 2 && j == 1) { seatString = "C2"; }
                        else if (i == 3 && j == 1) { seatString = "D2"; }

                        else if (i == 0 && j == 2) { seatString = "A3"; }
                        else if (i == 1 && j == 2) { seatString = "B3"; }
                        else if (i == 2 && j == 2) { seatString = "C3"; }
                        else if (i == 3 && j == 2) { seatString = "D3"; }

                        else if (i == 0 && j == 3) { seatString = "A4"; }
                        else if (i == 1 && j == 3) { seatString = "B4"; }
                        else if (i == 2 && j == 3) { seatString = "C4"; }
                        else if (i == 3 && j == 3) { seatString = "D4"; }

                        else if (i == 0 && j == 4) { seatString = "A5"; }
                        else if (i == 1 && j == 4) { seatString = "B5"; }
                        else if (i == 2 && j == 4) { seatString = "C5"; }
                        else if (i == 3 && j == 4) { seatString = "D5"; }

                        else if (i == 0 && j == 5) { seatString = "A6"; }
                        else if (i == 1 && j == 5) { seatString = "B6"; }
                        else if (i == 2 && j == 5) { seatString = "C6"; }
                        else if (i == 3 && j == 5) { seatString = "D6"; }

                        else if (i == 0 && j == 6) { seatString = "A7"; }
                        else if (i == 1 && j == 6) { seatString = "B7"; }
                        else if (i == 2 && j == 6) { seatString = "C7"; }
                        else if (i == 3 && j == 6) { seatString = "D7"; }

                        else if (i == 0 && j == 7) { seatString = "A8"; }
                        else if (i == 1 && j == 7) { seatString = "B8"; }
                        else if (i == 2 && j == 7) { seatString = "C8"; }
                        else if (i == 3 && j == 7) { seatString = "D8"; }

                        else if (i == 0 && j == 8) { seatString = "A9"; }
                        else if (i == 1 && j == 8) { seatString = "B9"; }
                        else if (i == 2 && j == 8) { seatString = "C9"; }
                        else if (i == 3 && j == 8) { seatString = "D9"; }
                        
                        else if (i == 0 && j == 9) { seatString = "A10"; }
                        else if (i == 1 && j == 9) { seatString = "B10"; }
                        else if (i == 2 && j == 9) { seatString = "C10"; }
                        else if (i == 3 && j == 9) { seatString = "D10"; }

                        else if (i == 0 && j == 10) { seatString = "A11"; }
                        else if (i == 1 && j == 10) { seatString = "B11"; }
                        else if (i == 2 && j == 10) { seatString = "C11"; }
                        else if (i == 3 && j == 10) { seatString = "D11"; }

                        else if (i == 0 && j == 11) { seatString = "A12"; }
                        else if (i == 1 && j == 11) { seatString = "B12"; }
                        else if (i == 2 && j == 11) { seatString = "C12"; }
                        else if (i == 3 && j == 11) { seatString = "D12"; }

                        else if (i == 0 && j == 12) { seatString = "A13"; }
                        else if (i == 1 && j == 12) { seatString = "B13"; }
                        else if (i == 2 && j == 12) { seatString = "C13"; }
                        else if (i == 3 && j == 12) { seatString = "D13"; }
                    }
                }
            }
            return seatString;
        } 
    }
}
