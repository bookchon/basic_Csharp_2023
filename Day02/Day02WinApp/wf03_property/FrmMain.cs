using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf03_property
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GbxMain.Text = "컨트롤 학습";
            var fonts = FontFamily.Families.ToList(); // os 폰트이름 다 가져옴
            foreach (var font in fonts)
            {
                CboFontFamily.Items.Add(font.Name);
            }

            Nudfontsize.Minimum = 5;
            Nudfontsize.Value = 9;
            Nudfontsize.Minimum = 40;

            TxtResult.Text = "Hello, WinFoms.";

        }

        /// <summary>
        /// 글자 스타일, 크기, 글자체를 변경해주는 메서드
        /// </summary>
        private void ChangeFontStyle()
        {
            if (CboFontFamily.SelectedIndex < 0) return;

            FontStyle style = FontStyle.Regular; // 기본
            if (ChkBold.Checked == true)
            { 
                style |= FontStyle.Bold; // Bit 연산 or
            }
            if (ChkItalic.Checked == true)
            { 
                style |= FontStyle.Italic;
            }

            decimal fontSize = Nudfontsize.Value;

            TxtResult.Font = new Font((string)CboFontFamily.SelectedItem, (float)fontSize, style);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void Nudfontsize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void CboFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        //지울 때는 디자인 클릭 이벤트에 가서 딜리트 한다음에 엔터를 침 그럼 참조가 0개가 되어 삭제할 수 있게 됨
    }
}
