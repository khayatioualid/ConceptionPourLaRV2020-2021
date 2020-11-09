namespace Bridge
{
    internal class CalculateurInterface : ICalculateur
    {
        private ICalculateur implementation;
        public CalculateurInterface(ICalculateur implementation)
        {
            this.implementation = implementation;
        }
        public int produit(int x, int y)
        {
            return implementation.produit(x, y);
        }

        public int somme(int x, int y)
        {
            return implementation.somme(x, y);
        }
    }
}