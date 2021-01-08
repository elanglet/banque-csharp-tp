using NUnit.Framework;

namespace banque_simple
{
    [TestFixture]
    public class CompteTest 
    {
        private Compte compte;
        
        [SetUp]
        public void setUp() {
            compte = new Compte(456123, 1000.00, "rdupont@gmail.com");
        }

        [Test]
        public void testCompte() {
            Compte compte = new Compte();
            Assert.IsNotNull(compte);
        }

        [Test]
        public void testCompteLongDoubleString() {
            Compte compte = new Compte(568963, 5000.00, "smartin@gmail.com");
            Assert.IsNotNull(compte);
            Assert.AreEqual(568963, compte.Numero);
            Assert.AreEqual(5000.00, compte.Solde, 0);
            Assert.AreEqual("smartin@gmail.com", compte.ReferenceClient);
        }

        [Test]
        public void testGetNumero() {
            Assert.AreEqual(456123, compte.Numero);
        }

        [Test]
        public void testSetNumero() {
            compte.Numero = 896345;
            Assert.AreEqual(896345, compte.Numero);
        }

        [Test]
        public void testGetSolde() {
            Assert.AreEqual(1000.00, compte.Solde, 0);
        }

        [Test]
        public void testSetSolde() {
            compte.Solde = 2000.00;
            Assert.AreEqual(2000.00, compte.Solde, 0);
        }

        [Test]
        public void testGetReferenceClient() {
            Assert.AreEqual("rdupont@gmail.com", compte.ReferenceClient);
        }

        [Test]
        public void testSetReferenceClient() {
            compte.ReferenceClient = "bdubois@outlook.fr";
            Assert.AreEqual("bdubois@outlook.fr", compte.ReferenceClient);
        }
    }

}
