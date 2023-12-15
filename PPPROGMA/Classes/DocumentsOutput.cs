using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using word = Microsoft.Office.Interop.Word;
using System.Data;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using PPPROGMA.Classes.Models;
using PPPROGMA;
using PPPROGMA.Classes.CRUD.Service;

namespace WindowsFormsApp1
{
    static internal class DocumentsOutput
    {


        static public void DogovorPrintToDpf(int TourId)
        {

            try
            {
                if (false)
                {
                    MessageBox.Show("Ошибка состовления документа , договор не найден\n ");
                    return;
                }    

                DateTime curDate = DateTime.Now;

                var app = new word.Application();
                app.Visible = false;

                string path = Directory.GetCurrentDirectory();
                var doc = app.Documents.Open(path + @"\TourDay.docx");

                List<Tour_days> days = new List<Tour_days>();
                List<Tour_days> daysWithTour = new List<Tour_days>();

                Tour tour = ServiceTour.UpdateTour(TourId);

                List<Services_list> services_list;
                List<General_service_list> general_service_list;
                List<Combinetion_of_tours_list> combinetion_of_tours_list;
                List<Transport_list> transport_list;
                List<Food_list> food_list;

                using (ServiceList DBWORk = new ServiceList())
                {
                    days = DBWORk.UpdateDaysListWithTour(TourId);
                    daysWithTour = DBWORk.UpdateAccomodationForOutput(TourId);
                }


                doc.Activate();
                //Target table, to be extended

                doc.Bookmarks["TourName"].Range.Text = tour.Tour_Name;
                doc.Bookmarks["TourDate"].Range.Text = tour.Tour_start_date.ToString();
                doc.Bookmarks["FormerFIO"].Range.Text = Program.User.User_FIO;

                int i = 1;
                foreach (var day in days)
                {
                    services_list = ServiceList.UpdateServices_list(day.idTour_days);
                    
                    foreach (var item in services_list)
                    {
                        doc.Tables[1].Rows.Add(doc.Tables[1].Rows[i]);
                       
                        word.Cell cell2 = doc.Tables[1].Cell(i + 1, 2);
                        word.Cell cell = doc.Tables[1].Cell(i, 1);
                        cell.Range.Text = day.dayName;
                        cell.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        cell2.Range.Text = item.ServiceName;
                        cell2.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        i++;
                    }
                    
                }

                i = 1;
                foreach (var day in days)
                {
                    general_service_list = ServiceList.UpdateGeneral_service_List(day.idTour_days);

                    foreach (var item in general_service_list)
                    {
                        doc.Tables[2].Rows.Add(doc.Tables[2].Rows[i]);
                        word.Cell cell = doc.Tables[2].Cell(i, 1);
                        word.Cell cell2 = doc.Tables[2].Cell(i + 1, 2);
                        cell.Range.Text = day.dayName;
                        cell.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        cell2.Range.Text = item.GeneralSerName;
                        cell2.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        i++;
                    }

                }

                i = 1;
                foreach (var day in days)
                {
                    combinetion_of_tours_list = ServiceList.UpdateCombinetion_of_tours_List(day.idTour_days);

                    foreach (var item in combinetion_of_tours_list)
                    {
                        doc.Tables[3].Rows.Add(doc.Tables[3].Rows[i]);
                        word.Cell cell = doc.Tables[3].Cell(i, 1);
                        word.Cell cell2 = doc.Tables[3].Cell(i + 1, 2);
                        cell.Range.Text = day.dayName;
                        cell.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        cell2.Range.Text = item.combinetionOfToursName;
                        cell2.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        i++;
                    }

                }


                i = 1;
                foreach (var day in days)
                {
                    food_list = ServiceList.Updatefood_Lists(day.idTour_days);

                    foreach (var item in food_list)
                    {
                        doc.Tables[4].Rows.Add(doc.Tables[4].Rows[i]);
                        word.Cell cell = doc.Tables[4].Cell(i, 1);
                        word.Cell cell2 = doc.Tables[4].Cell(i + 1, 2);
                        cell.Range.Text = day.dayName;
                        cell.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        cell2.Range.Text = item.Food_price.ToString();
                        cell2.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        i++;
                    }

                }


                i = 1;
                foreach (var day in daysWithTour)
                {
                    doc.Tables[5].Rows.Add(doc.Tables[5].Rows[i]);
                    doc.Tables[6].Rows.Add(doc.Tables[6].Rows[i]);
                    word.Cell cell = doc.Tables[5].Cell(i, 1);
                    word.Cell cell2 = doc.Tables[5].Cell(i + 1, 2);
                    cell.Range.Text = day.dayName;
                    cell.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;


                    cell2.Range.Text = day.accommodationName;
                    cell2.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                    i++;
                }

                i = 1;
                foreach (var day in days)
                {
                    transport_list = ServiceList.UpdateTransport_list(day.idTour_days);

                    foreach (var item in transport_list)
                    {
                        doc.Tables[6].Rows.Add(doc.Tables[6].Rows[i]);
                        word.Cell cell = doc.Tables[6].Cell(i, 1);
                        word.Cell cell2 = doc.Tables[6].Cell(i + 1, 2);
                        cell.Range.Text = day.dayName;
                        cell.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        cell2.Range.Text = item.transportName;
                        cell2.Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphRight;
                        i++;
                    }

                }


                

                doc.Saved = true;
                doc.SaveAs2(path + @"\TourDay2.docx");
                doc.SaveAs2(path + @"\TourDay3.pdf", word.WdSaveFormat.wdFormatPDF);
                MessageBox.Show("Договор составлен !! \n ");
            }
            catch (Exception e)
            {

                MessageBox.Show("Ошибка состовления договра !! \n " + e.Message);
            }
            finally
            {
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("Microsoft Word");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
            
            
        }


        /*static public void ExcelDocOutputDates(ref System.Data.DataTable dt, string File_name, string DocName,string Date)
        {
            Excel.Application xlApp;
            //Лист
            Excel.Worksheet xlSheet = null;
            //Выделеная область
            Excel.Range xlSheetRange;

            xlApp = new Excel.Application();
            try
            {
                xlApp.Workbooks.Add(Type.Missing);

                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = File_name;

                Excel.Range _excelCells1 = (Excel.Range)xlSheet.get_Range("A1", "A3").Cells;
                // Производим объединение
                _excelCells1.Merge(Type.Missing);
                xlSheet.Cells[1, 3] = @"Автосалон" + "\r\n" + "'Акатон'";

                Excel.Range excelCells = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 1]];
                xlSheet.Cells[1, 1] = @"Автосалон" + "\r\n" + "'Акатон'";

                Excel.Range excelCells5 = xlSheet.Range[xlSheet.Cells[1, 5], xlSheet.Cells[1, 5]];
                xlSheet.Cells[1, 5] = DocName;

                Excel.Range excelCells6 = xlSheet.Range[xlSheet.Cells[1, 4], xlSheet.Cells[1, 4]];
                xlSheet.Cells[1, 4] = @"Название документа: ";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 2], xlSheet.Cells[1, 2]];
                xlSheet.Cells[1, 2] = @"Дата создания документа: ";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 3], xlSheet.Cells[1, 3]];
                xlSheet.Cells[1, 3] = DateTime.Now.ToShortDateString();

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[2, 2], xlSheet.Cells[2, 2]];
                xlSheet.Cells[2, 2] = @"Документ сформирован: ";

                Excel.Range excelCells4 = xlSheet.Range[xlSheet.Cells[2, 3], xlSheet.Cells[2, 3]];
                xlSheet.Cells[2, 3] = Avtorisation.UserName;

                Excel.Range excelCells7 = xlSheet.Range[xlSheet.Cells[2, 4], xlSheet.Cells[2, 4]];
                Excel.Range excelCells8 = xlSheet.Range[xlSheet.Cells[2, 5], xlSheet.Cells[2, 5]];

                xlSheet.Cells[2, 4] = @"Список автомобилей : ";
                xlSheet.Cells[2, 5] = Date;


                xlSheet.Cells.get_Range("A5", "Z5").ColumnWidth = 50;

                excelCells2.Merge(Type.Missing);

                excelCells.Cells.Font.Bold = true;
                excelCells.Cells.Font.Size = 18;
                excelCells.Font.Italic = true;

                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 14;
                excelCells1.Font.Italic = true;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells2.Cells.Font.Size = 12;
                excelCells2.Font.Italic = true;
                excelCells4.Cells.Font.Size = 12;
                excelCells4.Font.Italic = true;



                excelCells3.Cells.Font.Bold = true;
                excelCells3.Cells.Font.Size = 14;
                excelCells3.Font.Italic = true;
                excelCells3.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells4.Cells.Font.Bold = true;
                excelCells4.Cells.Font.Size = 14;
                excelCells4.Font.Italic = true;
                excelCells4.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells5.Cells.Font.Bold = true;
                excelCells5.Cells.Font.Size = 14;
                excelCells5.Font.Italic = true;
                excelCells5.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells6.Cells.Font.Bold = true;
                excelCells6.Cells.Font.Size = 14;
                excelCells6.Font.Italic = true;
                excelCells6.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells7.Cells.Font.Bold = true;
                excelCells7.Cells.Font.Size = 14;
                excelCells7.Font.Italic = true;
                excelCells7.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells8.Cells.Font.Bold = true;
                excelCells8.Cells.Font.Size = 14;
                excelCells8.Font.Italic = true;
                excelCells8.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);



                int collInd = 0;
                int rowInd;
                string data = "";

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[5, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A5:Z5", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 6, collInd + 1] = data;
                    }
                }
                xlSheetRange = xlSheet.UsedRange;

                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка формирования таблицы", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            finally
            {
                string path = Directory.GetCurrentDirectory();
                xlSheet.SaveAs(path + $@"\{File_name}.xlsx");
                System.Windows.Forms.MessageBox.Show("Данные сохранены в xlsx-файле", "Готово", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
        }*/

        /*static public void ExcelDocOutputMenedj(ref System.Data.DataTable dt,string File_name, string DocName, string Menedjer)
        {
            Excel.Application xlApp;
            //Лист
            Excel.Worksheet xlSheet = null;
            //Выделеная область
            Excel.Range xlSheetRange;

            xlApp = new Excel.Application();
            try
            {
                xlApp.Workbooks.Add(Type.Missing);

                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                xlSheet.Name = File_name;

                Excel.Range _excelCells1 = (Excel.Range)xlSheet.get_Range("A1", "A3").Cells;
                // Производим объединение
                _excelCells1.Merge(Type.Missing);
                xlSheet.Cells[1, 3] = @"Автосалон" + "\r\n" + "'Акатон'";

                Excel.Range excelCells = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 1]];
                xlSheet.Cells[1, 1] = @"Автосалон" + "\r\n" + "'Акатон'";

                Excel.Range excelCells5 = xlSheet.Range[xlSheet.Cells[1, 5], xlSheet.Cells[1, 5]];
                xlSheet.Cells[1, 5] = DocName;

                Excel.Range excelCells6 = xlSheet.Range[xlSheet.Cells[1, 4], xlSheet.Cells[1, 4]];
                xlSheet.Cells[1, 4] = @"Название документа: ";

                Excel.Range excelCells1 = xlSheet.Range[xlSheet.Cells[1, 2], xlSheet.Cells[1, 2]];
                xlSheet.Cells[1, 2] = @"Дата создания документа: ";

                Excel.Range excelCells2 = xlSheet.Range[xlSheet.Cells[1, 3], xlSheet.Cells[1, 3]];
                xlSheet.Cells[1, 3] = DateTime.Now.ToShortDateString();

                Excel.Range excelCells3 = xlSheet.Range[xlSheet.Cells[2, 2], xlSheet.Cells[2, 2]];
                xlSheet.Cells[2, 2] = @"Документ сформирован: ";

                Excel.Range excelCells4 = xlSheet.Range[xlSheet.Cells[2, 3], xlSheet.Cells[2, 3]];
                xlSheet.Cells[2, 3] = Avtorisation.UserName;

                Excel.Range excelCells7 = xlSheet.Range[xlSheet.Cells[2, 4], xlSheet.Cells[2, 4]];
                Excel.Range excelCells8 = xlSheet.Range[xlSheet.Cells[2, 5], xlSheet.Cells[2, 5]];

                xlSheet.Cells[2, 4] = @"Список договоров менеджера : ";
                xlSheet.Cells[2, 5] = Menedjer;

                xlSheet.Cells.get_Range("A5", "Z5").ColumnWidth = 50;

                excelCells2.Merge(Type.Missing);

                excelCells.Cells.Font.Bold = true;
                excelCells.Cells.Font.Size = 18;
                excelCells.Font.Italic = true;

                excelCells1.Cells.Font.Bold = true;
                excelCells1.Cells.Font.Size = 14;
                excelCells1.Font.Italic = true;
                excelCells1.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells2.Cells.Font.Size = 12;
                excelCells2.Font.Italic = true;
                excelCells4.Cells.Font.Size = 12;
                excelCells4.Font.Italic = true;



                excelCells3.Cells.Font.Bold = true;
                excelCells3.Cells.Font.Size = 14;
                excelCells3.Font.Italic = true;
                excelCells3.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells4.Cells.Font.Bold = true;
                excelCells4.Cells.Font.Size = 14;
                excelCells4.Font.Italic = true;
                excelCells4.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells5.Cells.Font.Bold = true;
                excelCells5.Cells.Font.Size = 14;
                excelCells5.Font.Italic = true;
                excelCells5.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells6.Cells.Font.Bold = true;
                excelCells6.Cells.Font.Size = 14;
                excelCells6.Font.Italic = true;
                excelCells6.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells7.Cells.Font.Bold = true;
                excelCells7.Cells.Font.Size = 14;
                excelCells7.Font.Italic = true;
                excelCells7.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);

                excelCells8.Cells.Font.Bold = true;
                excelCells8.Cells.Font.Size = 14;
                excelCells8.Font.Italic = true;
                excelCells8.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                //GetGroup();


                int collInd = 0;
                int rowInd;
                string data = "";

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[5, i + 1] = data;

                    xlSheetRange = xlSheet.get_Range("A5:Z5", Type.Missing);
                    xlSheetRange.Font.Color = ColorTranslator.ToOle(Color.MidnightBlue);
                    xlSheetRange.Font.Size = 12;
                    xlSheetRange.Font.Bold = true;
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 6, collInd + 1] = data;
                    }
                }
                xlSheetRange = xlSheet.UsedRange;

                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка формирования таблицы", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            finally
            {
                string path = Directory.GetCurrentDirectory();
                xlSheet.SaveAs(path + $@"\{File_name}.xlsx");
                System.Windows.Forms.MessageBox.Show("Данные сохранены в xlsx-файле", "Готово", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                xlApp.Workbooks.Close();
                xlApp.Quit();
                Process[] ps2 = System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (Process p2 in ps2)
                {
                    p2.Kill();
                }
            }
        }*/



    }
}
