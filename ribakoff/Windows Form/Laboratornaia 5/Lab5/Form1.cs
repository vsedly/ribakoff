using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Lab5
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, EntryPoint = "MessageBoxW")]
        public static extern int WinApiMessageBox(IntPtr hWnd, String text, String caption, uint type);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                worksheet.Cells[1, 1] = "лабораторная работа №5";
                worksheet.Cells[2, 1] = "дата:";
                worksheet.Cells[2, 2] = DateTime.Now.ToShortDateString();

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Lab5_Excel.xlsx";
                workbook.SaveAs(path);

                workbook.Close(false);
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("файл Excel созданнн на рабочем столе!!!!", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка: " + ex.Message);
            }
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            WinApiMessageBox(IntPtr.Zero, "привет из winAPI!", "WinAPI MessageBox", 0);
        }
    }
}