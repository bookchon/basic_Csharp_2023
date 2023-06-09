﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf12_notepad
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLord_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; // 여러파일 선택 안 되도록
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                TxtPath.Text = fileName;

                FileStream stream = null;
                StreamReader reader = null;

                try
                {
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // FileStream 쓰면 조금 더 다양한 옵션 처리 가능
                    reader = new StreamReader(stream, Encoding.UTF8);

                    // 전부 다 읽어오기
                    RtbEditor.Text = reader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류! {ex.Message}", "심플메모장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    reader.Close();
                    stream.Close();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string fileName = TxtPath.Text;

            FileStream stream = null;
            StreamWriter writer = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                writer = new StreamWriter(stream, Encoding.UTF8);

                writer.WriteLine(TxtPath.Text);
                writer.Flush(); // 버퍼의 데이터를 해당 스트림에 전송하는 일을 함

                MessageBox.Show("저장되었습니다", "심플메모장", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류! {ex.Message}", "심플메모장", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
        }

    }
}
