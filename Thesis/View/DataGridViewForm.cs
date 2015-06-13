using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Thesis.Model;
using Excel = Microsoft.Office.Interop.Excel;


namespace Thesis.View
{
    public partial class DataGridViewForm : Form
    {
        TableName choice;
        Worker w = null;
        int flag = 0;

        public DataGridViewForm(TableName _choice)
        {
            choice = _choice;
            InitializeComponent();
        }

        public DataGridViewForm(TableName _choice, int _flag)
        {
            choice = _choice;
            flag = _flag;
            InitializeComponent();
        }

        public DataGridViewForm(TableName _choice, Worker _w, int _flag)
        {
            choice = _choice;
            w = _w;
            flag = _flag;
            InitializeComponent();
        }

        public DataGridViewForm()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            GetDataSet();
        }

        private void GetDataSet()
        {
            switch (choice)
            {
                case TableName.CLIENTS:
                    dgvQueryResult.DataSource = clientsBindingSource;
                    if (flag == 9)
                    {
                        this.Text = "Електронни пощи на клиентите";
                        dgvQueryResult.Columns["SubFrom"].Visible = false;
                        dgvQueryResult.Columns["SubTo"].Visible = false;
                        dgvQueryResult.Columns["SubId"].Visible = false;
                        dgvQueryResult.Columns["AddedAt"].Visible = false;
                        dgvQueryResult.Columns["NumberRenewings"].Visible = false;
                        dgvQueryResult.Columns["PhoneNumber"].Visible = false;
                        dgvQueryResult.Columns["CoachId"].Visible = false;
                        dgvQueryResult.Columns["Bonus"].Visible = false;
                    }
                    else
                    {
                        this.Text = "Информация за клиентите";
                    }
                    this.clientsTableAdapter.Fill(this.gymDatabaseDataSet.Clients);
                    break;
                case TableName.EXPENSES:
                    this.Text = "Информация за разходите";
                    dgvQueryResult.DataSource = expensesBindingSource;
                    this.expensesTableAdapter.Fill(this.gymDatabaseDataSet.Expenses);
                    break;
                case TableName.INVENTORY:
                    this.Text = "Информация за оборудването";
                    dgvQueryResult.DataSource = inventoryBindingSource;
                    this.inventoryTableAdapter.Fill(this.gymDatabaseDataSet.Inventory);
                    break;
                case TableName.PROCEEDS:
                    this.Text = "Информация за приходите";
                    dgvQueryResult.DataSource = proceedsBindingSource;
                    this.proceedsTableAdapter.Fill(this.gymDatabaseDataSet.Proceeds);
                    break;
                case TableName.PRODUCTS:
                    this.Text = "Информация за продуктите";
                    dgvQueryResult.DataSource = productsBindingSource;
                    this.productsTableAdapter.Fill(this.gymDatabaseDataSet.Products);
                    break;
                case TableName.PROVIDERS:
                    dgvQueryResult.DataSource = providersBindingSource;
                    if (flag == 9)
                    {
                        this.Text = "Електронни пощи на доставчиците";
                        dgvQueryResult.Columns["Address"].Visible = false;
                        dgvQueryResult.Columns["PhoneNumber"].Visible = false;
                        dgvQueryResult.Columns["AccountablePersonName"].Visible = false;
                        dgvQueryResult.Columns["AccountablePersonPIN"].Visible = false;
                    }
                    else
                    {
                        this.Text = "Информация за доставчиците";
                    }
                    this.providersTableAdapter.Fill(this.gymDatabaseDataSet.Providers);
                    break;
                case TableName.SALARIES:
                    dgvQueryResult.DataSource = salariesBindingSource;
                    if (flag == 1)
                    {
                        this.Text = "Информация за заплатите";
                        this.salariesTableAdapter.Fill(this.gymDatabaseDataSet.Salaries);
                    }
                    else
                    {
                        this.Text = "Информация за заплатите на " + w.FirstName.Trim() + " " + w.LastName.Trim();
                        this.salariesTableAdapter.FillByWorkerId(this.gymDatabaseDataSet.Salaries, w.Id);
                    }
                    break;
                case TableName.SUBSCRIPTIONS:
                    this.Text = "Информация за абонаментите";
                    dgvQueryResult.DataSource = subscriptionsBindingSource;
                    this.subscriptionsTableAdapter.Fill(this.gymDatabaseDataSet.Subscriptions);
                    break;
                case TableName.SUPPLIES:
                    this.Text = "Информация за доставките";
                    dgvQueryResult.DataSource = suppliesBindingSource;
                    this.suppliesTableAdapter.Fill(this.gymDatabaseDataSet.Supplies);
                    break;
                case TableName.WORKERS:
                    dgvQueryResult.DataSource = workersBindingSource;
                    if (flag == 2)
                    {
                        this.Text = "Информация за треньорите";
                        dgvQueryResult.Columns["PIN"].Visible = false;
                        dgvQueryResult.Columns["FirstWorkDayDate"].Visible = false;
                        dgvQueryResult.Columns["MonthSalary"].Visible = false;
                        dgvQueryResult.Columns["Username"].Visible = false;
                        dgvQueryResult.Columns["Password"].Visible = false;
                        this.workersTableAdapter.FillWorkersByRole(this.gymDatabaseDataSet.Workers, 2);
                    }
                    else if (flag == 7)
                    {
                        this.Text = "Личен профил на " + w.FirstName.Trim() + " " + w.LastName.Trim();
                        this.workersTableAdapter.FillById(this.gymDatabaseDataSet.Workers, w.Id);
                    }
                    else if (flag == 9)
                    {
                        this.Text = "Електронни пощи на служителите";
                        dgvQueryResult.Columns["Username"].Visible = false;
                        dgvQueryResult.Columns["Password"].Visible = false;
                        dgvQueryResult.Columns["PIN"].Visible = false;
                        dgvQueryResult.Columns["FirstWorkDayDate"].Visible = false;
                        dgvQueryResult.Columns["MonthSalary"].Visible = false;
                        dgvQueryResult.Columns["PhoneNumber"].Visible = false;
                        this.workersTableAdapter.Fill(this.gymDatabaseDataSet.Workers);
                    }

                    else
                    {
                        this.Text = "Информация за служителите";
                        this.workersTableAdapter.Fill(this.gymDatabaseDataSet.Workers);
                    }
                    break;
                case TableName.WORKOUTS:
                    dgvQueryResult.DataSource = workoutsBindingSource;
                    if (flag == 7)
                    {
                        this.Text = "Информация за тренировките на " + w.FirstName.Trim() + " " + w.LastName.Trim();
                        this.workoutsTableAdapter.FillByCoachId(this.gymDatabaseDataSet.Workouts, w.Id);
                    }
                    else
                    {
                        this.Text = "Информация за тренировките";
                        this.workoutsTableAdapter.Fill(this.gymDatabaseDataSet.Workouts);
                    }
                    break;
                case TableName.WORKSCHEDULES:
                    dgvQueryResult.DataSource = workSchedulesBindingSource;
                    if (flag == 7)
                    {
                        this.Text = "Информация за работния график на " + w.FirstName.Trim() + " " + w.LastName.Trim();
                        this.workSchedulesTableAdapter.FillByWorkerId(this.gymDatabaseDataSet.WorkSchedules, w.Id);
                    }
                    else
                    {
                        this.Text = "Информация за работните графици";
                        this.workSchedulesTableAdapter.Fill(this.gymDatabaseDataSet.WorkSchedules);
                    }
                    break;
            }
        }

