using System;
using System.ComponentModel;
using OfficeOpenXml;
using static OfficeOpenXml.ExcelErrorValue;

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
ExcelWorksheet currentWorksheet = newBook.Workbook.Worksheets["Functions"];


// Заполнение ячеек первых слагаемых
currentWorksheet .Cells [ "A1" ] .Value = 10;
currentWorksheet.Cells["A2"].Value = 20;
currentWorksheet.Cells["A3"].Value = 30;
// Заполнение ячеек вторых слагаемых
currentWorksheet.Cells["B1"].Value = 2;
currentWorksheet.Cells["B2"].Value = 5;
currentWorksheet.Cells["B3"].Value = 10;
// Используем функцию SUM() для суммирования значений
currentWorksheet.Cells["C1"].Formula = "SUM(A1:B1)";
currentWorksheet.Cells["C2"].Formula = "SUM(A2:B2)";
currentWorksheet.Cells["C3"].Formula = "SUM(A3:B3)";
currentWorksheet.Cells["A6"].Formula = "Average(A1:A3)";
currentWorksheet.Cells["C4"].Formula = "IF(A1>10, \"Больше 10\",\"Меньше или равно 10\")";
// Заполняем ячейки от А1 по E7 случайными значениями
Random random = new Random();
for (int i = 1; i <= 5; i++)
{
    currentWorksheet.Cells[random.Next(1, 7), random.Next(1, 6)].Value
    = 1;
}
// Используем функцию COUNT() для подсчета ячеек
currentWorksheet.Cells["F1"].Formula = "COUNT(C1:E7)";
newBook.Save();


//worksheet1 = lists[0];
//worksheet1.Cells["A1"].Value = "hello word";
var fileInfo = new FileInfo(puth);
newBook.SaveAs(fileInfo);