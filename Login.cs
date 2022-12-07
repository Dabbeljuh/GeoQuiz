using System;
using System.Windows.Forms;

namespace GeoQuiz
{
    /* Login OHNE PASSWORT: ich dachte mir, dass es kein Sinn macht bei diesem Programm ein Passwort abzufragen und es in den Anforderungen auch nicht benötigt war
     * User kann Nutzernamen eingeben und neuen erstellen 
     * wenn Nutzer sich mit einem in der Datenbank nicht vorhanden Username einzuloggen, kann er diesen neuen Nutzernamen erstellen
     * wenn Nutzer versucht einen bereits vorhanden Username zu erstellen, kann er sich mit diesem einloggen
     * TODO: wenn Enter gedrückt wird in der textbox == Login
     */
    public partial class Login : Form
    {
        private Database db = new Database();
        public Login()
        {
            InitializeComponent();
        }

        public static string username; //static variable, damit der Username, den anderen Klassen übergeben werden kann
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            username = tb_enter_user.Text;
            // username darf nicht leer sein
            if (!(username == ""))
            {
                //Username in Datenbank vorhanden?
                if (db.CheckUsernameExistence(username))
                {
                    //Nutzer wird mit eingegebnen Namen ins Menu weitergeleitet
                    Menu mn = new Menu();
                    this.Hide();
                    mn.Show();
                }
                //MessageBox: Benutzername nicht vorhanden -> neuen User anlegen?
                //YES: neuen User in Datenbank
                //NO: wieder zurück zum Einlog-Screen
                else
                {
                    DialogResult dr = MessageBox.Show("Diesen Benutzer anlegen?", "Neuer Benutzer?", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        db.NewUser(username);
                        //label_test.Text = "GOTO new user";
                        Menu mn = new Menu();
                        this.Hide();
                        mn.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("kein Username eingegeben", "Error");
            }
        }
        private void Btn_create_new_user_Click(object sender, EventArgs e)
        {
            username = tb_enter_user.Text;
            // username darf nicht leer sein
            if (!(username == ""))
            {
                //Username in Datenbank vorhanden?
                if (db.CheckUsernameExistence(username))
                {
                    //MessageBox: Benutzername bereits vorhanden -> mit diesem Namen einloggen
                    //YES: zum Hauptmenü mit eingegebnene Benutzernamen
                    //NO: wieder zurück zum Einlog-Screen
                    DialogResult dr = MessageBox.Show("Dieser Benutzer existiert bereits! \n " +
                        "Wollen Sie sich mit diesem Benutzer einloggen?", "Benutzer bereits vorhanden!", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        // User wird mit dem schon vorhandenen Usernamen eingelogged und mit diesem Usernamen ins Menü weitergeleitet
                        Menu mn = new Menu();
                        this.Hide();
                        mn.Show();
                    }
                }
                else
                {
                    // neuer Nutzer wird in die Datenbank eingetragen und mit diesem Username ins Menü weitergeleitet
                    db.NewUser(username);
                    Menu mn = new Menu();
                    this.Hide();
                    mn.Show();
                }
            }
            else
            {
                MessageBox.Show("kein Username eingegeben", "Error");
            }
        }
    }
}
