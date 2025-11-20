using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Proiettile
{
    public float _velocita;
    public float _gittata;

    public Proiettile(float velocita, float gittata)
    {
        this._velocita = velocita;
        this._gittata = gittata;
    }

    public virtual void Lancia()
    {

    }

}
