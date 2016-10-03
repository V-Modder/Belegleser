using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Belegleser
{
    public class Config
    {
        private static Config CONFIG;

        private string password;

        public static Config getInstance()
        {
            if (CONFIG == null)
            {
                //NEW 
                CONFIG = new Config();
                CONFIG.Load();
            }
            return CONFIG;
        }

        public Config()
        {
           
        }

        public void Load()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));
                using (StreamReader writer = new StreamReader("settings.ini"))
                {
                    Config cfg = (Config)serializer.Deserialize(writer);
                    this.ScanDirectory = cfg.ScanDirectory;
                    this.SQLHost = cfg.SQLHost;
                    this.SQLInstance = cfg.SQLInstance;
                    this.SQLUser = cfg.SQLUser;
                    this.password = cfg.SQLPassword;
                    this.Interval = cfg.Interval;
                    this.Templates = cfg.Templates;
                }
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
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public string getEncryptedPassword()
        {
            return this.Decode(this.password);
        }

        public void setEncryptedPassword(string pwd)
        {
            this.password = this.Encode(pwd);
        }

        public string Interval
        {
            get; set;
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            using (StreamWriter writer = new StreamWriter("settings.ini"))
            {
                serializer.Serialize(writer, this);
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

        public List<SaveTemplateWork> Templates
        {
            get; set;
        }
    }
}
