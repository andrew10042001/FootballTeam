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
    public partial class MainForm : Form
    {
        EFContext context = new EFContext();
        public MainForm()
        {
            InitializeComponent();
            AddLists();
        }

        private void AddLists()
        {
            foreach (var teams in context.Teams)
            {
                cb_firstteam.Items.Add(teams.Name);
                cb_secondteam.Items.Add(teams.Name);
            }
        }

        private void btn_showteaminfo_Click(object sender, EventArgs e)
        {
            InfoAboutForm infoAboutForm = new InfoAboutForm();
            infoAboutForm.ShowDialog();
        }

        private void btn_moreinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info");
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            lb_name_firstteam.Text=cb_firstteam.SelectedText;
            lb_name_secondteam.Text = cb_secondteam.SelectedText;
            Algorithm(cb_firstteam.SelectedItem, cb_secondteam.SelectedItem);
        }

        private void Algorithm(object firstTeam, object secondTeam)
        {
            
        }
    }
}
