using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeoQuiz
{
    /*Parentfrom für QCountry, QCapital und QFlag
     * Children erben die Logik, die alle gemeinsam haben, nur die Frage-Logik wird angepasst
     * NextQ() wird von allen überschrieben
     */
    public partial class BaseQuestionForm : Form
    {
        public List<Country> liCountry;
        public List<string> liGuessed = new List<string> { };
        public Database db = new Database();

        public int correctAnswer;
        public int qNum = 0;                    // Fragennummer
        private const int QTOTAL = 10;          // Anzahl der Fragen -> KONSTANTE 
        public static int score = 0;            // Punktcounter -> static
        private int wrong = 0;                  // falsche Fragen Counter
        public static bool cheat = false;              // check für cheating 

        public BaseQuestionForm()
        {
            InitializeComponent();
        }
        public void BaseGameForm_Load(object sender, EventArgs e)
        {
            liCountry = db.ReadCountry();
            NextQ();
            UpdateStatus();
            lb_username.Text = Login.username;
        }

        //Helfer, welche Antwort ausgewählt wurde
        public int GetSelectedAnswer()
        {
            int answer = 4; //4=Platzhalter, Fehler
            if (radioButtonA.Checked == true) { answer = 0; }
            if (radioButtonB.Checked == true) { answer = 1; }
            if (radioButtonC.Checked == true) { answer = 2; }
            if (radioButtonD.Checked == true) { answer = 3; }
            return answer;
        }

        //prüft ob Frage richtig beantwortet wurde
        public void CheckAnswer(int rightanswer, int answergiven)
        {
            if (rightanswer == answergiven)
            {
                MessageBox.Show(NumberToLetter(answergiven) + " ist die korrekte Anwort. +1 Punkt! ", "Korrekt");
                score++;
            }
            else
            {
                MessageBox.Show(NumberToLetter(answergiven) + " ist leider falsch." + "\n\n"
                    + NumberToLetter(rightanswer) + " ist die richtige Antwort.", "Falsch");
                wrong++;
            }
        }

        public void Button_Answer_Click(object sender, EventArgs e)
        {
            // prüft ob schon 10 (Konstante QTOTAL) Fragen gestellt wurden
            if (qNum < QTOTAL)
            {
                // prüft ob eine Antwort ausgewählt wurde
                if ((radioButtonA.Checked == true) || (radioButtonB.Checked == true) ||
                    (radioButtonC.Checked == true) || (radioButtonD.Checked == true))
                {
                    CheckAnswer(correctAnswer, GetSelectedAnswer());
                    NextQ();

                    // reset radioButton
                    radioButtonA.Checked = false;
                    radioButtonB.Checked = false;
                    radioButtonC.Checked = false;
                    radioButtonD.Checked = false;

                    UpdateStatus();
                }
                // wenn keine Antwort ausgewähl wurde
                else
                {
                    MessageBox.Show("Es wurde keine Antwort ausgewählt. \n" +
                        "Bitte wählen Sie eine Antwort aus!", "Keine Antwort!");
                }
            }
            else
            {
                CheckAnswer(correctAnswer, GetSelectedAnswer());
                UpdateStatus();
                EndGame();
            }
        }

        //helper um die Zahlen von 1-4 als A, B, C, D darzustellen
        //                      -> wahrscheinlich eleganter möglich
        public string NumberToLetter(int n)
        {
            string l = "";
            if (n == 0) { l = "A"; }
            if (n == 1) { l = "B"; }
            if (n == 2) { l = "C"; }
            if (n == 3) { l = "D"; }

            return l;
        }

        //untere Statusbar
        public void UpdateStatus()
        {
            labelStatusCorrect.Text = "Richtige Antworten: " + score.ToString();
            labelSatusWrong.Text = "Falsche Antworten: " + wrong.ToString();
            gBox1.Text = "Frage: " + qNum.ToString() + " / 10";
            //TODO: Prozente und eventl. bisheriger Highscore, wenn vorhanden
        }

        // übergibt Userid, Quiztype, score und Datum der Datenbank zum speichern
        // zeigt den EndResult Bildschirm an
        public void EndGame()
        {
            int uid = db.UsernameToUserid(Login.username);
            int qtype = Menu.quiztype;
            DateTime dt = DateTime.Today;
            string today;

            // today -> Format YYYY-MM-DD
            today = dt.ToString("u").Split(" ")[0];

            Score sc = new Score(0, uid, qtype, score, today);
            db.SaveScore(sc);

            EndResult er = new EndResult();
            this.Hide();
            er.Show();
        }

        //wird in den jeweilgen Child Form (QCountry, QCapital, QFlag) überschrieben 
        //              => (? nicht wirklich sicher ob das so sinn macht) 
        public virtual void NextQ() { }

        // Cheats zum Testen, sollte eigentl raus, aber ich habs mal drinn gelassen
        // Button ist togglebar und stellt die Variable "cheat" auf True, sobald einmal gedrückt
        //TODO: punktabzug, wenn "Cheat" benutzt, nicht implementiert
        private void Button_cheat_Click(object sender, EventArgs e)
        {
            cheat = true; //TODO: punktabzug
            if (!label_cheat.Visible) { label_cheat.Visible = true; }
            else { label_cheat.Visible = false; }
        }

        //zurück zum Menu, ohne Score zu speichern
        private void Btn_back_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sind Sie sicher? \n" +
                "Score wird nicht gespeichert!!", "Zurück zum Menü", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Menu mn = new Menu();
                this.Hide();
                mn.Show();
            }
        }
    }
}