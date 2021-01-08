using System;

namespace banque_simple
{
    public class Compte 
    {
        private int numero;
        private double solde;
        private string referenceClient;

        public Compte() 
        {

        }

        public Compte(int pNumero, double pSolde, string pReferenceClient) 
        {
            numero = pNumero;
            solde = pSolde;
            referenceClient = pReferenceClient;
        }


        public int Numero {
            get {
                return numero;
            }

            set {
                numero = value;
            }
        }

        public double Solde {
            get {
                return solde;
            }

            set {
                solde = value;
            }
        }

        public string ReferenceClient {
            get {
                return referenceClient;
            }

            set {
                referenceClient = value;
            }
        }
    }
}