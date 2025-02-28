using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationAvecDelaiEtRepetition : MonoBehaviour
{
    [SerializeField] private GameObject _objetACreer;
    [SerializeField] private GameObject _objetPlacemenent;

   
  


    void Start()
    {
        InvokeRepeating("CreerObjet", 3f, 1f);
  
        
    }

   

   



    void CreerObjet()
    {
        // Instancie un nouveau objet et garde une référence à lui
        GameObject nouvelleCopie = Instantiate(_objetACreer, _objetPlacemenent.transform.position, _objetPlacemenent.transform.rotation);

        // Prends une référence au Rigidbody qui est attaché au nouveau objet
        Rigidbody _rbNouvelleCopie = nouvelleCopie.GetComponent<Rigidbody>();

        // Applique une force de translation initiale aléatoire
        _rbNouvelleCopie.AddRelativeForce(0, 2f + Random.value, 0, ForceMode.Impulse);

        // Applique une force de rotation initiale aléatoire
        _rbNouvelleCopie.AddRelativeTorque(0f, Random.value, Random.value, ForceMode.Impulse);
    }
}