using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace WindowsFormsApp3
{
    public partial class Workers : Form
    {
        private Excel.Application excelapp;                    // Программа Excel
        private Excel.Window excelWindow;                 // Окно программы Excel
        private Excel.Workbooks excelappworkbooks;  // Рабочие книги
        private Excel.Workbook excelappworkbook;     // Рабочая книга
        private Excel.Sheets excelsheets;                        // Рабочие листы
        private Excel.Worksheet excelworksheet;           // Рабочий лист
        private Excel.Range excelcells;                           // Диапазон ячеек или ячейка

        private Word.Application WordApp;       // Программа Word
        private Word.Documents WordDocuments;   // Документы
        private Word.Document WordDocument; // Документ
        private Word.Paragraphs WordParagraphs; // Параграфы
        private Word.Paragraph WordParagraph;   // Параграф
        private Word.Range WordRange;		// Выделенный диапазон

        public Workers()
        {
            InitializeComponent();
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Клиенты2". При необходимости она может быть перемещена или удалена.
            this.клиенты2TableAdapter.Fill(this.dataBaseDataSet.Клиенты2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Сотрудники2". При необходимости она может быть перемещена или удалена.
            this.сотрудники2TableAdapter.Fill(this.dataBaseDataSet.Сотрудники2);

        }

      

        private void сотрудники2DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var Id = Convert.ToInt32(сотрудники2DataGridView.CurrentRow.Cells[0].Value);
                работы2TableAdapter.Fill(dataBaseDataSet.Работы2, Id, null);
                
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm=new addWorker();
            frm.ShowDialog();
            if (frm.Rc)
            {
                var FIO = frm.FIO;
                var Education = frm.Education;
                var Qualification = frm.Qualification;
                сотрудники2TableAdapter.Insert(FIO, Education, Qualification);
                сотрудники2TableAdapter.Fill(dataBaseDataSet.Сотрудники2);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new addWorker();
            var Id = Convert.ToInt32(сотрудники2DataGridView.CurrentRow.Cells[0].Value);
            var FIO = сотрудники2DataGridView.CurrentRow.Cells[1].Value as String;
            var Education = сотрудники2DataGridView.CurrentRow.Cells[2].Value as String;
            var Qualification = сотрудники2DataGridView.CurrentRow.Cells[3].Value as String;
            frm.FIO = FIO;
            frm.Education = Education;
            frm.Qualification = Qualification;
            frm.ShowDialog();
            if (frm.Rc == true)
            {
                сотрудники2TableAdapter.Update(frm.FIO, frm.Education, frm.Qualification, Id);
                сотрудники2TableAdapter.Fill(dataBaseDataSet.Сотрудники2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить сотрудника?", "Вопрос",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow dgvr = сотрудники2DataGridView.CurrentRow;
                Int32 ID = Convert.ToInt32(dgvr.Cells[0].Value);
                String FIO = dgvr.Cells[1].Value as String;
                String Education = dgvr.Cells[2].Value as String;
                String Qualification = dgvr.Cells[3].Value as String;
                сотрудники2TableAdapter.Delete(ID);
                сотрудники2TableAdapter.Fill(dataBaseDataSet.Сотрудники2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new addJob2();
            frm.ShowDialog();
            if (frm.Rc)
            {
                var Worker_id = Convert.ToInt32(сотрудники2DataGridView.CurrentRow.Cells[0].Value);
                var JobName = frm.JobName;
                var Adress = frm.Adress;
                var Client_Id = frm.Client_Id;
                var Date = frm.Date;
                var Times = frm.Times;
                работы2TableAdapter.Insert(JobName, Times,Worker_id, Client_Id, Date, Adress);
                работы2TableAdapter.Fill(dataBaseDataSet.Работы2,Worker_id,null);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm = new addJob2();
           
            var Job_Id = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[0].Value);
            var JobName = работы2DataGridView.CurrentRow.Cells[1].Value.ToString();
            var Times = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[2].Value);
            var Worker_Id = Convert.ToInt32(сотрудники2DataGridView.CurrentRow.Cells[0].Value);
            var Client_Id = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[4].Value);
            var Date = Convert.ToDateTime(работы2DataGridView.CurrentRow.Cells[5].Value.ToString());
            var Adress = работы2DataGridView.CurrentRow.Cells[6].Value.ToString();
            frm.JobName = JobName;
            frm.Times = Times;
            frm.Adress = Adress;
            frm.Client_Id = Client_Id;
            frm.Date = Date;
            frm.ShowDialog();

            if (frm.Rc)
            {
                работы2TableAdapter.Update(frm.JobName, frm.Times, Worker_Id, frm.Client_Id, frm.Date, frm.Adress, Job_Id);
                работы2TableAdapter.Fill(dataBaseDataSet.Работы2, Worker_Id, null);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить работу?", "Вопрос",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                var Job_Id = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[0].Value);
                var Worker_Id = Convert.ToInt32(сотрудники2DataGridView.CurrentRow.Cells[0].Value);
                работы2TableAdapter.Delete(Job_Id);
                работы2TableAdapter.Fill(dataBaseDataSet.Работы2,Worker_Id,null);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Запустим Excel
            excelapp = new Excel.Application();
            // Сделаем Excel видимым
            excelapp.Visible = true;
            // В книге, которую создадим позже, будет 3 листа
            excelapp.SheetsInNewWorkbook = 3;
            // Создадим книгу
            excelapp.Workbooks.Add(Type.Missing);
            // Получаем набор ссылок на объекты Workbook (на созданные книги)
            excelappworkbooks = excelapp.Workbooks;
            //Получаем ссылку на книгу 1 - нумерация от 1
            excelappworkbook = excelappworkbooks[1];
            // Получаем ссылку на рабочие листы книги
            excelsheets = excelappworkbook.Worksheets;
            //Получаем ссылку на лист 1
            excelworksheet = (Excel.Worksheet)excelsheets[1];
            // Сделаем первый лист активным

            excelworksheet.Activate();
            // Запишем в ячейку b1
            excelcells = excelworksheet.get_Range("A1", "A1");
            excelcells.Value2 = "Id";
            excelcells = excelworksheet.get_Range("B1", "B1");
            excelcells.Value2 = "ФИО";

            string[] c = { "A", "B","C","D" };


            // Цикл по строкам таблицы
            for (int i = 0; i < сотрудники2DataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j < сотрудники2DataGridView.ColumnCount; j++)
                {

                    excelcells = excelworksheet.get_Range(c[j] + Convert.ToString(i + 2), c[j] + Convert.ToString(i + 2));
                    excelcells.Value2 = сотрудники2DataGridView.Rows[i].Cells[j].Value.ToString();
                } // for

            }
            excelcells = excelworksheet.get_Range("A1", "D1");
            // Шрифт жирный
            excelcells.Font.Bold = true;
            // Размер 12
            excelcells.Font.Size = 12;
            // Выравнивание по центру
            excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
            excelcells = excelworksheet.get_Range("A1", "D" +
                                                        Convert.ToSingle(сотрудники2DataGridView.RowCount + 1));
            // Подгоним ширины столбцов
            excelcells.Columns.AutoFit();
            excelcells = excelworksheet.get_Range("A1", "D" +
                                                        Convert.ToSingle(сотрудники2DataGridView.RowCount + 1));
            Excel.XlBordersIndex bi = Excel.XlBordersIndex.xlInsideVertical;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlInsideHorizontal;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeLeft;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeTop;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeBottom;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeRight;
            excelcells.Borders[bi].LineStyle = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Запускаем Word
            WordApp = new Word.Application();
            // Делаем Word видимым
            WordApp.Visible = true;
            // Получаем доступ к объекту все документы
            WordDocuments = WordApp.Documents;
            // Добавляем документ
            WordDocument = WordDocuments.Add();
            // Получаем доступ к объекту все параграфы
            WordParagraphs = WordDocument.Content.Paragraphs;
            // Получаем доступ к объекту первый параграф
            WordParagraph = WordParagraphs[1];
            // Устанавливаем выравнивание по центру
            WordParagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            // Получаем доступ к объекту выделенный участок
            WordRange = WordParagraph.Range;
            // Добавим текст в выделенный участок
            WordRange.InsertAfter("Клиенты и их заявки\n");
            // Сделаем шрифт выделенного участка жирным
            WordRange.Font.Bold = 1;
            // Сделаем размер шрифта выделенного участка равным 16
            WordRange.Font.Size = 16;
            // Сбросим выделение участка
            WordRange.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            // Сейчас выделенным участком будет пустой участок в конце текста
            WordRange = WordParagraph.Range;
            // Добавим текст, он будет выделенным участком.
            WordRange.InsertAfter("по состоянию на" +
               DateTime.Now.ToLongDateString() + "\n");
            // Сделаем шрифт выделенного участка нежирным
            WordRange.Font.Bold = 0;
            // Сделаем размер шрифта выделенного участка равным 14
            WordRange.Font.Size = 14;
            int i = 0, j = 0;
            // Цикл по записям таблицы route
            for (сотрудники2BindingSource.MoveFirst();
               i < сотрудники2BindingSource.Count;
                сотрудники2BindingSource.MoveNext())
            {
               
                DataRowView drv1 = сотрудники2BindingSource.Current as DataRowView;
                
                int ID = Convert.ToInt32(drv1.Row["Код_сотрудника"]);
                string FIO = drv1.Row["ФИО"].ToString();
                // Добавим параграф
                WordParagraph = WordParagraphs.Add();
                // Устанавливаем выравнивание по левой границе
                WordParagraph.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphLeft;
                // Получим доступ к выделенному участку нового параграфа
                WordRange = WordParagraph.Range;
                // Установим шрифт выделенного участка нового параграфа
                WordRange.Font.Bold = 0;
                WordRange.Font.Size = 12;
                // Добавим текст в новый параграф
                WordRange.InsertAfter(Convert.ToString(ID) + ". " + FIO);

                j = 0;
                // Заполним набор данных DataTable1
               // клиенты2TableAdapter.Fill(dataBaseDataSet.Сотрудники2);
                // Цикл по записям таблицы DataTable1
                for (работы2BindingSource.MoveFirst();
                   j < работы2BindingSource.Count;
                    работы2BindingSource.MoveNext())
                {
                    // Получаем доступ к объекту текущая запись DataTable1
                    DataRowView drv2 = работы2BindingSource.Current as
                       DataRowView;
                    // Получаем значения полей StopNumb, Name
                    int Time = Convert.ToInt32(drv2.Row["Время_выполнения"]);
                    string JobName = drv2.Row["Наименовине"].ToString();
                    // Добавим параграф
                    WordParagraph = WordParagraphs.Add();
                    // Устанавливаем выравнивание по левой границе
                    WordParagraph.Alignment =
                       Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    // Получим доступ к выделенному участку нового параграфа
                    WordRange = WordParagraph.Range;
                    // Установим шрифт выделенного участка нового параграфа
                    WordRange.Font.Bold = 0;
                    WordRange.Font.Size = 12;
                    // Добавим текст в новый параграф
                    WordRange.InsertAfter("\t" + Convert.ToString(JobName) + ", время выполнения " +
                       Time + " мин");
                    j++;
                } // for
                i++;
            } // for

        }

        private void button8_Click(object sender, EventArgs e)
        {
            excelapp = new Excel.Application();
            // Сделаем Excel видимым
            excelapp.Visible = true;
            // В книге, которую создадим позже, будет 3 листа
            excelapp.SheetsInNewWorkbook = 3;
            // Создадим книгу
            excelapp.Workbooks.Add(Type.Missing);
            // Получаем набор ссылок на объекты Workbook (на созданные книги)
            excelappworkbooks = excelapp.Workbooks;
            //Получаем ссылку на книгу 1 - нумерация от 1
            excelappworkbook = excelappworkbooks[1];
            // Получаем ссылку на рабочие листы книги
            excelsheets = excelappworkbook.Worksheets;
            //Получаем ссылку на лист 1
            excelworksheet = (Excel.Worksheet)excelsheets[1];
            // Сделаем первый лист активным
            excelworksheet.Activate();
            // Запишем в ячейку A1
            excelcells = excelworksheet.get_Range("A1", "A1");
            excelcells.Value2 = "Id";
            // Запишем в ячейку B1
            excelcells = excelworksheet.get_Range("B1", "B1");
            excelcells.Value2 = "Наименование";
           
            excelcells = excelworksheet.get_Range("C1", "C1");
            excelcells.Value2 = "Время выполнения";
            int i = 2;
            // Цикл по строкам таблицы, dr-текущая строка BindingSource
            foreach (DataRowView dr in работы2BindingSource)
            {

                int idJob = Convert.ToInt32(dr.Row["Код_работы"]);
                string JobName = dr.Row["Наименовине"].ToString();
                int Time = Convert.ToInt32(dr.Row["Время_выполнения"]);
                // Запишем в i-ю строку Excel таблицы
                excelcells = excelworksheet.get_Range("A" + Convert.ToString(i), "A" +
                                                                                 Convert.ToString(i));
                excelcells.Value2 = Convert.ToString(idJob);
                excelcells = excelworksheet.get_Range("B" + Convert.ToString(i), "B" +
                                                                                 Convert.ToString(i));
                excelcells.Value2 = Convert.ToString(JobName);
                excelcells = excelworksheet.get_Range("C" + Convert.ToString(i), "C" +
                                                                                 Convert.ToString(i));
                excelcells.Value2 = Convert.ToString(Time);

                i++;
            }
            excelcells = excelworksheet.get_Range("A1", "C1");
            // Шрифт жирный
            excelcells.Font.Bold = true;
            // Размер 12
            excelcells.Font.Size = 12;
            // Выравнивание по центру
            excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
            excelcells = excelworksheet.get_Range("A1", "C" +
                                                        Convert.ToSingle(сотрудники2DataGridView.RowCount + 1));
            // Подгоним ширины столбцов
            excelcells.Columns.AutoFit();
            excelcells = excelworksheet.get_Range("A1", "C" +
                                                        Convert.ToSingle(сотрудники2DataGridView.RowCount + 1));
            Excel.XlBordersIndex bi = Excel.XlBordersIndex.xlInsideVertical;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlInsideHorizontal;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeLeft;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeTop;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeBottom;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeRight;
            excelcells.Borders[bi].LineStyle = 1;
        }
    }
}
