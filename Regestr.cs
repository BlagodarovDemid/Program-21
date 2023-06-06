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
    public partial class Regestr : Form
    {
        public Regestr()
        {
            InitializeComponent();
        }

        private void Regestr_Load(object sender, EventArgs e)
        {

        }


        private readonly AppDbContext _context;
        public Regestr(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new Client
            {
                Name = textBox_name.Text,
                Email = textBox_email.Text,
                Phone = textBox_phone.Text,
                Password = textBox_pass.Text,
               
            };

            _context.Clients.Add(user);
            _context.SaveChanges();

            MessageBox.Show("Вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }


    }

}
