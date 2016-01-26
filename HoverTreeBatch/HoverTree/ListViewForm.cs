using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HoverTree.Batch
{
    public partial class ListViewForm : Form
    {
        public ListViewForm()
        {
            InitializeComponent();
            DoBindDataSource();
        }

        FileInfo[] _files=null;
        DirectoryInfo _TheFolder;

        private void button_ok_Click(object sender, EventArgs e)
        {
            string h_selectPath;
            if (folderBrowserDialog_hvt.ShowDialog() == DialogResult.OK)
            {
                h_selectPath = folderBrowserDialog_hvt.SelectedPath;

                textBox_folder.Text = h_selectPath;

                 _TheFolder = new DirectoryInfo(h_selectPath);

                BindContent();
            }
                
        }

        //显示文件夹中的内容
        void BindContent()
        {

                listView_hoverTree.Clear();

                
                listView_hoverTree.BeginUpdate(); //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

                //listView_hoverTree.View = View.Details;//设置视图  
                //listView_hoverTree.SmallImageList = imageList;//设置图标 

                //添加列  
                listView_hoverTree.Columns.Add("名称", 500, HorizontalAlignment.Left);
                listView_hoverTree.Columns.Add("路径", 500, HorizontalAlignment.Left);

                _files = _TheFolder.GetFiles();
                foreach (FileInfo fi in _files)//遍历文件夹下所有文件
                {
                    var h_item = new ListViewItem();
                    h_item.ImageIndex = 0;
                    h_item.Text = fi.Name;
                    h_item.SubItems.Add(fi.FullName);
                    //添加行  
                    listView_hoverTree.Items.Add(h_item);
                }
                listView_hoverTree.EndUpdate();//结束数据处理，UI界面一次性绘制。 

        }

        private void button_rename_Click(object sender, EventArgs e)
        {
            if (listView_hoverTree.Items.Count < 1)
            {
                MessageBox.Show("请选择文件夹");
                return;
            }

            if (!(MessageBox.Show("是否重命名文件名？", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                return;
            }
            List<string> h_suffixList = new List<string>();
            Dictionary<string, int> h_suffixIndex = new Dictionary<string, int>();

            if (_files != null)
            {
                switch (comboBox_operationType.SelectedValue.ToString())
                {
                    case "1":
                        //加前缀
                        foreach (FileInfo fi in _files)
                        {
                            string h_newFielName = fi.DirectoryName + "\\" + textBox_text.Text.Trim() + fi.Name;

                            fi.MoveTo(h_newFielName);
                        }
                            break;
                    case "2":
                        //加后缀
                        foreach (FileInfo fi in _files)
                        {
                            HoverTreeAddSuffix(fi, textBox_text.Text);
                        }
                        break;
                    case "3":
                        //用数字序号重命名
                        foreach (FileInfo fi in _files)
                        {
                            if (h_suffixList.Contains(fi.Extension))
                            {
                                h_suffixIndex[fi.Extension] = h_suffixIndex[fi.Extension] + 1;
                            }
                            else
                            {
                                h_suffixList.Add(fi.Extension);
                                h_suffixIndex.Add(fi.Extension, 1);
                            }
                            string h_newFielName = fi.DirectoryName + "\\" + textBox_text.Text.Trim() + h_suffixIndex[fi.Extension].ToString() + fi.Extension;

                            fi.MoveTo(h_newFielName);
                        }
                        break;
                }

                BindContent();
            }
        }

        /// <summary>
        /// 给文件加后缀
        /// </summary>
        /// <param name="fi"></param>
        /// <param name="suffix"></param>
        void HoverTreeAddSuffix(FileInfo fi,string suffix)
        {
            string h_newFielName = fi.DirectoryName + "\\" + Regex.Replace(fi.Name, @"\" + fi.Extension + "$", "", RegexOptions.IgnoreCase) + suffix + fi.Extension;

            fi.MoveTo(h_newFielName);
        }

        /// <summary>
        /// 绑定comboBox
        /// </summary>
        private void DoBindDataSource()
        {
            //构造数据源（或从数据库中查询）  
            DataTable ADt = new DataTable();
            DataColumn ADC1 = new DataColumn("F_ID", typeof(int));
            DataColumn ADC2 = new DataColumn("F_Name", typeof(string));
            ADt.Columns.Add(ADC1);
            ADt.Columns.Add(ADC2);

            DataRow h_ADR1 = ADt.NewRow();
            h_ADR1[0] = 1;
            h_ADR1[1] = "加前缀";
            ADt.Rows.Add(h_ADR1);

             h_ADR1 = ADt.NewRow();
            h_ADR1[0] = 2;
            h_ADR1[1] = "加后缀";
            ADt.Rows.Add(h_ADR1);

            h_ADR1 = ADt.NewRow();
            h_ADR1[0] = 3;
            h_ADR1[1] = "用数字重命名";
            ADt.Rows.Add(h_ADR1);

            //进行绑定  
            comboBox_operationType.DisplayMember = "F_Name";//控件显示的列名  
            comboBox_operationType.ValueMember = "F_ID";//控件值的列名  
            comboBox_operationType.DataSource = ADt;

            if ( GetType().FullName== "HoverTree.Batch.ListViewForm")
                button_rename.Click += new EventHandler(this.button_rename_Click);
        }
    }
}