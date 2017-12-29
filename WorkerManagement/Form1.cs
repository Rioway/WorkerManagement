using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using Common;
using System.IO;

namespace WorkerManagement
{
    public partial class Form1 : Form
    {
        private string fileName = string.Empty;
        private string photoPath = string.Empty;
        private List<Worker> objListWorker = new List<Worker>();
        private List<Worker> objListQuery = new List<Worker>();
        private WorkerService objWorkerService = new WorkerService();
        private int actionFlag = 0; //标识1为添加，2为修改事件

        public Form1()
        {
            InitializeComponent();
            gboxDetail.Enabled = false;
        }

        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
    

    //控件事件
    private void btnImport_Click(object sender, EventArgs e)
        {
            //打开选择文件的窗体
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV文件(*.csv)|*.csv|TXT文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }

            //把文件读取到List中
            try
            {
                FileOperator objFile = new FileOperator();
                objListWorker = objFile.ReadFile(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取数据失败。具体原因：" + ex.Message, "系统消息:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //把读取的List展示在DataGridView中
            dgvWorker.DataSource = null;
            dgvWorker.AutoGenerateColumns = false;
            dgvWorker.DataSource = objListWorker;

            //展示某一个学生明细(默认展示第一行)
            Worker objWorker = objWorkerService.GetWorkerByWNum(dgvWorker.Rows[0].Cells[0].Value.ToString(), objListWorker);
            LoadDataToDetail(objWorker);
        }//导入数据
        private void dgvWorker_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWorker.Rows.Count == 0) return;
            else if (dgvWorker.CurrentRow.Selected == false) return;
            else
            {
                Worker objWorker = objWorkerService.GetWorkerByWNum(dgvWorker.CurrentRow.Cells[0].Value.ToString(), objListWorker);
                LoadDataToDetail(objWorker);
            }
        }  //选择行时数据发生变化
        private void txtQueryNum_TextChanged(object sender, EventArgs e)  //按照学号查询
        {
            objListQuery.Clear();

            objListQuery = objWorkerService.GetAllWorkerByWNum(txtQueryNum.Text.Trim(), objListWorker);
            dgvWorker.DataSource = null;
            dgvWorker.DataSource = objListQuery;
            if (objListQuery.Count != 0)
            {
                Worker objWorker = objWorkerService.GetWorkerByWNum(dgvWorker.Rows[0].Cells[0].Value.ToString(), objListWorker);
                LoadDataToDetail(objWorker);
            }
        }
        private void txtQueryName_TextChanged(object sender, EventArgs e)  //按照姓名查询
        {
            objListQuery.Clear();

            objListQuery = objWorkerService.GetAllWorkerByName(txtQueryName.Text.Trim(), objListWorker);
            dgvWorker.DataSource = null;
            dgvWorker.DataSource = objListQuery;
            if (objListQuery.Count != 0)
            {
                Worker objWorker = objWorkerService.GetWorkerByWNum(dgvWorker.Rows[0].Cells[0].Value.ToString(), objListWorker);
                LoadDataToDetail(objWorker);
            }
        }
        private void txtQueryMobile_TextChanged(object sender, EventArgs e)  //按照电话查询
        {
            objListQuery.Clear();

            objListQuery = objWorkerService.GetAllWorkerByMobile(txtQueryMobile.Text.Trim(), objListWorker);
            dgvWorker.DataSource = null;
            dgvWorker.DataSource = objListQuery;
            if (objListQuery.Count != 0)
            {
                Worker objWorker = objWorkerService.GetWorkerByWNum(dgvWorker.Rows[0].Cells[0].Value.ToString(), objListWorker);
                LoadDataToDetail(objWorker);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)  //添加学生信息
        {
            DisabledButton();
            txtNum.Text = string.Empty;
            txtName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            dtpInDay.Text = DateTime.Now.ToString();
            rbFemale.Checked = true;
            txtEmail.Text = string.Empty;
            txtPosition.Text = string.Empty;
            photo.BackgroundImage = null;

            txtNum.Focus();

            actionFlag = 1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)  //修改学生信息
        {
            DisabledButton();

            txtNum.Enabled = false;

            txtName.Focus();

            actionFlag = 2;
        }
        private void btnDelete_Click(object sender, EventArgs e)  //删除学生信息
        {
            if (dgvWorker.Rows.Count == 0) return;
            else if (dgvWorker.CurrentRow.Selected == false) return;
            else
            {
                Worker objWorker = objWorkerService.GetWorkerByWNum(dgvWorker.CurrentRow.Cells[0].Value.ToString(), objListWorker);
                string info = "是否确定删除学生【学号：" + objWorker.WNum + "姓名：" + objWorker.WName + "】的信息吗？";
                DialogResult result = MessageBox.Show(info, "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        objWorkerService.DeleteWorker(objWorker, objListWorker);

                        MessageBox.Show("删除成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //刷新数据
                        dgvWorker.DataSource = null;
                        dgvWorker.DataSource = objListWorker;
                        LoadDataToDetail(objListWorker[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败！" +ex.Message , "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else return;
            }
        }
        private void btnCommit_Click(object sender, EventArgs e)  //提交，完成添加或修改
        {
            //验证数据是否有效(面向对象--静态类)
            if (!ValidataInfo()) return;

            //封装：提交到List中的是Worker类，把所有的单元格的类封装成Worker对象
            Worker objworker = new Worker
            {
                WNum = txtNum.Text.Trim(),
                WName = txtName.Text.Trim(),
                Mobile = txtMobile.Text.Trim(),
                InDay = Convert.ToDateTime(dtpInDay.Text),
                Gender = rbMale.Checked == true ? "男" : "女",
                Email = txtEmail.Text.Trim(),
                Position = txtPosition.Text.Trim(),
                PhotoPath = null,
            };
            //图片另存到指定路径
            if (photo.BackgroundImage != null)
                objworker.PhotoPath = PhotoSave(photoPath);

            switch (actionFlag)
            {
                case 1:
                    try
                    {
                        objWorkerService.AddWorker(objworker, objListWorker);

                        MessageBox.Show("添加成功。" , "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancel_Click(null, null);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("添加失败，具体原因：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
                case 2:
                    try
                    {
                        objWorkerService.UpdateWorker(objworker, objListWorker);

                        MessageBox.Show("修改成功。", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNum.Enabled = true;
                        btnCancel_Click(null, null);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("添加失败，具体原因：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)  //取消
        {
            EnabledButton();
            this.dgvWorker.DataSource = null;
            this.dgvWorker.DataSource = objListWorker;

            if (objListWorker.Count != 0)
            {
                Worker objWorker = objWorkerService.GetWorkerByWNum(dgvWorker.Rows[0].Cells[0].Value.ToString(), objListWorker);
                LoadDataToDetail(objWorker);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("程序关闭，是否保存数据?", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //清空
                File.WriteAllText(fileName, string.Empty);

                //逐行写入(吧objListWorker逐行写入)
                StreamWriter sw = new StreamWriter(fileName, true, Encoding.Default);
                string line = string.Empty;
                foreach (Worker item in objListWorker)
                {
                    line = item.WNum + "," + item.WName + "," + item.InDay.ToString("yyyy/MM/dd") + 
                        "," + item.Position + "," + item.Mobile + "," + item.Email + "," + item.PhotoPath + "," + item.Gender;
                    sw.WriteLine(line);
                }
                sw.Close();
                //显示保存成功
                MessageBox.Show("保存成功。", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            this.Close();
        }  //关闭窗体
        private void btnChoose_Click(object sender, EventArgs e)  //选择照片
        {
            //选择窗体
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "图片|*.png;*.jpg;*.bmp";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                photoPath = openFile.FileName;

                photo.BackgroundImage = Image.FromFile(photoPath);
            }
            //显示图片
        }

        //自定义方法
        private void LoadDataToDetail(Worker objWorker)
        {
            txtNum.Text = objWorker.WNum;
            txtName.Text = objWorker.WName;
            if (objWorker.Gender == "男") rbFemale.Checked = true;
            else rbMale.Checked = true;
            dtpInDay.Text = objWorker.InDay.ToString();
            txtPosition.Text = objWorker.Position;
            txtMobile.Text = objWorker.Mobile;
            txtEmail.Text = objWorker.Email;
            if (string.IsNullOrWhiteSpace(objWorker.PhotoPath))
            {
                photo.BackgroundImage = null;
            }
            else
            {
                photo.BackgroundImage = Image.FromFile(objWorker.PhotoPath);
            }


        }
        private void DisabledButton()
        {
            //禁用
            btnAdd.Enabled = false;
            btnImport.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            gboxDetail.Enabled = true;
        }
        private void EnabledButton()
        {
            //禁用
            btnAdd.Enabled = true;
            btnImport.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            gboxDetail.Enabled = false;
        }
        private bool ValidataInfo()
        {
            bool b = true;
            //学号不能为空
            if(string.IsNullOrWhiteSpace(txtNum.Text))
            {
                MessageBox.Show("工号不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum.Focus();
                return false;
            }
            //学号必须是五位数
            if(!ValidataInput.IsWNum(txtNum.Text))
            {
                MessageBox.Show("工号必须是10开头的5位数！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum.Focus();
                return false;
            }
            //学号不能重复
            if(actionFlag == 1)
            {
                if (objWorkerService.IsExistWNum(txtNum.Text.Trim(), objListWorker))
                {
                    MessageBox.Show("工号已经存在，请重新输入！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNum.Focus();
                    return false;
                }
            }        
            //姓名不能为空
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("姓名不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            //日期是否满足当前系统时间
            if (Convert.ToDateTime(dtpInDay.Text) > DateTime.Now)
            {
                MessageBox.Show("日期不能大于当前时间！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            //手机号码是否为十一位数字
            if (ValidataInput.IsMobile(txtMobile.Text))
            {
                MessageBox.Show("手机号码必须是11位数，1开头！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMobile.Focus();
                return false;
            }
            //邮箱地址是否合理
            if (!ValidataInput.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("邮箱格式不正确！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            return b;
        }
        private string PhotoSave(string currentPhotoPath)
        {
            //生成16位名称图片名称
            string photoName = BuildName.BuildPhotoName(currentPhotoPath);
            //产生路径
            photoName = ".\\image\\" + photoName;
            //存储图片
            Bitmap objBitMap = new Bitmap(photo.BackgroundImage);
            objBitMap.Save(photoName, photo.BackgroundImage.RawFormat);
            objBitMap.Dispose();

            return photoName;
        }


    }
}
