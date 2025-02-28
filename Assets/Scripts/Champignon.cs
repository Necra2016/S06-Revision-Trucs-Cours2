using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champignon : MonoBehaviour
{

         public GameObject champi;
        public GameObject drapeau;
    public GameObject boite;
        [SerializeField] private float _distanceMaximale;
        float _Salut = 0;
        void Start()
        {
            _Salut = Random.value;
            Vector3 nouvellePosition = Vector3.zero;
            Vector2 variation = Random.insideUnitCircle * _distanceMaximale;
            nouvellePosition.x = variation.x;
            nouvellePosition.z = variation.y;
            transform.position += nouvellePosition;

            if(_Salut > 0.5f)
        {

            champi.transform.position = drapeau.transform.position;
        }
        else
        {
            champi.transform.position = boite.transform.position;
        }
    }
    
}
