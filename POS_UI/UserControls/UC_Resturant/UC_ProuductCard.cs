﻿using POS_UI.Models.Product;

namespace POS_UI.UserControls;

public partial class UC_ProuductCard : UserControl
{
    public event EventHandler ProductClicked;

    private ProductResponse _product;

    public ProductResponse Product
    {
        get { return _product; }
        set
        {
            _product = value;
            InitData();
        }
    }

    public UC_ProuductCard(ProductResponse product = null!)
    {
        InitializeComponent();
        Product = product;
        pictureItem.Click += pictureItem_Click!;
    }

    private void InitData()
    {
        if (Product != null)
        {
            labelNameItem.Text = Product.Name;
            labelPriceItem.Text = Product.Price.ToString();
        }
    }

    private void pictureItem_Click(object sender, EventArgs e)
    {
        ProductClicked?.Invoke(this, EventArgs.Empty);
    }
}