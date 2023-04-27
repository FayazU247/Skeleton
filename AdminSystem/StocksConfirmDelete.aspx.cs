﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(ProductID);
        Stock.Delete();
        Response.Redirect("StocksList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(ProductID);
        Stock.Delete();
        Response.Redirect("StocksList.aspx");
    }
}