using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ОАИП_12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        private readonly AppDbContext _context;
        private readonly Client _user;

        public MainForm(AppDbContext context, Client user)
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Laba12;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            cn.Open();

            _context = context;
            _user = user;

            _user.Sales = _context.Sales.Where(b => b.Clientid == _user.Id).ToList();


            Text = $"Покупки пользователя {_user.Name}";

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _user.Sales;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                var saleForm = new SaleForm(_context, _user);
                if (saleForm.ShowDialog() == DialogResult.OK)
                {
                    _user.Sales.Add(saleForm.Sale);
                    _context.SaveChanges();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _user.Sales;
                }
            }
            catch (Exception ex) { MessageBox.Show("Выберите строчку!"); }

        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                cmd = new SqlCommand("DELETE FROM Sales where Id='" + Convert.ToString(selectedRow) + "'", cn);
                dr = cmd.ExecuteReader();
                var sale = (Sale)selectedRow.DataBoundItem;
                _user.Sales.Remove(sale);
                _context.SaveChanges();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _user.Sales;
            }
            catch (Exception ex) { MessageBox.Show("Выберите строчку!"); }
        }

        private void button_ex_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var sale = (Sale)selectedRow.DataBoundItem;
                Sale salev = _context.Sales.FirstOrDefault(u => u.Id == sale.Id);

                if (salev != null) salev.Status = comboBox1.SelectedItem.ToString();
                _context.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _user.Sales;
            }
            catch (Exception ex) { MessageBox.Show("Выберите строчку!"); }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Оплачен", "В пути", "Готов к выдаче", "Получен" });
            comboBox1.SelectedIndex = 0;
        }
    }
}

