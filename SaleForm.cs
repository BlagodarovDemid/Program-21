using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОАИП_12
{
    public partial class SaleForm : Form
    {
        private readonly AppDbContext _context;
        private readonly Client _user;

        public Sale Sale { get; private set; }

        public SaleForm(AppDbContext context, Client user)
        {
            InitializeComponent();
            _context = context;
            _user = user;

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var sale = new Sale
            {
                Date = maskedTextBox1.Text,
                Goods = textBox_goods.Text,
                Number = int.Parse(textBox_num.Text),
                Status= comboBox1.SelectedItem.ToString(),
                //Year = int.Parse(YearTextBox.Text),
                Clientid = _user.Id
            };

            _context.Sales.Add(sale);
            _context.SaveChanges();

            Sale = sale;
            DialogResult = DialogResult.OK;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Оплачен", "В пути", "Готов к выдаче", "Получен" });
            comboBox1.SelectedIndex = 0;
        }
    }
}

