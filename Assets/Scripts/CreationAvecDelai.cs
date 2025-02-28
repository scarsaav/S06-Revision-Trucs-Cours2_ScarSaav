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
        // �xecute la m�thode CreerObjet apr�s un d�lai de 5s
        //Invoke("CreerObjet", 5f);
        // �xecute la m�thode CreerObjet apr�s un d�lai initiale de 3s et � chaque 1s apr�s
        // (apres 3 seconde la cr�ation commence et apres chaque cr�ation c'est apres 1 seconde)
        InvokeRepeating("CreerObjet", 3f, 1f);
        // Cancelle tous les Invoke() actifs
        //CancelInvoke();


        _monnaies = 0; //**

    }

    void CreerObjet()
    {
        // Instancie un nouveau objet et garde une r�f�rence � lui
        GameObject nouvelleCopie = Instantiate(_objetACreer, _objetPlacemenent.transform.position, _objetPlacemenent.transform.rotation);

        // Prends une r�f�rence a le Rigidbody attach� au nouveau objet
        Rigidbody _rbNouvelleCopie = nouvelleCopie.GetComponent<Rigidbody>();

        // Applique une force de translation initiale al�atoire.....action de lancer la monnaie vers le haut
        _rbNouvelleCopie.AddRelativeForce(0, 2f + Random.value, 0, ForceMode.Impulse);

        // Applique une force de rotation initiale al�atoire
        _rbNouvelleCopie.AddRelativeTorque(0f, Random.value, Random.value, ForceMode.Impulse);

       
        //apres un certaine qt� de monnaies on cancel la cr�ation des monnaies
        _monnaies += 1;

        if(_monnaies == 10)
        { 
            CancelInvoke();
        }
    }
}


//int = nombre entier ex:1  (avec les int on peut utiliser == avec float non )    float = nnombre decimales ex:1.55