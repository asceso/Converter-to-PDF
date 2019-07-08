using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Converter
{
    public partial class MainForm : Form
    {
        List<string> ImgPaths = new List<string>();
        List<int> SelectedPosition = new List<int>();
        string FileName;
        public MainForm()
        {
            InitializeComponent();
        }
        void DrawImage(XGraphics gfx, string Path, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(Path);
            gfx.DrawImage(image, x, y, width, height);
        }
        private void CreatePDFButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileName = FileNameBox.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Доб", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = FileName;
            string tempPath = null;
            if (ImgPaths.Count > 0)
            {
                foreach (string file in ImgPaths)
                {
                    PdfPage page = doc.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, file, 0, 0, (int)page.Width, (int)page.Height);
                }
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF доумент (*.pdf)|*.pdf";
                    string tempName = FileNameBox.Text;
                    saveFileDialog.FileName = tempName;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        tempPath = saveFileDialog.FileName;
                    }
                }
                doc.Save(tempPath);
                Process.Start(tempPath);
            }
            else
            {
                MessageBox.Show("Необходимо добавить минимум 1 изображение","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void AddToCollectionButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
                openFileDialog.Filter = "Изображения (*.jpg)|*.jpg|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Получить путь изображений
                    foreach (string name in openFileDialog.FileNames)
                    {
                        filePath = name;
                        //добавляем в коллекцию
                        ImgPaths.Add(filePath);
                        ImageCollectionList.Items.Add(filePath);
                    }
                }
            }
        }
        private void RemoveFromCollectionButton_Click(object sender, EventArgs e)
        {
            string selectedName = null;
            selectedName = ImageCollectionList.SelectedItem.ToString();
            ImgPaths.Remove(selectedName);
            ImageCollectionList.Items.Remove(ImageCollectionList.SelectedItem);
        }
        private void UpPosition_Click(object sender, EventArgs e)
        {
            ChangePosition(ImageCollectionList, ImgPaths, true,SelectedPosition.ToArray());
        }
        private void DownPosition_Click(object sender, EventArgs e)
        {
            ChangePosition(ImageCollectionList, ImgPaths, false, SelectedPosition.ToArray());
        }
        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            ImgPaths.Clear();
            ImageCollectionList.Items.Clear();
        }
        void Swap(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }
        private void ImageCollectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPosition.Clear();
            for (int i = 0; i < ImageCollectionList.Items.Count; i++)
            {
                if (ImageCollectionList.GetSelected(i))
                    SelectedPosition.Add(i);
            }
        }
        void ChangePosition(ListBox lists, List<string> images, bool Way,int[] CurrentPosition) // true - up / false - down
        {
            string[] tempList = new string[lists.Items.Count];
            string[] tempImages = new string[images.Count];
            int[] NewPosition = new int[CurrentPosition.Length];
            lists.Items.CopyTo(tempList, 0);
            images.CopyTo(tempImages, 0);
            switch (Way)
            {
                case true:
                    {
                        if (CurrentPosition[CurrentPosition.Length-1] == CurrentPosition.Length-1)
                        {
                            for (int i = 0; i < NewPosition.Length; i++)
                            { NewPosition[i] = CurrentPosition[i]; }
                        }
                        else
                        {
                            for (int i = 0; i < NewPosition.Length; i++)
                            {
                                if (CurrentPosition[i] > 0)
                                    NewPosition[i] = CurrentPosition[i] - 1;
                            }
                            for (int i = 0; i < NewPosition.Length; i++)
                            {
                                try
                                {
                                    Swap(ref tempList[CurrentPosition[i]], ref tempList[NewPosition[i]]);
                                    Swap(ref tempImages[CurrentPosition[i]], ref tempImages[NewPosition[i]]);
                                }
                                catch (Exception) { }
                            }
                        }
                    }
                    break;
                case false:
                    {
                        if (CurrentPosition[0] == ImageCollectionList.Items.Count - CurrentPosition.Length)
                        {
                            for (int i = 0; i < NewPosition.Length; i++)
                            {
                                NewPosition[i] = CurrentPosition[i];
                            }
                        }
                        else
                        {
                            for (int i = 0; i < NewPosition.Length; i++)
                            {
                                if (CurrentPosition[i] < lists.Items.Count - 1)
                                    NewPosition[i] = CurrentPosition[i] + 1;
                                else NewPosition[i] = lists.Items.Count - 1;
                            }
                            for (int i = NewPosition.Length - 1; i >= 0; i--)
                            {
                                try
                                {
                                    Swap(ref tempList[CurrentPosition[i]], ref tempList[NewPosition[i]]);
                                    Swap(ref tempImages[CurrentPosition[i]], ref tempImages[NewPosition[i]]);
                                }
                                catch (Exception) { }
                            }
                        }
                    }
                    break;
            }
            lists.Items.Clear();
            foreach (string item in tempList)
            {
                lists.Items.Add(item);
            }
            images.Clear();
            foreach (string item in tempImages)
            {
                images.Add(item);
            }
            for (int i = 0; i < NewPosition.Length; i++)
            {
                try
                {
                    lists.SetSelected(NewPosition[i], true);
                }
                catch (Exception ) { }
            }
        }

        private void ImageCollectionList_DragDrop(object sender, DragEventArgs e)
        {
            
        }
    }
}
