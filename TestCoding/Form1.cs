using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<PaymentCategory> paymentCategories = new List<PaymentCategory>
            {
                new PaymentCategory { Id = 1, Name = "Physical Product" },
                new PaymentCategory { Id = 2, Name = "Book" },
                new PaymentCategory { Id = 3, Name = "New Membership" },
                new PaymentCategory { Id = 4, Name = "Upgrade Membership" },
                new PaymentCategory { Id = 5, Name = "Learning to Ski Video" }
            };

            
            cmBxPaymentCategory.ValueMember = "Id";
            cmBxPaymentCategory.DisplayMember = "Name";
            cmBxPaymentCategory.DataSource = paymentCategories;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aa = cmBxPaymentCategory.SelectedItem;
            var tt = aa;
        }
    }
}
