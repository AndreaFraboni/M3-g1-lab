using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public Mage(string nome, int hp): base(nome, hp)
    {

    }

    public override void Attack(Character target)
    {
        target.TakeDamage(12);

    }

}
