namespace QualityDevIUTAlt
public class Library
{
    private List<T> medias;

    public string this[int n]
    {
        get{return medias[n].numeroDeReference}
        set{medias[n].numeroDeReference = value;}
    }
}