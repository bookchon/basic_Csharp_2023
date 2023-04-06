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
        Random rnd = new Random();

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
            Nudfontsize.Maximum = 40;

            TxtResult.Text = "Hello, WinFoms.";

        }

        /// <summary>
        /// 글자 스타일, 크기, 글자체를 변경해주는 메서드
        /// </summary>
        private void ChangeFontStyle()
        {
            if (CboFontFamily.SelectedIndex < 0)
            {
                CboFontFamily.SelectedIndex = 257; // 디폴트는 나눔고딕으로 지정
            }

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

            if (RdoNormal.Checked) // 라디오버튼 추가 이벤트
            {
                TxtResult.Text.Trim();
            }
            else if (RdoIndent.Checked)
            {
                TxtResult.Text = "    " + TxtResult.Text;
            }
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

        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PgbDummy.Value = TrbDummy.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form() {
                Text = "ModalForm",
                Width = 300,
                Height = 200,
                Left = 10,
                Top = 20,
                BackColor = Color.AliceBlue
            };
            frm.ShowDialog(); // 자식창 띄우기(모달방식)
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form()
            {
                Text = "NodalessForm",
                Width = 300,
                Height = 200,
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.GreenYellow
            };
            frm.Show(); // 자식창 띄우기(모달리스 방식)
        }
        // 기본적으로 MessageBox는 모달
        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(TxtResult.Text); // 기본
            // MessageBox.Show(TxtResult.Text, caption: "메세지 창"); // 캡션 다는 방법
            // MessageBox.Show(TxtResult.Text, "메세지 창", MessageBoxButtons.OK); // YesNoCancel도 가능
            // MessageBox.Show(TxtResult.Text, "메세지 창", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk); // 아이콘 추가
            // MessageBox.Show(TxtResult.Text, "메세지 창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                            // MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            // MessageBox.Show(text: TxtResult.Text, caption: "Custom", icon: MessageBoxIcon.Asterisk, 
                            // options: MessageBoxOptions.DefaultDesktopOnly);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void TrvDummy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(rnd.Next(45).ToString());
            TreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode != null)
            {
                TrvDummy.SelectedNode.Nodes.Add(rnd.Next(45, 100).ToString());
                TrvDummy.SelectedNode.Expand(); // 트리노드 하짲위 것들 펼쳐주기 (반대 - .Collpase())
                TreeToList();
            }
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear(); // 리스트뷰, 트리뷰 모든 아이템을 제거 및 초기화 해 주는 메서드
            foreach (var item in TrvDummy.Nodes)
            {
                TreeToList(item);
            }
        }

        private void TreeToList(TreeNode item)
        {
            LsvDummy.Items.Add(
                new ListViewItem(new[] { item.Text, item.FullPath.ToString() }));
            foreach (TreeNode node in item.Nodes)
            {
                TreeToList(node); // 재귀호출
            }
        }

        private void RdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void RdoIndent_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        //지울 때는 디자인 클릭 이벤트에 가서 딜리트 한다음에 엔터를 침 그럼 참조가 0개가 되어 삭제할 수 있게 됨
    }
}
