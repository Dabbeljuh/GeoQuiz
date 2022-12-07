using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeoQuiz
{
    public partial class EndResult : Form
    {
        Database db = new Database();
        int quiztype = Menu.quiztype;
        string username = Login.username;
        int userid;
        private List<Score> liSingleScore;
        private List<Score> liAllScore;

        public EndResult()
        {
            InitializeComponent();
            userid = db.UsernameToUserid(username);
            ShowResultSingle();
            ShowResultAll();
            CheckCheated();

            lb_end.Text = "Herzlichen Glückwunsch, " + username + "\n" +
                "Score: " + BaseQuestionForm.score + " /10";
        }


        //geht zurück zum "Haupt" Menü
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            BaseQuestionForm.score = 0; //reset score, nicht die eleganteste Lösung und redundant
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }

        //Startet das Quiz neu, mit dem gleich Quiz-typ
        private void Btn_restart_Click(object sender, EventArgs e)
        {
            if (quiztype == 1)
            {
                BaseQuestionForm.score = 0; //
                this.Hide();
                QCountry co = new QCountry();
                co.Show();
            }
            else if (quiztype == 2)
            {
                BaseQuestionForm.score = 0;
                this.Hide();
                QCapital ca = new QCapital();
                ca.Show();
            }
            else if (quiztype == 3)
            {
                BaseQuestionForm.score = 0;
                this.Hide();
                QFlag fl = new QFlag();
                fl.Show();
            }
            else
            {
                MessageBox.Show("Ohh ohh, ERROR -> Restart quiztype"); // sollte nie zu sehen sein, -> löschen
            }
        }

        //zeigt die Single Results an
        private void ShowResultSingle()
        {
            liSingleScore = db.GetSingleScore(quiztype, userid);
            DGV_Endresult_Single.Rows.Clear();
            int platz = 0;

            foreach (Score sa in liSingleScore)
            {
                platz++;
                DGV_Endresult_Single.Rows.Add(platz, sa.score, sa.date.Split(" ")[0]);
            }
        }

        //zeigt Gesamt-Result an
        private void ShowResultAll()
        {
            liAllScore = db.GetAllScore(quiztype);
            DGV_EndResult_all.Rows.Clear();
            int platz = 0;

            foreach (Score sa in liAllScore)
            {
                platz++;
                DGV_EndResult_all.Rows.Add(platz, db.UseridToUsername(sa.user_id), sa.score, sa.date.Split(" ")[0]);
            }
        }

        // Wenn der "Cheat" Button min. einmal gedrückt wurde, wird im Endresultat eine Nachricht angezeigt
        //TODO: das im Score kennzeichnen / Punkte abziehen
        private void CheckCheated()
        {
            if (BaseQuestionForm.cheat)
            {
                lb_cheated.Visible = true;
                lb_cheated.Text = "CHEATER DETECTED";
            }
        }
    }
}
