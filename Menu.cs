using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeoQuiz
{
    /* Hauptmenü des Programmes
     * Auswahlmöglichkeiten der Spielmodi (Länder, Hauptstädte, Flaggen) und eine persöhnliche und allgemeine ScorerListe
     * über logout kommt Nutzer wieder zu dem Login-Bildschirm
     */
    public partial class Menu : Form
    {
        private List<Score> liSingleScore;
        private List<Score> liAllScore;
        private Database db = new Database();

        int userid;

        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            lb_username.Text = Login.username;
            userid = db.UsernameToUserid(Login.username);
            quiztype = 1; //default Auswahlmöglichkeit, um Statistiken direkt anzuzeigen
            SingleScoreShow();
            AllScoreShow();
        }

        //zurück zum Login
        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        public static int quiztype;     //static variable, damit andere Klassen darauf zugreifen können, welcher Quiz-Typ ausgewählt wurde
        //startet das Quiz mit dem ausgewählten Spielmodus
        private void Btn_start_Click(object sender, EventArgs e)
        {
            //Radiobutton check
            if (rb_country.Checked)
            {
                this.Hide();
                QCountry co = new QCountry();
                quiztype = 1;  //eventl redundant -> quiztype wird in den rb_var_CheckedChanged geändert und es gibt keine andere Möglichkeit ein Spiel zu starten ?
                co.Show();
            }
            else if (rb_capital.Checked)
            {
                this.Hide();
                QCapital ca = new QCapital();
                quiztype = 2;
                ca.Show();
            }
            else if (rb_flag.Checked)
            {
                this.Hide();
                QFlag fl = new QFlag();
                quiztype = 3;
                fl.Show();
            }
            else
            {
                MessageBox.Show("Kein Spielmodus ausgewählt!", "Spielmodus auswählen"); //sollte nie passieren, löschen?
            }
        }

        //zeigt Score für einloggten User an
        private void SingleScoreShow()
        {
            pn_noscore.Visible = false;
            liSingleScore = db.GetSingleScore(quiztype, userid);
            DGV_single.Rows.Clear();
            int platz = 0;

            foreach (Score sa in liSingleScore)
            {
                platz++;
                DGV_single.Rows.Add(platz, sa.score, sa.date.Split(" ")[0]);
            }


            if (DGV_single.Rows.Count == 1)
            {
                pn_noscore.Visible = true;
                lb_noscore.Text = "Dieser Benutzer hat noch \n keinen Score in diesem Spielmodus.";
            }
        }

        //zeigt Score aller User an
        private void AllScoreShow()
        {
            liAllScore = db.GetAllScore(quiztype);
            DGV_all.Rows.Clear();
            int platz = 0;

            foreach (Score sa in liAllScore)
            {
                platz++;
                DGV_all.Rows.Add(platz, db.UseridToUsername(sa.user_id), sa.score, sa.date.Split(" ")[0]);
            }

            if (DGV_all.Rows.Count == 0)
            {
                DGV_all.Rows.Add("", "no plays", "", "");
            }
        }

        // aktualiesiert die ausgewählten Spielmodus-Score
        private void rb_country_CheckedChanged(object sender, EventArgs e)
        {
            quiztype = 1;
            SingleScoreShow();
            AllScoreShow();
        }
        private void rb_capital_CheckedChanged(object sender, EventArgs e)
        {
            quiztype = 2;
            SingleScoreShow();
            AllScoreShow();
        }
        private void rb_flag_CheckedChanged(object sender, EventArgs e)
        {
            quiztype = 3;
            SingleScoreShow();
            AllScoreShow();
        }
    }
}
