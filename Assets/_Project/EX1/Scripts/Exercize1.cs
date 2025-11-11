using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercize1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Proiettile> Proiettili = new List<Proiettile>();
        Freccia redarrow = new Freccia(100.0f, 15.0f);
        Freccia greenarrow = new Freccia(100.0f, 15.0f);
        PallaMagica magicball = new PallaMagica(10.0f, 15.0f);
        PallaMagica redmagicball = new PallaMagica(10.0f, 15.0f);


        Proiettili.Add(redarrow);
        Proiettili.Add(greenarrow);
        Proiettili.Add(magicball);
        Proiettili.Add(redmagicball);

        for (int i=0; i<Proiettili.Count; i++)
        {
            Proiettili[i].Lancia();
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
