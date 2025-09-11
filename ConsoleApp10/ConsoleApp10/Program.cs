using System.ComponentModel;
using OfficeOpenXml;

ExcelPackage.License.SetNonCommercialPersonal("Roman");
string puth = "C:\\Users\\Student\\source\\repos\\roman\\ConsoleApp10\\ConsoleApp10\\newExcelBook.xlsx";
var listsNames = new List<string>() { "Лист1", "Лист2", "Лист3", "Лист4", "Лист5" };
var lists = new List<ExcelWorksheet>();
ExcelPackage.License.SetNonCommercialPersonal("Daniil");
ExcelPackage newBook = new ExcelPackage(puth);
ExcelWorksheet worksheet1 = newBook.Workbook.Worksheets["Лист1"];
foreach (var listName in listsNames)
{
    if (newBook.Workbook.Worksheets[listName] == null)
        lists.Add(newBook.Workbook.Worksheets.Add(listName));
    else
        lists.Add(newBook.Workbook.Worksheets[listName]);
}

if (lists[4] != null)
{
    newBook.Workbook.Worksheets.Delete(lists[4]);
    newBook.Save();
}
for (int i = 0; i < 2; i++)
{
    worksheet1 = lists[i];
    worksheet1.Cells["A1"].Value = "hello word";
}

//worksheet1 = lists[0];
//worksheet1.Cells["A1"].Value = "hello word";
var fileInfo = new FileInfo(puth);
newBook.SaveAs(fileInfo);