using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApp
{
    public partial class purchase : ContentPage
    {
        public purchase()
        {
            InitializeComponent();
        }

        private void goPurchase(object sender, EventArgs e)
        {
            string sPurchases = "";
            float iTotPrice = 0;
            if(swBurger.IsToggled){
               
                sPurchases = sPurchases + "Burger,";
                int iBurg = int.Parse(edtBurg.Text);
                iTotPrice += 20*iBurg;
            }
            if (swChips.IsToggled)
            {
                sPurchases = sPurchases + "Chips,";
                int iChips = int.Parse(edtChips.Text);

                iTotPrice += 10*iChips;

            }
            if (swWater.IsToggled) {
                sPurchases = sPurchases + "Water,";
                int iWater = int.Parse(edtWater.Text);
                iTotPrice += 5*iWater;
                

            }
            if (swWrap.IsToggled)
            {

                sPurchases = sPurchases + "Wrap,";
                int iWrap = int.Parse(edtWrap.Text);
                iTotPrice += 30*iWrap;
            }
            if (iTotPrice==0) {
                lblPurchase.Text = "You have not selected anything to purchase.Please select something.";
                lblPurchase.BackgroundColor= Color.PaleVioletRed;
            }
            else
            {

                lblPurchase.Text = "Thank you for purchasing " + sPurchases + ".That will cost R" + iTotPrice + " have a nice day.";
                lblPurchase.BackgroundColor = Color.LightSkyBlue;

            }
        }
    }
}