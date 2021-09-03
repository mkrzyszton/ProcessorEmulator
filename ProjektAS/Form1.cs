using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

            List<int> textBoxesLength = new List<int>();

            textBoxesLength.Add(AXbox1.Text.Length);
            textBoxesLength.Add(AXbox2.Text.Length);
            textBoxesLength.Add(BXbox1.Text.Length);
            textBoxesLength.Add(BXbox2.Text.Length);
            textBoxesLength.Add(CXbox1.Text.Length);
            textBoxesLength.Add(CXbox2.Text.Length);
            textBoxesLength.Add(DXbox1.Text.Length);
            textBoxesLength.Add(DXbox2.Text.Length);

            foreach (int Length in textBoxesLength)
            {
                if (Length > 0)
                {
                    AXbox1.Clear();
                    AXbox2.Clear();
                    BXbox1.Clear();
                    BXbox2.Clear();
                    CXbox1.Clear();
                    CXbox2.Clear();
                    DXbox1.Clear();
                    DXbox2.Clear();
                }
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            AXbox2.Clear();
            BXbox2.Clear();
            CXbox2.Clear();
            DXbox2.Clear();

            for (int i = 0; i < 4; i++)
            {
                if (random.Next(0, 3) == 0)
                {
                    AXbox2.Text += ((char)random.Next(65, 70)).ToString();
                }

                else
                {
                    AXbox2.Text += random.Next(0, 9);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (random.Next(0, 3) == 0)
                {
                    BXbox2.Text += ((char)random.Next(65, 70)).ToString();
                }

                else
                {
                    BXbox2.Text += random.Next(0, 9);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (random.Next(0, 3) == 0)
                {
                    CXbox2.Text += ((char)random.Next(65, 70)).ToString();
                }

                else
                {
                    CXbox2.Text += random.Next(0, 9);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (random.Next(0, 3) == 0)
                {
                    DXbox2.Text += ((char)random.Next(65, 70)).ToString();
                }

                else
                {
                    DXbox2.Text += random.Next(0, 9);
                }
            }
        }

        private void AXbox1_Validated(object sender, EventArgs e)
        {
            if (AXbox1.TextLength != 4)
                AXbox1.Clear();
        }

        private void AXbox2_Validated(object sender, EventArgs e)
        {
            if (AXbox2.TextLength != 4)
                AXbox2.Clear();
        }

        private void BXbox1_Validated(object sender, EventArgs e)
        {
            if (BXbox1.TextLength != 4)
                BXbox1.Clear();
        }

        private void BXbox2_Validated(object sender, EventArgs e)
        {
            if (BXbox2.TextLength != 4)
                BXbox2.Clear();
        }

        private void CXbox1_Validated(object sender, EventArgs e)
        {
            if (CXbox1.TextLength != 4)
                CXbox1.Clear();
        }

        private void CXbox2_Validated(object sender, EventArgs e)
        {
            if (CXbox2.TextLength != 4)
                CXbox2.Clear();
        }

        private void DXbox1_Validated(object sender, EventArgs e)
        {
            if (DXbox1.TextLength != 4)
                DXbox1.Clear();
        }

        private void DXbox2_Validated(object sender, EventArgs e)
        {
            if (DXbox2.TextLength != 4)
                DXbox2.Clear();
        }

        private void SIbox1_Validated(object sender, EventArgs e)
        {
            if (SIbox1.TextLength != 4)
                SIbox1.Clear();
        }

        private void DIbox1_Validated(object sender, EventArgs e)
        {
            if (DIbox1.TextLength != 4)
                DIbox1.Clear();
        }

        private void BPbox1_Validated(object sender, EventArgs e)
        {
            if (BPbox1.TextLength != 4)
                BPbox1.Clear();
        }

        private void DISPbox1_Validated(object sender, EventArgs e)
        {
            if (DISPbox1.TextLength != 4)
                DISPbox1.Clear();
        }

        private void AXbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void BXbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void CXbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void DXbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void SIbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void DIbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void BPbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void SPbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void DISPbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }


        private void MVAxBx_Click(object sender, EventArgs e)
        {
            string text1 = AXbox1.Text;
            BXbox1.Text = text1;

            string text2 = AXbox2.Text;
            BXbox2.Text = text2;
        }

        private void XCAxBx_Click(object sender, EventArgs e)
        {
            string text1 = AXbox1.Text;
            AXbox1.Text = BXbox1.Text;
            BXbox1.Text = text1;

            string text2 = AXbox2.Text;
            AXbox2.Text = BXbox2.Text;
            BXbox2.Text = text2;
        }

        private void MVAxCx_Click(object sender, EventArgs e)
        {
            string text1 = AXbox1.Text;
            CXbox1.Text = text1;

            string text2 = AXbox2.Text;
            CXbox2.Text = text2;
        }

        private void XCAxCx_Click(object sender, EventArgs e)
        {
            string text1 = AXbox1.Text;
            AXbox1.Text = CXbox1.Text;
            CXbox1.Text = text1;

            string text2 = AXbox2.Text;
            AXbox2.Text = CXbox2.Text;
            CXbox2.Text = text2;
        }

        private void MVAxDx_Click(object sender, EventArgs e)
        {
            string text1 = AXbox1.Text;
            DXbox1.Text = text1;

            string text2 = AXbox2.Text;
            DXbox2.Text = text2;
        }

        private void XCAxDx_Click(object sender, EventArgs e)
        {
            string text1 = AXbox1.Text;
            AXbox1.Text = DXbox1.Text;
            DXbox1.Text = text1;

            string text2 = AXbox2.Text;
            AXbox2.Text = DXbox2.Text;
            DXbox2.Text = text2;
        }

        private void MVBxAx_Click(object sender, EventArgs e)
        {
            string text1 = BXbox1.Text;
            AXbox1.Text = text1;

            string text2 = BXbox2.Text;
            AXbox2.Text = text2;
        }

        private void XCBxAx_Click(object sender, EventArgs e)
        {
            string text1 = BXbox1.Text;
            BXbox1.Text = AXbox1.Text;
            AXbox1.Text = text1;

            string text2 = BXbox2.Text;
            BXbox2.Text = AXbox2.Text;
            AXbox2.Text = text2;
        }

        private void MVBxCx_Click(object sender, EventArgs e)
        {
            string text1 = BXbox1.Text;
            CXbox1.Text = text1;

            string text2 = BXbox2.Text;
            CXbox2.Text = text2;
        }

        private void XCBxCx_Click(object sender, EventArgs e)
        {
            string text1 = BXbox1.Text;
            BXbox1.Text = CXbox1.Text;
            CXbox1.Text = text1;

            string text2 = BXbox2.Text;
            BXbox2.Text = CXbox2.Text;
            CXbox2.Text = text2;
        }

        private void MVBxDx_Click(object sender, EventArgs e)
        {
            string text1 = BXbox1.Text;
            DXbox1.Text = text1;

            string text2 = BXbox2.Text;
            DXbox2.Text = text2;
        }

        private void XCBxDx_Click(object sender, EventArgs e)
        {
            string text1 = BXbox1.Text;
            BXbox1.Text = DXbox1.Text;
            DXbox1.Text = text1;

            string text2 = BXbox2.Text;
            BXbox2.Text = DXbox2.Text;
            DXbox2.Text = text2;
        }

        private void MVCxAx_Click(object sender, EventArgs e)
        {
            string text1 = CXbox1.Text;
            AXbox1.Text = text1;

            string text2 = CXbox2.Text;
            AXbox2.Text = text2;
        }

        private void XCCxAx_Click(object sender, EventArgs e)
        {
            string text1 = CXbox1.Text;
            CXbox1.Text = AXbox1.Text;
            AXbox1.Text = text1;

            string text2 = CXbox2.Text;
            CXbox2.Text = AXbox2.Text;
            AXbox2.Text = text2;
        }

        private void MVCxBx_Click(object sender, EventArgs e)
        {
            string text1 = CXbox1.Text;
            BXbox1.Text = text1;

            string text2 = CXbox2.Text;
            BXbox2.Text = text2;
        }

        private void XCCxBx_Click(object sender, EventArgs e)
        {
            string text1 = CXbox1.Text;
            CXbox1.Text = BXbox1.Text;
            BXbox1.Text = text1;

            string text2 = CXbox2.Text;
            CXbox2.Text = BXbox2.Text;
            BXbox2.Text = text2;
        }

        private void MVCxDx_Click(object sender, EventArgs e)
        {
            string text1 = CXbox1.Text;
            DXbox1.Text = text1;

            string text2 = CXbox2.Text;
            DXbox2.Text = text2;
        }

        private void XCCxDx_Click(object sender, EventArgs e)
        {
            string text1 = CXbox1.Text;
            CXbox1.Text = DXbox1.Text;
            DXbox1.Text = text1;

            string text2 = CXbox2.Text;
            CXbox2.Text = DXbox2.Text;
            DXbox2.Text = text2;
        }

        private void MVDxAx_Click(object sender, EventArgs e)
        {
            string text1 = DXbox1.Text;
            AXbox1.Text = text1;

            string text2 = DXbox2.Text;
            AXbox2.Text = text2;
        }

        private void XCDxAx_Click(object sender, EventArgs e)
        {
            string text1 = DXbox1.Text;
            DXbox1.Text = AXbox1.Text;
            AXbox1.Text = text1;

            string text2 = DXbox2.Text;
            DXbox2.Text = AXbox2.Text;
            AXbox2.Text = text2;
        }

        private void MVDxBx_Click(object sender, EventArgs e)
        {
            string text1 = DXbox1.Text;
            BXbox1.Text = text1;

            string text2 = DXbox2.Text;
            BXbox2.Text = text2;
        }

        private void XCDxBx_Click(object sender, EventArgs e)
        {
            string text1 = DXbox1.Text;
            DXbox1.Text = BXbox1.Text;
            BXbox1.Text = text1;

            string text2 = DXbox2.Text;
            DXbox2.Text = BXbox2.Text;
            BXbox2.Text = text2;
        }

        private void MVDxCx_Click(object sender, EventArgs e)
        {
            string text1 = DXbox1.Text;
            CXbox1.Text = text1;

            string text2 = DXbox2.Text;
            CXbox2.Text = text2;
        }

        private void XCDxCx_Click(object sender, EventArgs e)
        {
            string text1 = DXbox1.Text;
            DXbox1.Text = CXbox1.Text;
            CXbox1.Text = text1;

            string text2 = DXbox2.Text;
            DXbox2.Text = CXbox2.Text;
            CXbox2.Text = text2;
        }

        private void checkBox_indeksowy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_indeksowy.Checked)
            {
                checkBox_SI.Enabled = true;
                checkBox_DI.Enabled = true;
            }
            else
            {
                checkBox_SI.Enabled = false;
                checkBox_DI.Enabled = false;
            }

            if (checkBox_indeksowy.Checked)
            {
                checkBox_indeksowoBazowy.Checked = false;
                checkBox_bazowy.Checked = false;

                checkBox_SI.Checked = false;
                checkBox_DI.Checked = false;

                checkBox_BP.Checked = false;
                checkBox_BX.Checked = false;

                checkBox_SI_BP.Checked = false;
                checkBox_SI_BX.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_DI_BX.Checked = false;
            }

            else
            {
                checkBox_indeksowoBazowy.Checked = false;
                checkBox_bazowy.Checked = false;

                checkBox_SI.Checked = false;
                checkBox_DI.Checked = false;

                checkBox_BP.Checked = false;
                checkBox_BX.Checked = false;

                checkBox_SI_BP.Checked = false;
                checkBox_SI_BX.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_DI_BX.Checked = false;
            }
        }

        private void checkBox_bazowy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bazowy.Checked)
            {
                checkBox_BX.Enabled = true;
                checkBox_BP.Enabled = true;
            }
            else
            {
                checkBox_BX.Enabled = false;
                checkBox_BP.Enabled = false;
            }

            if (checkBox_bazowy.Checked)
            {
                checkBox_indeksowy.Checked = false;
                checkBox_indeksowoBazowy.Checked = false;

                checkBox_SI.Checked = false;
                checkBox_DI.Checked = false;

                checkBox_BP.Checked = false;
                checkBox_BX.Checked = false;

                checkBox_SI_BP.Checked = false;
                checkBox_SI_BX.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_DI_BX.Checked = false;
            }

            else
            {
                checkBox_indeksowy.Checked = false;
                checkBox_indeksowoBazowy.Checked = false;

                checkBox_SI.Checked = false;
                checkBox_DI.Checked = false;

                checkBox_BP.Checked = false;
                checkBox_BX.Checked = false;

                checkBox_SI_BP.Checked = false;
                checkBox_SI_BX.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_DI_BX.Checked = false;
            }
        }

        private void checkBox_indeksowoBazowy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_indeksowoBazowy.Checked)
            {
                checkBox_SI_BP.Enabled = true;
                checkBox_SI_BX.Enabled = true;
                checkBox_DI_BP.Enabled = true;
                checkBox_DI_BX.Enabled = true;
            }
            else
            {
                checkBox_SI_BP.Enabled = false;
                checkBox_SI_BX.Enabled = false;
                checkBox_DI_BP.Enabled = false;
                checkBox_DI_BX.Enabled = false;
            }

            if (checkBox_indeksowoBazowy.Checked)
            {
                checkBox_indeksowy.Checked = false;
                checkBox_bazowy.Checked = false;

                checkBox_SI.Checked = false;
                checkBox_DI.Checked = false;

                checkBox_BP.Checked = false;
                checkBox_BX.Checked = false;

                checkBox_SI_BP.Checked = false;
                checkBox_SI_BX.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_DI_BX.Checked = false;
            }
            else
            {
                checkBox_indeksowy.Checked = false;
                checkBox_bazowy.Checked = false;

                checkBox_SI.Checked = false;
                checkBox_DI.Checked = false;

                checkBox_BP.Checked = false;
                checkBox_BX.Checked = false;

                checkBox_SI_BP.Checked = false;
                checkBox_SI_BX.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_DI_BX.Checked = false;
            }
        }

        private void checkBox_SI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SI.Checked)
            {
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();

                checkBox_DI.Checked = false;
                SIbox1.Enabled = true;
            }

            else
            {
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                SIbox1.Enabled = false;
            }
        }

        private void checkBox_DI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DI.Checked)
            {
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                checkBox_SI.Checked = false;
                DIbox1.Enabled = true;
            }
            
            else
            {
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                DIbox1.Enabled = false;
            }
        }

        private void checkBox_BX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_BX.Checked)
            {
                BXbox2.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                checkBox_BP.Checked = false;
                BXbox1.Enabled = true;
            }

            else
            {
                BXbox2.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();
            }
        }

        private void checkBox_BP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_BP.Checked)
            {
                checkBox_BX.Checked = false;
                BPbox1.Enabled = true;
            }

            else
            {
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                BPbox1.Enabled = false;
            }
        }

        private void checkBox_SI_BX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SI_BX.Checked)
            {
                BXbox2.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                checkBox_SI_BP.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_DI_BX.Checked = false;

                SIbox1.Enabled = true;
                DIbox1.Enabled = false;
                BPbox1.Enabled = false;
            }

            else
            {
                BXbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();

                DIbox1.Enabled = false;
                SIbox1.Enabled = false;
                BPbox1.Enabled = false;
            }
        }

        private void checkBox_DI_BX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DI_BX.Checked)
            {
                BXbox2.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                checkBox_SI_BP.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_SI_BX.Checked = false;

                DIbox1.Enabled = true;
                SIbox1.Enabled = false;
                BPbox1.Enabled = false;
            }

            else
            {
                BXbox2.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                DIbox1.Enabled = false;
                SIbox1.Enabled = false;
                BPbox1.Enabled = false;
            }
        }

        private void checkBox_SI_BP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SI_BP.Checked)
            {
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                checkBox_SI_BX.Checked = false;
                checkBox_DI_BP.Checked = false;
                checkBox_DI_BX.Checked = false;

                SIbox1.Enabled = true;
                BPbox1.Enabled = true;
                DIbox1.Enabled = false;
            }

            else
            {
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();

                DIbox1.Enabled = false;
                SIbox1.Enabled = false;
                BPbox1.Enabled = false;
            }
        }

        private void checkBox_DI_BP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DI_BP.Checked)
            {
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();

                checkBox_SI_BP.Checked = false;
                checkBox_SI_BX.Checked = false;
                checkBox_DI_BX.Checked = false;

                DIbox1.Enabled = true;
                BPbox1.Enabled = true;
                SIbox1.Enabled = false;
            }

            else
            {
                SIbox1.Clear();
                DIbox1.Clear();
                BPbox1.Clear();
                DISPbox1.Clear();
                SIbox2.Clear();
                DIbox2.Clear();
                BPbox2.Clear();
                DISPbox2.Clear();

                DIbox1.Enabled = false;
                SIbox1.Enabled = false;
                BPbox1.Enabled = false;
            }
        }

        private void checkBox_RdoP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RdoP.Checked)
                checkBox_PdoR.Checked = false;
        }

        private void checkBox_PdoR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PdoR.Checked)
            {
                checkBox_RdoP.Checked = false;

                checkBox_R_AX.Enabled = true;
                checkBox_R_BX.Enabled = true;
                checkBox_R_CX.Enabled = true;
                checkBox_R_DX.Enabled = true;
            }

            else
            {
                checkBox_R_AX.Enabled = false;
                checkBox_R_BX.Enabled = false;
                checkBox_R_CX.Enabled = false;
                checkBox_R_DX.Enabled = false;
            }
        }

        private void checkBox_R_AX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_R_AX.Checked)
            {
                checkBox_R_BX.Checked = false;
                checkBox_R_CX.Checked = false;
                checkBox_R_DX.Checked = false;
            }
        }

        private void checkBox_R_BX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_R_BX.Checked)
            {
                checkBox_R_AX.Checked = false;
                checkBox_R_CX.Checked = false;
                checkBox_R_DX.Checked = false;
            }
        }

        private void checkBox_R_CX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_R_CX.Checked)
            {
                checkBox_R_BX.Checked = false;
                checkBox_R_AX.Checked = false;
                checkBox_R_DX.Checked = false;
            }
        }

        private void checkBox_R_DX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_R_DX.Checked)
            {
                checkBox_R_BX.Checked = false;
                checkBox_R_CX.Checked = false;
                checkBox_R_AX.Checked = false;
            }
        }

        private void ResetButton2_Click(object sender, EventArgs e)
        {
            List<int> textBoxesLength = new List<int>();

            textBoxesLength.Add(SIbox1.Text.Length);
            textBoxesLength.Add(SIbox2.Text.Length);
            textBoxesLength.Add(DIbox1.Text.Length);
            textBoxesLength.Add(DIbox2.Text.Length);
            textBoxesLength.Add(BPbox1.Text.Length);
            textBoxesLength.Add(BPbox2.Text.Length);
            textBoxesLength.Add(DISPbox1.Text.Length);
            textBoxesLength.Add(DISPbox2.Text.Length);

            foreach (int Length in textBoxesLength)
            {
                if (Length > 0)
                {
                    SIbox1.Clear();
                    SIbox2.Clear();
                    DIbox1.Clear();
                    DIbox2.Clear();
                    BPbox1.Clear();
                    BPbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }
            }
        }

        private void RandomButtom2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            SIbox2.Clear();
            DIbox2.Clear();
            BPbox2.Clear();
            DISPbox2.Clear();

            if (checkBox_SI.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        SIbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        SIbox2.Text += random.Next(0, 9);
                    }
                }
            }

            else if (checkBox_DI.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        DIbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        DIbox2.Text += random.Next(0, 9);
                    }
                }
            }

            else if (checkBox_BP.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        BPbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        BPbox2.Text += random.Next(0, 9);
                    }
                }
            }

            else if (checkBox_BX.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        BXbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        BXbox2.Text += random.Next(0, 9);
                    }
                }
            }

            else if (checkBox_SI_BP.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        SIbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        SIbox2.Text += random.Next(0, 9);
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        BPbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        BPbox2.Text += random.Next(0, 9);
                    }
                }
            }

            else if (checkBox_DI_BP.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        DIbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        DIbox2.Text += random.Next(0, 9);
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        BPbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        BPbox2.Text += random.Next(0, 9);
                    }
                }
            }

            else if (checkBox_SI_BX.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        SIbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        SIbox2.Text += random.Next(0, 9);
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        BXbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        BXbox2.Text += random.Next(0, 9);
                    }
                }
            }

            else if (checkBox_DI_BX.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        DIbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        DIbox2.Text += random.Next(0, 9);
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    if (random.Next(0, 3) == 0)
                    {
                        BXbox2.Text += ((char)random.Next(65, 70)).ToString();
                    }

                    else
                    {
                        BXbox2.Text += random.Next(0, 9);
                    }
                }
            }


            for (int i = 0; i < 4; i++)
            {
                if (random.Next(0, 3) == 0)
                {
                    DISPbox2.Text += ((char)random.Next(65, 70)).ToString();
                }

                else
                {
                    DISPbox2.Text += random.Next(0, 9);
                }
            }
        }

        private void MOVbutton_2_Click(object sender, EventArgs e)
        {
            if (checkBox_PdoR.Checked)
            {
                if (checkBox_SI.Checked)
                {
                    if (SIbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (SIbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_DI.Checked)
                {
                    if (DIbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (DIbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_BP.Checked)
                {
                    if (BPbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(BPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (BPbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(BPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_BX.Checked)
                {
                    if (BXbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(BXbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (BXbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(BPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_SI_BX.Checked)
                {
                    if (SIbox1.Text != "" && BXbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BXbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (SIbox2.Text != "" && BXbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BXbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_DI_BX.Checked)
                {
                    if (DIbox1.Text != "" && BXbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BXbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (DIbox2.Text != "" && BXbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BXbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_SI_BP.Checked)
                {
                    if (SIbox1.Text != "" && BPbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (SIbox2.Text != "" && BPbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_DI_BP.Checked)
                {
                    if (DIbox1.Text != "" && BPbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (DIbox2.Text != "" && BPbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }

                }                
            }            
        }

        private void XCHGbutton2_Click(object sender, EventArgs e)
        {
            if (checkBox_PdoR.Checked)
            {
                if (checkBox_SI.Checked)
                {
                    if (SIbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (SIbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_DI.Checked)
                {
                    if (DIbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (DIbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_BP.Checked)
                {
                    if (BPbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(BPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (BPbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(BPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_BX.Checked)
                {
                    if (BXbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(BXbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (BXbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(BPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_SI_BX.Checked)
                {
                    if (SIbox1.Text != "" && BXbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BXbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;
                    }

                    if (SIbox2.Text != "" && BXbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BXbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;
                    }
                }

                if (checkBox_DI_BX.Checked)
                {
                    if (DIbox1.Text != "" && BXbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BXbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;

                        DIbox1.Clear();
                        BXbox1.Clear();
                        DISPbox1.Clear();
                    }

                    if (DIbox2.Text != "" && BXbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BXbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;

                        DIbox2.Clear();
                        BXbox2.Clear();
                        DISPbox2.Clear();
                    }
                }

                if (checkBox_SI_BP.Checked)
                {
                    if (SIbox1.Text != "" && BPbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;

                        SIbox1.Clear();
                        BPbox1.Clear();
                        DISPbox1.Clear();
                    }

                    if (SIbox2.Text != "" && BPbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(SIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;

                        SIbox2.Clear();
                        BPbox2.Clear();
                        DISPbox2.Clear();
                    }
                }

                if (checkBox_DI_BP.Checked)
                {
                    if (DIbox1.Text != "" && BPbox1.Text != "" && DISPbox1.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox1.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox1.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox1.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox1.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox1.Text = text1;

                        DIbox1.Clear();
                        BPbox1.Clear();
                        DISPbox1.Clear();
                    }

                    if (DIbox2.Text != "" && BPbox2.Text != "" && DISPbox2.Text != "")
                    {
                        int hexNum1 = int.Parse(DIbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum2 = int.Parse(BPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int hexNum3 = int.Parse(DISPbox2.Text, System.Globalization.NumberStyles.HexNumber);
                        int sum = hexNum1 + hexNum2 + hexNum3;
                        string text1 = Convert.ToString(sum, 16);

                        if (checkBox_R_AX.Checked)
                            AXbox2.Text = text1;
                        else if (checkBox_R_BX.Checked)
                            BXbox2.Text = text1;
                        else if (checkBox_R_CX.Checked)
                            CXbox2.Text = text1;
                        else if (checkBox_R_DX.Checked)
                            DXbox2.Text = text1;

                        DIbox2.Clear();
                        BPbox2.Clear();
                        DISPbox2.Clear();
                    }

                }
            }

            if(checkBox_RdoP.Checked)
            {
                if (checkBox_SI.Checked)
                {
                    SIbox1.Clear();
                    SIbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }

                if (checkBox_DI.Checked)
                {
                    DIbox1.Clear();
                    DIbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }

                if (checkBox_BX.Checked)
                {
                    BXbox1.Clear();
                    BXbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }

                if (checkBox_BP.Checked)
                {
                    BPbox1.Clear();
                    BPbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }

                if (checkBox_SI_BX.Checked)
                {
                    DIbox1.Clear();
                    DIbox2.Clear();
                    BXbox1.Clear();
                    BXbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }

                if (checkBox_SI_BP.Checked)
                {
                    DIbox1.Clear();
                    DIbox2.Clear();
                    BPbox1.Clear();
                    BPbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }

                if (checkBox_DI_BX.Checked)
                {
                    DIbox1.Clear();
                    DIbox2.Clear();
                    BXbox1.Clear();
                    BXbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }

                if (checkBox_DI_BP.Checked)
                {
                    DIbox1.Clear();
                    DIbox2.Clear();
                    BPbox1.Clear();
                    BPbox2.Clear();
                    DISPbox1.Clear();
                    DISPbox2.Clear();
                }
            }
        }
    }
}

