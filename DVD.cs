namespace QualityDevIUTAlt
{
    public class DVD : Media
    {
        private int duree;
        private string realisateur;
        
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            System.Console.WriteLine("Duree: " + duree + 
                "; Realisateur: " + realisateur);
        }
    }
}