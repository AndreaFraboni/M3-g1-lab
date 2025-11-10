using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PallaMagica : Proiettile
{
    [SerializeField] private int MaxRimbalzi;

    public PallaMagica(float velocita, float gittata)
    {
        _velocita = velocita;
        _gittata = gittata;
    }

    public override void Lancia()
    {
        Debug.Log("La palla magica è stato lanciata !");
        int randomNumber = Random.Range(0, MaxRimbalzi + 1);
        Debug.Log($"La palla magica ha rimbalzato : {randomNumber} con velocità : {_velocita} e gitata : {_gittata}");
    }

}
