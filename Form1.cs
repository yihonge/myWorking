using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using APlayerHelperLib;
namespace myWorking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        APlayerHelper aPlayer;

        private void Form1_Load(object sender, EventArgs e)
        {
            aPlayer = new APlayerHelper(splitContainer1.Panel1.Handle, 0, 0, splitContainer1.Panel1.Width,
                splitContainer1.Panel1.Height);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aPlayer.Open("http://223.110.245.136/PLTV/3/224/3221226975/index.m3u8");
            //string file = "";
            //OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Title = "请选择要发送的文件";
            //if (DialogResult.OK == fileDialog.ShowDialog())
            //{
            //    //将选择的文件的全路径赋值给文本框
            //    file = fileDialog.FileName;
            //}
            //if (file == "") return;
            //aPlayer.Open(file);

            ////声音最大
            //aPlayer.SetVolume(100);

            ////设置循环播放
            //aPlayer.SetConfig(119, "1");
            ////设置图片背景透明
            //aPlayer.SetConfig(608, "0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text += "版本：" + aPlayer.GetVersion() + Environment.NewLine;
            //textBox1.Text += "119配置结果返回：" + aPlayer.GetConfig(119) + Environment.NewLine;
            //textBox1.Text += "608配置结果返回：" + aPlayer.GetConfig(608) + Environment.NewLine;
            //textBox1.Text += "获取url:" + aPlayer.GetConfig(4) + Environment.NewLine;
            //textBox1.Text += "视频尺寸：" + aPlayer.GetVideoWidth() + "*" + aPlayer.GetVideoHeight() + Environment.NewLine;
            //textBox1.Text += "Position:" + (aPlayer.GetPosition()).ToString() + Environment.NewLine;
            //textBox1.Text += "GetBufferProgress:" + (aPlayer.GetBufferProgress()).ToString() + Environment.NewLine;
            //textBox1.Text += "GetDuration:" + (aPlayer.GetDuration()).ToString() + Environment.NewLine;
        }
    }
}
