namespace QualityDevIUTAlt
{
    public class Media
    {
        protected string titre;
        protected int numeroDeReference;
        protected int nombreExemplairesDisponibles;

        public virtual void AfficherInfos()
        {
            System.Console.WriteLine("Titre: " + titre +
                "; Numéro de référence: " + numeroDeReference +
                "; Nombre d'exemplaires disponibles: " + nombreExemplairesDisponibles);
        }
    }
}