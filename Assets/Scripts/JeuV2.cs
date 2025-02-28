using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;
    [SerializeField] private TextMeshProUGUI _etiquetteTemps;

    public int pointsJeu = 0;
    public int temps = 0;

    void Start()
    {
        pointsJeu = 0;
        InvokeRepeating("AugTemps", 1f, 1f);
        temps = 0;
    }


    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        if(temps > 10)
        {
        pointsJeu += 2;
        }
        else
        {
            pointsJeu++;
        }

        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();

    }

    public void AugTemps()
    {
        temps++;
        _etiquetteTemps.text = temps.ToString() + "sec";
    }
}
