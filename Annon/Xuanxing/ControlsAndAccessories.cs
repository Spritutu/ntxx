﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityFrameworkTryBLL.XuanxingManager;
using Model.Device;

namespace Annon.Xuanxing
{
    public partial class ControlsAndAccessories : Form
    {

        public int orderID;
        private int accessoryOrderID;

        public ControlsAndAccessories()
        {
            InitializeComponent();
            hideDataGridView1Column("SubBase");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomLineItems customLineItems = new CustomLineItems(this);
            customLineItems.OrderId = orderID;
            customLineItems.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text=comboBox1.Text;
            switch (text)
            {
                case "SubBase":
                {
                    btnTheme.Text = text;
                    hideDataGridView1Column(text);
                }break;
                case "Themostats":
                 {
                        btnTheme.Text = text;
                        hideDataGridView1Column(text);
                        
                 } break;
                case "Additional Control Accessories":
                 {
                        btnTheme.Text = text;
                        hideDataGridView1Column(text);
                 } break;
                case "Additional Curb Accessories":
                 {
                        btnTheme.Text = text;
                        hideDataGridView1Column(text);
                 } break;
                case "Optional Accessories":
                 {
                        btnTheme.Text = text;
                        hideDataGridView1Column(text);
                 } break;
            }
        }

        public void hideDataGridView1Column(string text)
        {
            switch (text)
            {
                case "SubBase":
                    {
                        recoveryDataGridViewColumn();
                        dataGridView1.Columns["TDescription"].Visible = false;
                        dataGridView1.Columns["THeat"].Visible = false;
                        dataGridView1.Columns["TCool"].Visible = false;
                        dataGridView1.Columns["TApplication"].Visible = false;
                        dataGridView1.Columns["TChangeOver"].Visible = false;
                        dataGridView1.Columns["TUsewSubbase"].Visible = false;

                        dataGridView1Bingding(text);

                    } break;
                case "Themostats":
                    {
                        recoveryDataGridViewColumn();
                        dataGridView1.Columns["TSystemSwitching"].Visible = false;
                        dataGridView1.Columns["TFanSwitching"].Visible = false;
                        dataGridView1.Columns["TDescription"].Visible = false;
                        dataGridView1.Columns["TUsewThemostat"].Visible = false;
                        dataGridView1Bingding(text);

                    } break;
                case "Additional Control Accessories":
                    {
                        recoveryDataGridViewColumn();
                        dataGridView1.Columns["TSystemSwitching"].Visible = false;
                        dataGridView1.Columns["TFanSwitching"].Visible = false;
                        dataGridView1.Columns["THeat"].Visible = false;
                        dataGridView1.Columns["TCool"].Visible = false;
                        dataGridView1.Columns["TApplication"].Visible = false;
                        dataGridView1.Columns["TChangeOver"].Visible = false;
                        dataGridView1.Columns["TUsewSubbase"].Visible = false;
                        dataGridView1.Columns["TUsewThemostat"].Visible = false;
                        dataGridView1Bingding(text);
                    } break;
                case "Additional Curb Accessories":
                    {
                        recoveryDataGridViewColumn();
                        dataGridView1.Columns["TSystemSwitching"].Visible = false;
                        dataGridView1.Columns["TFanSwitching"].Visible = false;
                        dataGridView1.Columns["THeat"].Visible = false;
                        dataGridView1.Columns["TCool"].Visible = false;
                        dataGridView1.Columns["TApplication"].Visible = false;
                        dataGridView1.Columns["TChangeOver"].Visible = false;
                        dataGridView1.Columns["TUsewSubbase"].Visible = false;
                        dataGridView1.Columns["TUsewThemostat"].Visible = false;
                        dataGridView1.Columns["TModel"].Visible = false;
                        dataGridView1Bingding(text);
                    } break;
                case "Optional Accessories":
                    {
                        recoveryDataGridViewColumn();
                        dataGridView1.Columns["TSystemSwitching"].Visible = false;
                        dataGridView1.Columns["TFanSwitching"].Visible = false;
                        dataGridView1.Columns["THeat"].Visible = false;
                        dataGridView1.Columns["TCool"].Visible = false;
                        dataGridView1.Columns["TApplication"].Visible = false;
                        dataGridView1.Columns["TChangeOver"].Visible = false;
                        dataGridView1.Columns["TUsewSubbase"].Visible = false;
                        dataGridView1.Columns["TUsewThemostat"].Visible = false;
                        dataGridView1Bingding(text);
                    } break;
            }
        }

        public void recoveryDataGridViewColumn()
        {
            foreach (var column in dataGridView1.Columns)
            {
                DataGridViewColumn eachColumn = (DataGridViewColumn)column;
                eachColumn.Visible = true;
            }
        }

        public void dataGridView1Bingding(string text)
        {
            dataGridView1.DataSource = AccessoryBLL.getAccessories(text);
        }

        public void dataGridView2Binding(int orderID)
        {
            
            dataGridView2.DataSource = AccessoryBLL.getAccessoryOrders(orderID);
            dataGridView2.AutoGenerateColumns = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AccessoryBLL.modifyOrder(accessoryOrderID,Convert.ToInt32(textBox1.Text));
            dataGridView2Binding(orderID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count>0)
            AccessoryBLL.deleteOrder(accessoryOrderID);
            if(dataGridView2.Rows.Count>0)
            accessoryOrderID =Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            accessoryOrderID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["AccessoryOrderID"].Value);

            //AccessoryBLL.deleteOrder(accessoryOrderID);
            //dataGridView2.DataSource = AccessoryBLL.getAccessoryOrders(orderID);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1TodataGridView2Column(comboBox1.Text,e.RowIndex);
         
        }

        public void dataGridView1TodataGridView2Column(string text,int rowIndex)
        {
            switch (text)
            {
                case "SubBase":
                    {
                        AccessoryBLL.insertIntoAccessoryOrder(orderID, dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), 1, 100);
                        
                        dataGridView2.DataSource = AccessoryBLL.getAccessoryOrders(orderID);
                       
                        

                    } break;
                case "Themostats":
                    {
                        AccessoryBLL.insertIntoAccessoryOrder(orderID, dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), 1, 100);

                        dataGridView2.DataSource = AccessoryBLL.getAccessoryOrders(orderID);

                    } break;
                case "Additional Control Accessories":
                    {
                        AccessoryBLL.insertIntoAccessoryOrder(orderID, dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), 1, 100);

                        dataGridView2.DataSource = AccessoryBLL.getAccessoryOrders(orderID);
                    } break;
                case "Additional Curb Accessories":
                    {
                        AccessoryBLL.insertIntoAccessoryOrder(orderID, dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), 1, 100);

                        dataGridView2.DataSource = AccessoryBLL.getAccessoryOrders(orderID);
                    } break;
                case "Optional Accessories":
                    {
                        AccessoryBLL.insertIntoAccessoryOrder(orderID, dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), dataGridView1.Rows[rowIndex].Cells["TPartNo"].ToString(), 1, 100);

                        dataGridView2.DataSource = AccessoryBLL.getAccessoryOrders(orderID);
                    } break;
            }
        }
    }
}
