using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VKFApp
{
    internal class ClassClients
    {
        private int numClient;
        private string nomClient;
        private string activite;
        private string adresse;
        private string ville;
        private int codePostal;
        private string email;
        private string telPortable;
        private string telFixe;
        private string SIREN;
        private string dateOuverture;

        public ClassClients(int unNumClient, string unNomClient, string uneActivite, string uneAdresse, string uneVille, int unCodePostal, string unEmail, string unTelPortable, string unTelFixe, string uneSIREN, string uneDateOuverture)
        {
            this.numClient = unNumClient;
            this.nomClient = unNomClient;
            this.activite = uneActivite;
            this.adresse = uneAdresse;
            this.ville = uneVille;
            this.codePostal = unCodePostal;
            this.email = unEmail;
            this.telPortable = unTelPortable;
            this.telFixe = unTelFixe;
            this.SIREN = uneSIREN;
            this.dateOuverture = uneDateOuverture;  
        }

        public int getNumClient()
        {
            return this.numClient;
        }

        public void setNumClient(int unNumClient)
        {
            this.numClient = unNumClient;
        }

        public string getNomClient()
        {
            return this.nomClient;
        }

        public void setNomClient(string unNomClient)
        {
            this.nomClient = unNomClient;
        }

        public string getActivite()
        {
            return this.activite;
        }

        public void setActivite(string uneActivite)
        {
            this.activite = uneActivite;  
        }

        public string getAdresse()
        {
            return this.adresse;
        }

        public void setAdresse(string uneAdresse)
        {
            this.adresse = uneAdresse;
        }

        public string getVille()
        {
            return this.ville;
        }

        public void setVille(string uneVille)
        {
            this.ville = uneVille;
        }

        public int getCodePostal()
        {
            return this.codePostal;
        }

        public void setCodePostal(int unCodePostal)
        {
            this.codePostal = unCodePostal;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string unEmail)
        {
            this.email = unEmail;
        }

        public string getTelPortable()
        {
            return this.telPortable;
        }

        public void setTelPortable(string unTelPortable)
        {
            this.telPortable = unTelPortable;
        }

        public string getTelFixe()
        {
            return this.telFixe;
        }

        public void setTelFixe(string unTelFixe)
        {
            this.telFixe = unTelFixe;
        }

        public string getSIREN()
        {
            return this.SIREN;
        }

        public void setSIREN(string unSIREN)
        {
            this.SIREN = unSIREN;
        }

        public string getDateOuverture()
        {
            return this.dateOuverture;
        }

        public void setDateOuverture(string uneDateOuverture)
        {
            this.dateOuverture = uneDateOuverture;
        }

    }
}
