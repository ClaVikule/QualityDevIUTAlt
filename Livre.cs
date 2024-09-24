namespace QualityDevIUTAlt
{
    public class Livre : Media
    {
        private string auteur;
        private string edition;

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            System.Console.WriteLine("Auteur: " + auteur +
                "; Edition: " + edition);
        }
    }
}