﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ImagePixelMover
{
    public partial class Form1 : Form
    {        
        private List<string> selectedFileNames;
        private string savePath;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기 저장 위치는 바탕화면 path
            savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            savePathBox.Text = savePath;
        }

        /// <summary>
        /// 이미지 불러오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoadImageClicked(object sender, EventArgs e)
        {
            // 파일 선택창을 띄움
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Multiselect = true;
            dialog.IsFolderPicker = false;
            // 파일선택 완료 시 다음 함수로 전달
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                OnFilesSelectComplete(dialog);
            }
        }

        /// <summary>
        /// 파일 선택 완료시 호출
        /// </summary>
        /// <param name="dialog"></param>
        private void OnFilesSelectComplete(CommonOpenFileDialog dialog)
        {            
            Image img = null;
            // 불러올떄마다 초기화X -> 초기화는 따로 버튼으로 뺌
            ////imagePathListView.Clear();
            imagePathListView.View = View.List;

            try
            {
                List<string> newSeletedFileNames = new List<string>();
                newSeletedFileNames = dialog.FileNames.ToList();
                if (newSeletedFileNames == null || newSeletedFileNames.Count <= 0)
                {
                    MessageBox.Show("선택된 파일이 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < newSeletedFileNames.Count; i++)
                {
                    imageList1.Images.Add(Image.FromFile(newSeletedFileNames[i]));
                }

                // 첫번째 이미지만 불러오기
                img = Image.FromFile(newSeletedFileNames[0]);
                // 불러온 첫번째 이미지 객체를 복사해서 크게보기 PictureBox에 넣음
                ImagePictureBox.Image = (Image)img.Clone();
                
                for (int i = 0; i < newSeletedFileNames.Count; i++)
                {
                    ListViewItem item = new ListViewItem(newSeletedFileNames[i], i);
                    imagePathListView.Items.Add(item);
                }

                // 기존 불러온 이미지 경로 리스트에 이어서 추가
                if (selectedFileNames == null)
                    selectedFileNames = newSeletedFileNames;
                else
                    selectedFileNames.AddRange(newSeletedFileNames);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                img.Dispose();
            }
        }

        /// <summary>
        /// 이미지 주소 리스트에서 새로운 이미지가 선택됐을 때
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnImagePathListItemSelected(object sender, EventArgs e)
        {
            if (imagePathListView.SelectedItems.Count <= 0)
                return;
            string path = imagePathListView.SelectedItems[0].Text;
            Image img = null;

            try
            {
                img = Image.FromFile(path);

                // 이미지 객체를 복사해서 크게보기 PictureBox에 넣음
                ImagePictureBox.Image = (Image)img.Clone();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (img != null)
                    img.Dispose();
            }
        }

        /// <summary>
        /// 픽셀 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMovePixelButtonClicked(object sender, EventArgs e)
        {
            if(selectedFileNames == null || selectedFileNames.Count <= 0)
            {
                MessageBox.Show("이미지를 먼저 불러와주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int moveX = (int)numericUpDown_movePixel_X.Value;
            // y축은 확인해보니 양수면 아래로 보내고 음수면 위로 보냄 따라서 반전시켜줌
            int moveY = (int)numericUpDown_movePixel_Y.Value * -1;

            for (int i = 0; i < selectedFileNames.Count; i++)
            {
                string path = selectedFileNames[i];

                Bitmap originBmp = new Bitmap(path);
                Bitmap newBmp = new Bitmap(path);
                // 모든 픽셀을 돌면서 이동시킴
                for (int y = 0; y < originBmp.Height; y++)
                {
                    for (int x = 0; x < originBmp.Width; x++)
                    {
                        // 범위를 초과한 경우 continue
                        if ((y + moveY) >= originBmp.Height)
                            continue;
                        if ((y + moveY) < 0)
                            continue;
                        if ((x + moveX) >= originBmp.Width)
                            continue;
                        if ((x + moveX) < 0)
                            continue;

                        newBmp.SetPixel(x + moveX, y + moveY, originBmp.GetPixel(x, y));
                    }
                }

                string fileName = Path.GetFileNameWithoutExtension(path);
                string savePath = Path.Combine(savePathBox.Text, fileName + ".png");
                FileInfo fi = new FileInfo(savePath);
                // 같은 이름의 파일이 경로에 존재한다면
                if(fi.Exists)
                {
                    int duplicateIndex = 0;
                    while (fi.Exists)
                    {
                        savePath = Path.Combine(savePathBox.Text, string.Format(fileName + "({0})" + ".png", duplicateIndex));
                        fi = new FileInfo(savePath);
                        duplicateIndex++;
                    }
                }

                newBmp.Save(fi.FullName, ImageFormat.Png);
            }

            MessageBox.Show("이미지 저장 완료", "완료!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 저장 경로 선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePathButtonClicked(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            // 파일선택 완료 시 다음 함수로 전달
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                savePath = dialog.FileName;
                savePathBox.Text = savePath;
            }
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            if (MessageBox.Show("불러온 이미지들을 초기화 하시겠습니까?", "초기화", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                imagePathListView.Clear();
                if(selectedFileNames != null)
                    selectedFileNames.Clear();
            }
        }
    }
}
