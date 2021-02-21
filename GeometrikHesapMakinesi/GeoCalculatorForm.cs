using GeometrikHesapMakinesi.Abstract_Classes;
using GeometrikHesapMakinesi.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometrikHesapMakinesi
{
    public partial class GeoCalculatorForm : Form
    {

        public GeoCalculatorForm()
        {
            InitializeComponent();

        }
        private void checkboxSelect(string selectedCB)
        {
            foreach (Control ctrl in gbSekiller.Controls)
            {
                if (ctrl.Name != selectedCB)
                {
                    CheckBox cb = (CheckBox)ctrl;
                    cb.Checked = false;
                }
            }
        }
        private void CBEU_CheckedChanged(object sender, EventArgs e)
        {
            checkboxSelect(CBEU.Name);
            if (CBEU.Checked)
            {
                gbEU.Visible = true;
            }
            else
            {
                gbEU.Visible = false;
            }
        }
        private void cbDU_CheckedChanged(object sender, EventArgs e)
        {
            checkboxSelect(cbDU.Name);
            if (cbDU.Checked)
            {
                gbDikUcgen.Visible = true;
            }
            else
            {
                gbDikUcgen.Visible = false;
            }
        }
        private void cbKare_CheckedChanged(object sender, EventArgs e)
        {
            checkboxSelect(cbKare.Name);
            if (cbKare.Checked)
            {
                gbKare.Visible = true;
            }
            else
            {
                gbKare.Visible = false;
            }
        }
        private void cbDikdörtgen_CheckedChanged(object sender, EventArgs e)
        {
            checkboxSelect(cbDikdörtgen.Name);
            if (cbDikdörtgen.Checked)
            {
                gbDikdörtgen.Visible = true;
            }
            else
            {
                gbDikdörtgen.Visible = false;
            }
        }
        private void cbDaire_CheckedChanged(object sender, EventArgs e)
        {
            checkboxSelect(cbDaire.Name);
            if (cbDaire.Checked)
            {
                gbDaire.Visible = true;
            }
            else
            {
                gbDaire.Visible = false;
            }
        }

        private void bAlan_Click(object sender, EventArgs e)
        {
            if (CBEU.Checked)
            {
                if (String.IsNullOrEmpty(tbTabanKenar.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    IUcgen U1 = new EşkenarUcgen();
                    U1.TabanKenar = Double.Parse(tbTabanKenar.Text);
                    rtbSonuc.Text = U1.AlanHesapla().ToString();
                }

            }
            else if (cbDU.Checked)
            {
                if (String.IsNullOrEmpty(tbDUtaban.Text) || String.IsNullOrEmpty(tbYukseklik.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    DikUcgen U2 = new DikUcgen();
                    U2.TabanKenar = Double.Parse(tbDUtaban.Text);
                    U2.Yükseklik = Double.Parse(tbYukseklik.Text);
                    rtbSonuc.Text = U2.AlanHesapla().ToString();
                }


            }
            else if (cbDikdörtgen.Checked)
            {
                Dikdörtgen A1 = new Dikdörtgen();
                if (String.IsNullOrEmpty(tbUzunKenar.Text) || String.IsNullOrEmpty(tbKısaKenar.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    A1.Kısakenar = Double.Parse(tbKısaKenar.Text);
                    A1.Uzunkenar = Double.Parse(tbUzunKenar.Text);
                    rtbSonuc.Text = A1.AlanHesapla().ToString();
                }


            }
            else if (cbKare.Checked)
            {
                Kare K1 = new Kare();
                if (String.IsNullOrEmpty(tbUzunKenarK.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    K1.Uzunkenar = Double.Parse(tbUzunKenarK.Text);
                    rtbSonuc.Text = K1.AlanHesapla().ToString();
                }

            }
            else if (cbDaire.Checked)
            {
                if (String.IsNullOrEmpty(tbYarıcap.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    Daire D1 = new Daire();
                    D1.YarıCap = Double.Parse(tbYarıcap.Text);
                    rtbSonuc.Text = D1.AlanHesapla().ToString();
                }

            }
            else
            {
                rtbSonuc.Text = "Lütfen bir şekil seçiniz!";
            }
        }

        private void Bcevre_Click(object sender, EventArgs e)
        {
            if (CBEU.Checked)
            {
                if (String.IsNullOrEmpty(tbTabanKenar.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    IUcgen U1 = new EşkenarUcgen();
                    U1.TabanKenar = Double.Parse(tbTabanKenar.Text);
                    rtbSonuc.Text = U1.CevreHesapla().ToString();
                }

            }
            else if (cbDU.Checked)
            {
                if (String.IsNullOrEmpty(tbDUtaban.Text) || String.IsNullOrEmpty(tbYukseklik.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    DikUcgen U2 = new DikUcgen();
                    U2.TabanKenar = Double.Parse(tbDUtaban.Text);
                    U2.Yükseklik = Double.Parse(tbYukseklik.Text);
                    rtbSonuc.Text = U2.CevreHesapla().ToString();
                }


            }
            else if (cbDikdörtgen.Checked)
            {
                Dikdörtgen A1 = new Dikdörtgen();
                if (String.IsNullOrEmpty(tbUzunKenar.Text)|| String.IsNullOrEmpty(tbKısaKenar.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    A1.Kısakenar = Double.Parse(tbKısaKenar.Text);
                    A1.Uzunkenar = Double.Parse(tbUzunKenar.Text);
                    rtbSonuc.Text = A1.CevreHesapla().ToString();
                }


            }
            else if (cbKare.Checked)
            {
                Kare K1 = new Kare();
                if (String.IsNullOrEmpty(tbUzunKenarK.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    K1.Uzunkenar = Double.Parse(tbUzunKenarK.Text);
                    rtbSonuc.Text = K1.CevreHesapla().ToString();
                }

            }
            else if (cbDaire.Checked)
            {
                if (String.IsNullOrEmpty(tbYarıcap.Text))
                    rtbSonuc.Text = "Lütfen uzunluk değerlerini eksiksiz giriniz!";
                else
                {
                    Daire D1 = new Daire();
                    D1.YarıCap = Double.Parse(tbYarıcap.Text);
                    rtbSonuc.Text = D1.CevreHesapla().ToString();
                }

            }
            else
            {
                rtbSonuc.Text = "Lütfen bir şekil seçiniz!";
            }

        }
    }
}
