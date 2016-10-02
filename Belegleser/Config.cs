using System;
using System.IO;
using System.Windows.Forms;

namespace Belegleser
{
    class Config
    {
        private static Config CONFIG;

        private string password;

        public static Config getInstance()
        {
            if (CONFIG == null)
            {
                //NEW 
                CONFIG = new Config();
            }
            return CONFIG;
        }

        public Config()
        {
            try
            {
                string[] lines = File.ReadAllLines("settings.ini");
                this.ScanDirectory = lines[0];
                this.SQLHost = lines[1];
                this.SQLInstance = lines[2];
                this.SQLUser = lines[3];
                this.password = lines[4];
                this.Interval = lines[5];
            }
            catch (Exception)
            {
                MessageBox.Show("Keine Einstellungen gefunden, bitte prüfen und einstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string ScanDirectory
        {
            get; set;
        }

        public string SQLHost
        {
            get; set;
        }

        public string SQLInstance
        {
            get; set;
        }

        public string SQLUser
        {
            get; set;
        }

        public string SQLPassword
        {
            get
            {
                return this.Decode(this.password);
            }
            set
            {
                this.password = this.Encode(value);
            }
        }

        public string Interval
        {
            get; set;
        }

        public void Save()
        {
            using (StreamWriter file = new StreamWriter("settings.ini"))
            {
                file.WriteLine(this.ScanDirectory);
                file.WriteLine(this.SQLHost);
                file.WriteLine(this.SQLInstance);
                file.WriteLine(this.SQLUser);
                file.WriteLine(this.password);
                file.WriteLine(this.Interval);
            }
            MessageBox.Show("Einstellungen wurden erfolgreich gespeichert!", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Verschlüsselt das Mail-Passwort
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string Encode(string password)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(encbuff);
        }

        /// <summary>
        /// Entschlüsselt das Mail-Passwort
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string Decode(string password)
        {
            byte[] decbuff = Convert.FromBase64String(password);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
    }
}
