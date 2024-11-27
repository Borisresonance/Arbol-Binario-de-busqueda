using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_de_busqueda
{
    public partial class MainForm : Form

    {// initialize class
        Binarytree bbt = new Binarytree();
        public MainForm()
        {
            InitializeComponent();
            //subscripcion del evento (call event) pass a method to a method
            panelArbol.Paint += new PaintEventHandler(panelArbol_Paint);
            panelPreorden.Paint += new PaintEventHandler(panelPreorden_Paint);
            panelInorden.Paint += new PaintEventHandler(panelInorden_Paint);
            panelPosorden.Paint += new PaintEventHandler(panelPosorden_Paint);

        }

        
        private void panelArbol_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            bbt.DrawTree(graphics, bbt.Root, panelArbol.Width / 2, 20, panelArbol.Width / 4, 50);

        }

        private void panelPreorden_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            List<int> preorder = bbt.GetPreorder(bbt.Root);
            bbt.DrawPreorder(graphics, preorder,20,panelPreorden.Height/2,50);
        }

        private void panelInorden_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            List<int> inorder = bbt.GetInOrder(bbt.Root);
            bbt.DrawInorder(graphics, inorder, 20, panelPreorden.Height / 2, 50);
        }

        private void panelPosorden_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            List<int> postorder = bbt.GetInOrder(bbt.Root);
            bbt.DrawPostorder(graphics, postorder, 20, panelPreorden.Height / 2, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int value))
            {
                bbt.Insert(value);
                textBox1.Clear();
                panelArbol.Invalidate();
                panelPreorden.Invalidate();
                panelInorden.Invalidate();
                panelPosorden.Invalidate();
            }
            else 
            {
                MessageBox.Show("Please, add a integer value");
            }
        }
    }
}
