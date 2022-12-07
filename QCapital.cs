using System;
using System.Collections.Generic;

namespace GeoQuiz
{
    // Hauptstädte raten von gegebenen Ländern
    public partial class QCapital : GeoQuiz.BaseQuestionForm
    {
        Random rnd = new Random();
        public QCapital()
        {
            InitializeComponent();
        }

        private void DummyCountriesForAnswers(string country)
        {
            // Erstellt die falschen Auswahlmöglichkeiten und fügt die "richtige" Antwort dazu
            List<string> temp = new List<string>();

            while (temp.Count < 4)
            {
                //Zufallszahl von 0 und der Gesamtanzahl der Einträge in der Country-List
                int rn = rnd.Next(0, liCountry.Count);
                // keine doppelte "falsche" Antwort und nicht die "richtige" Antwort
                if (!temp.Contains(liCountry[rn].country_name) && liCountry[rn].country_capital != country)
                {
                    temp.Add(liCountry[rn].country_name);
                }
            }

            //überschreibt eine der zufällig ausgewählten Antwortmöglichkeiten mit der richtigen Antwort
            int ra = rnd.Next(4);
            temp[ra] = db.CheckCountryAnswer(country);

            correctAnswer = ra;

            radioButtonA.Text = temp[0];
            radioButtonB.Text = temp[1];
            radioButtonC.Text = temp[2];
            radioButtonD.Text = temp[3];
        }

        // überschreibt die NextQ (Next Question) von BaseQuestionForm
        public override void NextQ()
        {
            qNum++;
            string city;

            //checked ob die Frage schon gestellt wurde
            while (true)
            {
                int answer = rnd.Next(0, liCountry.Count);
                city = liCountry[answer].country_capital;
                if (!liGuessed.Contains(city))
                {
                    liGuessed.Add(city);
                    break;
                }
            }

            //Fragetext in der oberen Box
            labelQ.Text = "Welches Land hat diese Hauptstadt:";
            labelQVar.Text = city;

            // zeigt die richtige Antwort an, wenn der Button_cheat geklickt wurde
            label_cheat.Text = "Cheat: " + db.CheckCountryAnswer(city);

            DummyCountriesForAnswers(city);
        }
    }
}
