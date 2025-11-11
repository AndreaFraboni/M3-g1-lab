using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Freccia : Proiettile
{
    [SerializeField] private int numeroFrecceSimultanee;

    public Freccia(float velocita, float gittata)
    {
        _velocita = velocita;
        _gittata = gittata;
    }

    public override void Lancia()
    {
        Debug.Log("La freccia è stato lanciata !");
        numeroFrecceSimultanee++;
        Debug.Log($"Il numero di frecce simultanee scoccate sono : {numeroFrecceSimultanee} con velocità : {_velocita} e gittata : {_gittata}");
    }




}
