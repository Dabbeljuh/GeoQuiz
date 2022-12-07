namespace GeoQuiz
{
    public class Results
    {
        private int quiz_ID;
        private int nummer;
        private string given_Answer;
        private string correct_Answer;
        private bool result;

        public Results(int quiz_ID, int nummer, string given_Answer, string correct_Answer, bool result)
        {
            this.quiz_ID = quiz_ID;
            this.nummer = nummer;
            this.given_Answer = given_Answer;
            this.correct_Answer = correct_Answer;
            this.result = result;
        }
    }
}
