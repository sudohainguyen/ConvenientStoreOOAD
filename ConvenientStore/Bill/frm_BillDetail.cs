﻿using ConvenientStore.BUS;
using ConvenientStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenientStore
{
    public partial class frm_BillDetail : Form
    {
        public BillManagementDto BillManagementDto { get; set; }

        private List<BillDetailDto> billDetailDtos;
        private BillDetailBus bus;

        public frm_BillDetail(BillManagementDto dto)
        {
            InitializeComponent();

            this.BillManagementDto = dto;
            this.bus = new BillDetailBus();
            this.billDetailDtos = new List<BillDetailDto>();

            this.initForm();
        }

        private void initForm()
        {
            if(this.BillManagementDto == null)
            {
                this.Close();
            }

            this.txtBillCode.Text = this.BillManagementDto.Code();
            this.txtCustomerName.Text = this.BillManagementDto.CustomerName;
            this.txtCreateDate.Text = BillManagementDto.CreateDate;
            this.lbTotal.Text = BillManagementDto.Total;

            this.billDetailDtos = this.bus.GetAllBillDetail(Convert.ToInt32(this.BillManagementDto.Id));

            this.reloadDataGridView();
        }

        private void reloadDataGridView()
        {
            this.dgvListBillDetails.Rows.Clear();
            List<BillDetailDto> lists = this.billDetailDtos;

            for (int i = 0; i < this.billDetailDtos.Count; i++)
            {
                this.dgvListBillDetails.Rows.Add(i + 1, lists[i].ProductCode, lists[i].ProduceName,
                    lists[i].Price, lists[i].Quantity, lists[i].Unit, lists[i].Sale, lists[i].Total);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
