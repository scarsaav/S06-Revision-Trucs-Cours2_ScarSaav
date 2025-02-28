using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV1 : MonoBehaviour
{
    [SerializeField] private CollecteurMonnaie _collecteur; //[SerializeField]=a une variable qu'on peut voir au inspecteur
    [SerializeField] private TextMeshProUGUI _etiquettePoints;

    public int pointsJeu = 0; //comptage general

    void Start()
    {
        pointsJeu = 0;
    }

    void Update()
    {
        // Actualiser la valeur du points du jeu
        pointsJeu = _collecteur.points; //points ici c'est une variable public qui se trouve dans un autre script car public
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
    }
}
