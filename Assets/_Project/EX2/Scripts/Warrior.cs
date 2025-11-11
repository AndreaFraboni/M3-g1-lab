using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public Warrior (string nome, int hp): base(nome, hp)
    {
    
    }

    public override void Attack(Character target)
    {
        target.TakeDamage(10);
        Debug.Log($"{target._nome} Colpisce con la spada");
    }





}
