using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class FourCustomController : UserControl
    {
        float somaTotal = 15;

        public FourCustomController()
        {
            InitializeComponent();
            InicializaControls();
        }

        private void InicializaControls()
        {
            checkBox1.Tag = 15f;
            checkBox2.Tag = 16f;
            checkBox3.Tag = 17f;
            checkBox4.Tag = 10f;
            checkBox5.Tag = 12f;
            checkBox6.Tag = 16f;
            checkBox7.Tag = 5f;
            checkBox8.Tag = 7f;
            checkBox9.Tag = 7f;

            textBox1.Text = string.Format("R$ {0:#,##0.00}", 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void Salvar(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void NaoNulo(object sender, CancelEventArgs e)
        {
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText(caminho, textBox2.Text);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            if (checkBox != null && checkBox.Tag != null)
                SomaTotal((float)checkBox.Tag, checkBox.Checked);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void SomaTotal(float valor, bool blnEntrada)
        {
            if (blnEntrada)
                somaTotal += valor;
            else
                somaTotal -= valor;

            textBox1.Text = string.Format("R${0:#,##0.00}", somaTotal);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
