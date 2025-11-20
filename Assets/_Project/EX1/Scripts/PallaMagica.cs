using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PallaMagica : Proiettile
{
    [SerializeField] private int maxRimbalzi;

    public PallaMagica(float velocita, float gittata, int maxRimbalzi) : base(velocita, gittata)
    {
        _velocita = velocita;
        _gittata = gittata;
        this.maxRimbalzi = maxRimbalzi;
    }

    public override void Lancia()
    {
        int randomNumber = Random.Range(0, maxRimbalzi + 1);
        if (randomNumber <= 0)
        {
            Debug.Log("La palla magica non ha rimbalazto !");
        }
        else
        {
            Debug.Log($"La palla magica ha rimbalzato : {randomNumber} con velocità : {_velocita} e gitata : {_gittata}");
        }
    }

}
