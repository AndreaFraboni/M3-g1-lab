using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
    public Archer(string name, int hp): base(name, hp)
    {

    }

    public override void Attack (Character target)
    {
        for (int i = 0; i < 2; i++)
        {
            target.TakeDamage(7);
            Debug.Log($"{_nome} ha scagliato la freccia numero = {i+1}");
        }
    }
}
