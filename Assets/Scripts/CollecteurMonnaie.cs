using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecteurMonnaie : MonoBehaviour
{
    public int points;  //avec les variables public je peux avoir acces a partir d'un autre script a cette meme variable


    private void Start()
    {
        points = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monnaie"))
        {
            Destroy(other.gameObject);
            points++; //ca veut dire on ajoute des points
        }
    }
}
