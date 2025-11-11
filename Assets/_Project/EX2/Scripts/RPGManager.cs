using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Character> ListaCharacters = new List<Character>();

        Warrior Guerriero = new Warrior("Guerriero", 100);
        Mage Mago = new Mage("Mago", 50);
        Archer Arcere = new Archer("Arcere", 70);

        Warrior Monster = new Warrior("Mostro", 1000);

        ListaCharacters.Add(Guerriero);
        ListaCharacters.Add(Mago);
        ListaCharacters.Add(Arcere);
        
        foreach (Character character in ListaCharacters)
        {
            character.Attack(Monster);
            Debug.Log($"{Monster._nome} attaccato con hp rimanente = {Monster._hp}");
        }
    }
}
