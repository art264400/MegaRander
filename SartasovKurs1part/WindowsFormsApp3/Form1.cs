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
    public partial class Client : Form
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


        public Client()
        {
            InitializeComponent();
        }

        private void клиенты2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиенты2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet1.Сотрудники2". При необходимости она может быть перемещена или удалена.
            this.сотрудники2TableAdapter.Fill(this.dataBaseDataSet1.Сотрудники2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Работы2". При необходимости она может быть перемещена или удалена.
            //this.работы2TableAdapter.Fill(this.dataBaseDataSet.Работы2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Клиенты2". При необходимости она может быть перемещена или удалена.
            this.клиенты2TableAdapter.Fill(this.dataBaseDataSet.Клиенты2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new addClient();//создаем объект форму добавления клиента
            frm.ShowDialog();//открываем ее как диаологовое окно
            if (frm.Rc)// если нажата кнопка ок, то выполняем
            {
                var FIO = frm.FIO;// создаем переменную и ей присваеваем значение, которые задали в диалог.
                клиенты2TableAdapter.Insert(FIO);//вставляем в таблеадаптер новые данные
                клиенты2TableAdapter.Fill(dataBaseDataSet.Клиенты2);//заполняем таблеадаптер
                клиенты2TableAdapter.Adapter.Update(dataBaseDataSet.Клиенты2);//обновляем адаптер
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new addClient();//создаем объект форму
            var Id = Convert.ToInt32(клиенты2DataGridView.CurrentRow.Cells[0].Value);//id клиента берем из datagrid текущего значения
            String FIO = клиенты2DataGridView.CurrentRow.Cells[1].Value as String; //ФИО берем из datagrid
            frm.FIO = FIO;//присваиваем свойству форме, которое мы сами определили
            frm.ShowDialog();//открываем форму как даилогове окно
            if (frm.Rc)//если нажали ок
            {
                клиенты2TableAdapter.Update(frm.FIO, Id);//обновляем данные 
                клиенты2TableAdapter.Fill(dataBaseDataSet.Клиенты2);//заполняем таблицу
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Удалить клиента?", "Вопрос",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);//диалоговое окно
            if (result == DialogResult.Yes)//если в диалоговом окне нажали ок
            {
                DataGridViewRow dgvr = клиенты2DataGridView.CurrentRow;//создаем объект DataGridViewRow
                Int32 ID = Convert.ToInt32(dgvr.Cells[0].Value);//получаем id клиента
                клиенты2TableAdapter.Delete(ID);//удаляем клиента по id
                клиенты2TableAdapter.Fill(dataBaseDataSet.Клиенты2); //заполняем таблицу
            }
        }

        private void клиенты2DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var Id = Convert.ToInt32(клиенты2DataGridView.CurrentRow.Cells[0].Value);
                работы2TableAdapter.Fill(dataBaseDataSet.Работы2, null, Id);
            }
            catch
            {
                
            }
         

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new addJob();
            frm.ShowDialog();
            if (frm.Rc)
            {
                var Id_client = Convert.ToInt32(клиенты2DataGridView.CurrentRow.Cells[0].Value);
                var JobName = frm.JobName;
                var Adress = frm.Adress;
                var Eployees_Id = frm.Eployees_Id;
                var Date = frm.Date;
                var Times = frm.Times;
                работы2TableAdapter.Insert(JobName, Times, Eployees_Id, Id_client, Date, Adress);
                работы2TableAdapter.Fill(dataBaseDataSet.Работы2, null, Id_client);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm = new addJob();
            var Job_Id = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[0].Value);
            var JobName = работы2DataGridView.CurrentRow.Cells[1].Value.ToString();
            var Times = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[2].Value);
            var Id_Client = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[3].Value);
            var Date = Convert.ToDateTime(работы2DataGridView.CurrentRow.Cells[4].Value.ToString());
            var Adress = работы2DataGridView.CurrentRow.Cells[5].Value.ToString();
            var Eployees_Id = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[6].Value.ToString());
            frm.Id_client = Id_Client;
            frm.JobName = JobName;
            frm.Adress = Adress;
            frm.Date = Date;
            frm.Eployees_Id = Eployees_Id;
            frm.Times = Times;
            frm.ShowDialog();
            if (frm.Rc)
            {
                работы2TableAdapter.Update(frm.JobName, frm.Times, frm.Eployees_Id, frm.Id_client, frm.Date, frm.Adress,
                    Job_Id);
                работы2TableAdapter.Fill(dataBaseDataSet.Работы2, null, Id_Client);
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

            string[] c = { "A", "B" };
            

            // Цикл по строкам таблицы
            for (int i = 0; i < клиенты2DataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j < клиенты2DataGridView.ColumnCount; j++)
                {

                    excelcells = excelworksheet.get_Range(c[j] + Convert.ToString(i + 2), c[j] +Convert.ToString(i + 2));
                    excelcells.Value2 = клиенты2DataGridView.Rows[i].Cells[j].Value.ToString();
                } // for

            }
            excelcells = excelworksheet.get_Range("A1", "B1");
            // Шрифт жирный
            excelcells.Font.Bold = true;
            // Размер 12
            excelcells.Font.Size = 12;
            // Выравнивание по центру
            excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
            excelcells = excelworksheet.get_Range("A1", "B" +
                                                        Convert.ToSingle(клиенты2DataGridView.RowCount + 1));
            // Подгоним ширины столбцов
            excelcells.Columns.AutoFit();
            excelcells = excelworksheet.get_Range("A1", "B" +
                                                        Convert.ToSingle(клиенты2DataGridView.RowCount + 1));
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
            //excelcells.Value2 = "Время выполнения";
            excelcells = excelworksheet.get_Range("C1", "C1");
            excelcells.Value2 = "Время выполнения";
            int i = 2;
            // Цикл по строкам таблицы, dr-текущая строка BindingSource
            foreach (DataRowView dr in работы2BindingSource)
            {
               
                int idJob = Convert.ToInt32(dr.Row["Код_работы"]);
                string JobName= dr.Row["Наименовине"].ToString();
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
                                                        Convert.ToSingle(клиенты2DataGridView.RowCount + 1));
            // Подгоним ширины столбцов
            excelcells.Columns.AutoFit();
            excelcells = excelworksheet.get_Range("A1", "C" +
                                                        Convert.ToSingle(клиенты2DataGridView.RowCount + 1));
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
            for (клиенты2BindingSource.MoveFirst();
               i < клиенты2BindingSource.Count;
                клиенты2BindingSource.MoveNext())
            {
                // Получаем доступ к объекту текущая запись таблицы route
                DataRowView drv1 = клиенты2BindingSource.Current as DataRowView;
                // Получаем значения полей Route_ID, Number, Type, Comment
                int ID = Convert.ToInt32(drv1.Row["Код_клиента"]);
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
                клиенты2TableAdapter.Fill(dataBaseDataSet.Клиенты2);
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
                       Time +" мин");
                    j++;
                } // for
                i++;
            } // for

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var frm=new Workers();
            frm.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить работу?", "Вопрос",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                var Job_Id = Convert.ToInt32(работы2DataGridView.CurrentRow.Cells[0].Value);
                var Client_Id = Convert.ToInt32(клиенты2DataGridView.CurrentRow.Cells[0].Value);
                работы2TableAdapter.Delete(Job_Id);
                работы2TableAdapter.Fill(dataBaseDataSet.Работы2, null, Client_Id);
            }
        }
    }
}
