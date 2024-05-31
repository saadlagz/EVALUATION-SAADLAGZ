using System;
//Ecrire un programme qui ecrit dans un tableau a 1 dimension les n élements harmonique 
class Program
    {

    //Procédure de Creation du Tableau Harmonique
    static double[] CalculerNombresHarmoniques(int n) {
         double[] tab = new double[n];
         int Somme = 0;
    for (int i = 1; i <= n; i++){
       Tab[i] = Somme + 1 / i;
       Somme += Tab[i]; 
    }
    return Tab;
    }

    //Affichage du tableau des nombres harmoniques
    static void AfficherTableauHarmoniques(double[] Tab)
    {
        Console.Writeline("Le tableau résultat contient : ");
        foreach (double val in tab)
        {
            Console.Writeline(val);
        }
    }

    static void Main(string[] args) {

    Console.WriteLine("Saisir le nombre d'éléments Harmoniques : ");
    Element_Harmonique = Convert.ToInt32(Console.ReadLine()); 

    double[] tab = new double[Element_Harmonique];

    CalculerNombresHarmoniques(Element_Harmonique);

    AfficherTableauHarmoniques(double[] Tab)
    }
}
}
























































