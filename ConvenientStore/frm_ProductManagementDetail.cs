﻿using ConvenientStore.DTO;
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
    public partial class frm_ProductManagementDetail : Form
    {
        private ProductMangementDto ProductDetailDto { get; set; }
        private bool FlagSearchByDate { get; set; }
        private bool FlagViewDetail { get; set; }

        public frm_ProductManagementDetail(ProductMangementDto productDetalDto, bool flagViewDetail = false, bool flagSearchByDate = false)
        {
            InitializeComponent();

            this.ProductDetailDto = productDetalDto;
            this.FlagSearchByDate = flagSearchByDate;
            this.FlagViewDetail = flagViewDetail;
        }

        private void initForm()
        {

        }

        // Xử lý khi nhấn nút [Đặt hàng]
        private void clickBtnOrder(object sender, EventArgs e)
        {

        }

        // Xử lý khi nhấn nút [Xuất Excel]
        private void clickBtnExportExcell(object sender, EventArgs e)
        {

        }

        // Xử lý khi nhấn nút [Trở lại]
        private void clickBtnCancel(object sender, EventArgs e)
        {

        }
    }
}