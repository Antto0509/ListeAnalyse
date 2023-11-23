# ListeAnalyse

## Objectif

Recréer à les fonctions suivantes sans utiliser les méthodes existantes en C# :  

TailleListe(Liste) : Entier (retourne le nb d’élément)

	Liste → Entier  
 
IsEmpty(Liste) : Bool (si vide, retourne vrai)

	Liste → (T, F)
 
IsFull(Liste, TailleMax) : Bool (si plein, retourne vrai)

	Liste x TailleMax → (T, F)
 
Value(Liste, Rang) : Element

	Liste x Rang → Element
 
Find(Liste, Element) : Rang

	Liste x Element → Rang (si Element E Liste, sinon 0)
 
Add(Liste, Rang, Element) : Liste

	Liste x Rang x Element → Liste
 
Remove(Liste, Rang) : (Liste, Element)

	Liste x Rang → (Liste, Element)

En sachant :
Une Liste est composée d’Élément
  Element E Liste
  
Element : t_Element

Liste : t_Liste

