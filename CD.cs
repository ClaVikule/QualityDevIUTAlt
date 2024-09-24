namespace QualityDevIUTAlt;
    public class CD : Media
    {
        private string artiste;
        private int nombreChansons;
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            System.Console.WriteLine("Artiste: " + artiste +
                "; Nombre de chansons: " + nombreChansons);
        }
    }