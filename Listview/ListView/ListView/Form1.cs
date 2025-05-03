using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstvAlimento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewGroup frutas = new ListViewGroup("frutas", HorizontalAlignment.Left); 
            ListViewGroup carnes =  new ListViewGroup("carnes", HorizontalAlignment.Left);

            lstvAlimento.Items.Add(new ListViewItem("Manzana", frutas));
            lstvAlimento.Items.Add(new ListViewItem("Pera", frutas));
            lstvAlimento.Items.Add(new ListViewItem("Sandia", frutas));
            lstvAlimento.Items.Add(new ListViewItem("Banana", frutas));
            lstvAlimento.Items.Add(new ListViewItem("Melon", frutas));
            lstvAlimento.Items.Add(new ListViewItem("ciruela", frutas));

            ListViewItem miElemento = new ListViewItem("pollo", carnes);
            lstvAlimento.Items.Add(miElemento);

            lstvAlimento.Items.Add(new ListViewItem("Res", carnes));
            lstvAlimento.Items.Add(new ListViewItem("Pescado", carnes));
            lstvAlimento.Items.Add(new ListViewItem("Cerdo", carnes));
            lstvAlimento.Items.Add(new ListViewItem("Codorniz", carnes));

            lstvAlimento.Groups.Add(frutas);
            lstvAlimento.Groups.Add(carnes);
        }
    }
}
