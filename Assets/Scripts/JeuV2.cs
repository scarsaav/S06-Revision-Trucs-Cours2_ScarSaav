using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;
    [SerializeField] private TextMeshProUGUI _etiquetteTemps;

    public int pointsJeu = 0;

    //un autre facon de faire augmenter le temps du jeu
    //public float pointsJeu = 0;


    void Start()
    {
        pointsJeu = 0;


        //un autre facon de faire augmenter le temps du jeu
        //InvokeRepeating("AugmenterPoints", 1f, 0.01f);
        InvokeRepeating("AugmenterPoints", 1f, 1f);
    }


    //exercice facon 2
   // private void Update()
    //{
   //     pointsJeu += Time.deltaTime;
     //   _etiquettePoints.text = "$" + pointsJeu.ToString("00.00");

    //}

    public void AugmenterPoints()
    {
        //pointsJeu += 0.01f;
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
    }

   
}
