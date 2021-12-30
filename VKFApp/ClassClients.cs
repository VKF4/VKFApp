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



    }
}
