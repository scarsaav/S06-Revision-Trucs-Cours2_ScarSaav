using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationAvecDelai : MonoBehaviour
{
    [SerializeField ] private GameObject _objetACreer;
    [SerializeField] private GameObject _objetPlacemenent;

    private int _monnaies; //**

    void Start()
    {
        // Éxecute la méthode CreerObjet après un délai de 5s
        //Invoke("CreerObjet", 5f);
        // Éxecute la méthode CreerObjet après un délai initiale de 3s et à chaque 1s après
        // (apres 3 seconde la création commence et apres chaque création c'est apres 1 seconde)
        InvokeRepeating("CreerObjet", 3f, 1f);
        // Cancelle tous les Invoke() actifs
        //CancelInvoke();


        _monnaies = 0; //**

    }

    void CreerObjet()
    {
        // Instancie un nouveau objet et garde une référence à lui
        GameObject nouvelleCopie = Instantiate(_objetACreer, _objetPlacemenent.transform.position, _objetPlacemenent.transform.rotation);

        // Prends une référence a le Rigidbody attaché au nouveau objet
        Rigidbody _rbNouvelleCopie = nouvelleCopie.GetComponent<Rigidbody>();

        // Applique une force de translation initiale aléatoire.....action de lancer la monnaie vers le haut
        _rbNouvelleCopie.AddRelativeForce(0, 2f + Random.value, 0, ForceMode.Impulse);

        // Applique une force de rotation initiale aléatoire
        _rbNouvelleCopie.AddRelativeTorque(0f, Random.value, Random.value, ForceMode.Impulse);

       
        //apres un certaine qté de monnaies on cancel la création des monnaies
        _monnaies += 1;

        if(_monnaies == 10)
        { 
            CancelInvoke();
        }
    }
}


//int = nombre entier ex:1  (avec les int on peut utiliser == avec float non )    float = nnombre decimales ex:1.55