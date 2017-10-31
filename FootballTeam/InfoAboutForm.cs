using FootballTeam.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTeam
{
    public partial class InfoAboutForm : Form
    {
        EFContext context = new EFContext();
        public InfoAboutForm()
        {
            InitializeComponent();
            AddCB();
        }

        private void AddCB()
        {
            List<object> withD = new List<object>();
            List<object> withoutD = new List<object>();
            foreach (var countries in context.Teams)
            {
                withD.Add(countries.Country);
            }
            withoutD=withD.Distinct().ToList();
            foreach (var item in withoutD)
            {
                cb_country.Items.Add(item);
            }
        }

        private void cb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<object> Cities = new List<object>();
            List<object> CitiesWithoutD = new List<object>();
            string countryMain = cb_country.SelectedText;
            foreach (var country in context.Teams)
            {
                if(country.Country== countryMain)
                {
                    Cities.Add(country.City);
                }
            }
            CitiesWithoutD = Cities.Distinct().ToList();
            foreach (var item in CitiesWithoutD)
            {
                cb_city.Items.Add(item);
            }
        }
    }
}
