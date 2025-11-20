using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Freccia : Proiettile
{
    [SerializeField] private int _numeroFrecceSimultanee;

    public Freccia(float velocita, float gittata, int numeroFrecceSimultanee) : base(velocita, gittata)
    {
        _velocita = velocita;
        _gittata = gittata;
        _numeroFrecceSimultanee = numeroFrecceSimultanee;
    }

    public override void Lancia()
    {
        Debug.Log("La freccia è stato lanciata !");
        _numeroFrecceSimultanee++;
        Debug.Log($"Il numero di frecce simultanee scoccate sono : {_numeroFrecceSimultanee} con velocità : {_velocita} e gittata : {_gittata}");
    }




}
