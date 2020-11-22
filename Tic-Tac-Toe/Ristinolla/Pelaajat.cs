
//Tehdään rakenne pelaajalle
public struct Pelaaja
{
    private string etunimi;
    private string sukunimi;
    private string syntymaaika;
    private int voitetutPelit;
    private int hävitytPelit;
    private int tasapelit;
    private float pelattuAika;

    //GET&SET pelaajalle luotu automaattisesti
    public string Etunimi { get => etunimi; set => etunimi = value; }
    public string Sukunimi { get => sukunimi; set => sukunimi = value; }
    public string Syntymaaika { get => syntymaaika; set => syntymaaika = value; }
    public int VoitetutPelit { get => voitetutPelit; set => voitetutPelit = value; }
    public int HävitytPelit { get => hävitytPelit; set => hävitytPelit = value; }
    public int Tasapelit { get => tasapelit; set => tasapelit = value; }
    public float PelattuAika { get => pelattuAika; set => pelattuAika = value; }
}
