﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    EntityOgrenci ent = new EntityOgrenci();
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OgrId"].ToString());
        txtid.Text = x.ToString();
        txtid.Enabled = false;

        if (Page.IsPostBack==false)
        {

            List<EntityOgrenci> OgrList = BLLOgrenci.BLLDetay(x);
            TxtAd.Text = OgrList[0].AD.ToString();
            TxtSoyad.Text = OgrList[0].SOYAD.ToString();
            TxtNumara.Text = OgrList[0].NUMARA.ToString();
            TxtFotograf.Text = OgrList[0].FOTOGRAF.ToString();
            TxtSifre.Text = OgrList[0].SIFRE.ToString();
        }

    }

    protected void btnguncelle_Click(object sender, EventArgs e)
    {
        ent.AD = TxtAd.Text;
        ent.SOYAD = TxtSoyad.Text;
        ent.SIFRE = TxtSifre.Text;
        ent.NUMARA = TxtNumara.Text;
        ent.FOTOGRAF = TxtFotograf.Text;
        ent.ID = Convert.ToInt32(txtid.Text);
        BLLOgrenci.OgrenciGuncelleBLL(ent);
        Response.Redirect("OgrenciListesi.aspx");
    }
}