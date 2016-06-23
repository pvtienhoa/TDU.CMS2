using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using TDU.CMS2.DataModels;

namespace TDU.CMS2.Modules
{
    public class DataFileHandler
    {
        public static List<CardRequest> ReadEssemcardFile(string filePath)
        {
            if (filePath == null) throw new NullReferenceException();
            var fs = File.OpenRead(filePath);
            var wb = WorkbookFactory.Create(fs);
            //DateTime dt = wb.GetSheetAt(0).GetRow(1).GetCell(6).DateCellValue;
            //MessageBox.Show(("Value of Cell B2: " + dt.ToString()));
            var cList = new List<CardRequest>();
            var i = wb.GetSheetAt(0);
            for (var rowindex = 1; rowindex < i.LastRowNum; rowindex++)
            {
                var c = new CardRequest
                {
                    CardNumber = i.GetRow(rowindex).GetCell(0).StringCellValue.Trim(),
                    CardHolder = i.GetRow(rowindex).GetCell(1).StringCellValue.Trim(),
                    RequestDate = i.GetRow(rowindex).GetCell(7).DateCellValue,
                    Cif = i.GetRow(rowindex).GetCell(9).StringCellValue.Trim(),
                    CardLocation = 1,
                    PinLocation = 1,
                    EmployeeName = "Nguyen Thi Hong Dao",
                    State = RequestState.Producing,
                    Type = RequestType.Issue,
                    Code = i.GetRow(rowindex).GetCell(14).StringCellValue.Trim()
                };
                cList.Add(c);
            }
            return cList;
        }
    }
}
