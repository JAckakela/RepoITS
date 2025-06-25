namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            Calcolatrice.Calcolatrice calcolatrice = new Calcolatrice.Calcolatrice(); 
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato, "La somma di 2 e 3 dovrebbe essere 5.");
        }
        [TestMethod]
        public void TestSommaConZero()
        {
            Calcolatrice.Calcolatrice calcolatrice = new Calcolatrice.Calcolatrice();
            double risultato = calcolatrice.Somma(0, 0);
            Assert.AreEqual(0, risultato, "La somma di 0 e 0 dovrebbe essere 0.");
        }
    }
}
