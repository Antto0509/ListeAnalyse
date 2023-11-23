// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class MaListe
{
    private int[] liste;

    public MaListe(int[] listeInitiale)
    {
        this.liste = listeInitiale ;
    }

    public int TailleListe(int[] liste)
    {
        int taille = 0;
        foreach (int element in liste)
        {
            taille++;
        };
        return taille;
    }

    public bool IsEmpty(int[] liste)
    {
        int taille = 0;
        foreach (int element in liste)
        {
            taille++;
            break;
        }
        if (taille > 0){
            return false;
        }
        return true;
    }

    public bool IsFull(int Tmax)
    {
        int taille = 0;
        foreach (int element in liste)
        {
            taille++;
            break;
        }
        if (taille < 0)
        {
            return false;
        }
        return true; ;
    }
}
