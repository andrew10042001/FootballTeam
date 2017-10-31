using Bogus;
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
            //generate();
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
            lb_name_firstteam.Text = cb_firstteam.Text;
            lb_name_secondteam.Text = cb_secondteam.Text;
            Algorithm(cb_firstteam.SelectedItem, cb_secondteam.SelectedItem);
        }

        private void Algorithm(object firstTeam, object secondTeam)
        {
            int overageEfficiency1 = 0;
            int overageEfficiency2 = 0;
            Random rnd = new Random();
            for (int i = 0; i <= 90; i++)
            {
                foreach (var player in (firstTeam as Entities.Team).Humans)
                {
                    overageEfficiency1 += player.HumanInfo.Efficiency;
                }
                overageEfficiency1 /= (firstTeam as Entities.Team).Humans.Count;

                foreach (var player in (secondTeam as Entities.Team).Humans)
                {
                    overageEfficiency2 += player.HumanInfo.Efficiency;
                }
                overageEfficiency2 /= (secondTeam as Entities.Team).Humans.Count;

                overageEfficiency1 *= rnd.Next(0, 100);
                overageEfficiency2 *= rnd.Next(0, 100);
                if(overageEfficiency1 > overageEfficiency2 && overageEfficiency1 > 6000)
                {
                    lb_goals_firstteam.Text =  ((int.Parse(lb_goals_firstteam.Text)) + 1).ToString();
                }
                if (overageEfficiency2 > overageEfficiency1 && overageEfficiency2 > 6000)
                {
                    lb_goals_secondteam.Text = ((int.Parse(lb_goals_secondteam.Text)) + 1).ToString();
                }

            }
        }

        class Team
        {
            public string Name { get; set; }
            public string Town { get; set; }
            public string Country { get; set; }
        }
        class FInfo
        {
            public static string[] positionArr = { "Goalkeeper", "Right defender", "Left defender", "Central defender", "Right midfielder", "Left midfielder", "Attacking midfielder", "Right Forward", "Left Forward" };
            public string Name { get; set; }
            public int age { get; set; }
            public string position { get; set; }
            public int kkd { get; set; }
        }


        private void generate()
        {
            //var TeamInsert = new Faker<Team>("en")
            //     .RuleFor(u => u.Name, f => f.Company.CompanyName())
            //     .RuleFor(u => u.Town, f => f.Address.City())
            //     .RuleFor(u => u.Country, f => f.Address.Country());

            //for (int i = 0; i < 300; i++)
            //{
            //    var team = TeamInsert.Generate();
            //    context.Teams.Add(
            //        new Entities.Team
            //        {
            //            Name = team.Name,
            //            City = team.Town,
            //            Country = team.Country
            //        });
            //    context.SaveChanges();
            //}

            var FinfoInsert = new Faker<FInfo>("en")
                      .RuleFor(u => u.Name, f => f.Name.FirstName() + " ")
                      .RuleFor(u => u.age, f => f.Random.Int(18, 40))
                     .RuleFor(u => u.kkd, f => f.Random.Int(20, 98))
                  .RuleFor(u => u.position, f => FInfo.positionArr[f.Random.Int(0, 9)]);

            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    Human _human = new Human
                    {
                        IdOfClub = rnd.Next(1, context.Teams.Count()),
                        IdOfRole = 1,

                    };
                    context.Humans.Add(_human);
                    context.SaveChanges();

                    var player = FinfoInsert.Generate();
                    context.HumansInfo.Add(
                        new HumanInfo
                        {
                            HumanId = _human.HumanId,
                            Name = player.Name,
                            Age = player.age,
                            Position = player.position,
                            Efficiency = player.kkd
                        }
                        );
                    context.SaveChanges();
                }
                catch (Exception)
                {

                }
            }
        }

        private void lb_goals_secondteam_Click(object sender, EventArgs e)
        {

        }
    }
}

