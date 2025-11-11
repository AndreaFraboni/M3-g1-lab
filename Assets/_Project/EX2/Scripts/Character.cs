using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string _nome;
    public int _hp;

    public Character (string nome, int hp)
    {
        _nome = nome;
        _hp = hp;
    }

    public virtual void Attack(Character target)
    {
        target.TakeDamage(1);
    }

    public virtual void TakeDamage(int damage)
    {
        _hp = _hp - damage;
        if (_hp < 0) _hp = 0;
    }

}
