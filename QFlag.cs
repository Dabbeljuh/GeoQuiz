using System;
using System.Collections.Generic;
using System.Drawing;

namespace GeoQuiz
{
    // Länder erraten von gegebenen Flaggen, der jeweiligen Länder
    public partial class QFlag : GeoQuiz.BaseQuestionForm
    {
        Random rnd = new Random();
        public QFlag()
        {
            InitializeComponent();
        }

        // Erstellt die falschen Auswahlmöglichkeiten und fügt die "richtige" Antwort dazu
        private void DummyCountriesForAnswers(string country)
        {
            //Liste mit 4 möglichen unterschiedlichen Antworten, ohne die "richtige" Antwort
            List<string> temp = new List<string>();

            while (temp.Count < 4)
            {
                //Zufallszahl von 0 und der Gesamtanzahl der Einträge in der Country-List
                int rn = rnd.Next(0, liCountry.Count);
                // keine doppelte "falsche" Antwort und nicht die "richtige" Antwort
                if (!temp.Contains(liCountry[rn].country_name) && liCountry[rn].country_name != country)
                {
                    temp.Add(liCountry[rn].country_name);
                }
            }

            //überschreibt eine der zufällig ausgewählten Antwortmöglichkeiten mit der "richtigen" Antwort
            int ra = rnd.Next(4);
            temp[ra] = country;

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
            string country;

            //checked ob die Frage schon gestellt wurde
            while (true)
            {
                int answer = rnd.Next(0, liCountry.Count);
                country = liCountry[answer].country_name;
                if (!liGuessed.Contains(country))
                {
                    liGuessed.Add(country);

                    break;
                }
            }

            string pic = db.CheckPictureAnswer(country);
            ChangePicture(pic);
            //Fragetext in der oberen Box
            labelQ.Text = "Welches Land hat \n diese Flagge: ";

            // zeigt die richtige Antwort an, wenn der Button_cheat geklickt wurde
            label_cheat.Text = "Cheat: " + country;

            DummyCountriesForAnswers(country);
        }

        // ändert das Bild mit der korrekten Flagge
        public void ChangePicture(string countrycode)
        {
            object o = Properties.Resources.ResourceManager.GetObject(countrycode);
            if (o is Image)
            {
                pb_Flags.Image = o as Image;
            }
        }
    }
}
