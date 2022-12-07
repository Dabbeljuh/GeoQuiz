namespace GeoQuiz
{
    public class Score
    {
        public int score_id;
        public int user_id;
        public int quiztype_id;
        public int score;
        public string date;

        public Score(int score_id, int user_id, int quiztype_id, int score, string date)
        {
            this.score_id = score_id;
            this.user_id = user_id;
            this.quiztype_id = quiztype_id;
            this.score = score;
            this.date = date;
        }
    }
}
