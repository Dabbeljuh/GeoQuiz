namespace GeoQuiz
{
    public class Country
    {
        public int country_id;
        public string country_name;
        public string country_capital;
        public string country_code;

        public Country(int country_id, string country_name, string country_capital, string country_code)
        {
            this.country_id = country_id;
            this.country_name = country_name;
            this.country_capital = country_capital;
            this.country_code = country_code;
        }
    }
}