        private void gymDatabaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void FillTableAdapters()
        {
            this.clientsTableAdapter.Fill(this.gymDatabaseDataSet.Clients);
            this.expensesTableAdapter.Fill(this.gymDatabaseDataSet.Expenses);
            this.inventoryTableAdapter.Fill(this.gymDatabaseDataSet.Inventory);
            this.proceedsTableAdapter.Fill(this.gymDatabaseDataSet.Proceeds);
            this.productsTableAdapter.Fill(this.gymDatabaseDataSet.Products);
            this.providersTableAdapter.Fill(this.gymDatabaseDataSet.Providers);
            this.salariesTableAdapter.Fill(this.gymDatabaseDataSet.Salaries);
            this.subscriptionsTableAdapter.Fill(this.gymDatabaseDataSet.Subscriptions);
            this.suppliesTableAdapter.Fill(this.gymDatabaseDataSet.Supplies);
            this.workersTableAdapter.Fill(this.gymDatabaseDataSet.Workers);
            this.workoutsTableAdapter.Fill(this.gymDatabaseDataSet.Workouts);
            this.workSchedulesTableAdapter.Fill(this.gymDatabaseDataSet.WorkSchedules);
        }

        public void MakeExcelFile(string filename)
        {
            DateTime dt;
            decimal d;
            FillTableAdapters();

            string path = @"C:\Users\Stiliyan_lt\Documents\Visual Studio 2012\Projects\29.05ExcelWorks\Thesis\Thesis\file.xlsx";
            if (!File.Exists(path))
                File.Create(path);

            //Create an Excel application instance
            Excel.Application excelApp = new Excel.Application();

            //Create an Excel workbook instance and open it from the predefined location

            Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(path);

            foreach (DataTable table in gymDatabaseDataSet.Tables)
            {
                //Add a new worksheet to workbook with the Datatable name
                Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = table.TableName;

                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        if (table.Rows[j].ItemArray[k] is DateTime)
                        {
                            dt = (DateTime)table.Rows[j].ItemArray[k];
                            excelWorkSheet.Cells[j + 2, k + 1] = dt.ToShortDateString();//Да се направи за short date time
                        }
                        else if (table.Rows[j].ItemArray[k] is decimal)
                        {
                            d = (decimal)table.Rows[j].ItemArray[k];
                            excelWorkSheet.Cells[j + 2, k + 1] = d;//Да се раздели на 1000
                        }
                        else if (table.Rows[j].ItemArray[k].ToString() == "")
                            excelWorkSheet.Cells[j + 2, k + 1] = "null";
                        else
                            excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }
            }

            excelWorkBook.SaveAs(filename);
            excelWorkBook.Close();
            excelApp.Quit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.Text, new Font("Times New Roman", 18, FontStyle.Underline), Brushes.DarkRed, new Point(80, 100));
            
            this.dgvQueryResult.BackgroundColor = Color.White;
            Bitmap bm = new Bitmap(this.dgvQueryResult.Width, this.dgvQueryResult.Height);
            dgvQueryResult.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvQueryResult.Width, this.dgvQueryResult.Height));
            e.Graphics.DrawImage(bm, 80, 150);


            e.Graphics.DrawString("_____________________________________________________", 
                new Font("Times New Roman", 18, FontStyle.Regular),
                Brushes.DarkRed, new Point(80, 1020));

            e.Graphics.DrawString("Отпечатано на " + DateTime.Now + " от " + w.FirstName.Trim() + 
                " " + w.LastName.Trim(), new Font("Times New Roman", 18, FontStyle.Regular),
                Brushes.DarkRed, new Point(80, 1050));
        }
    }
}
