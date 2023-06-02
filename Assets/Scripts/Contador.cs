using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public float tiempo = 50;
    public bool haciaAtras = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (haciaAtras == true)
        {
            if (tiempo - Time.deltaTime > 0)
            {
                tiempo -= Time.deltaTime;

            }
            else
            {
                Debug.Log("Te has quedado sin gasolina");
                haciaAtras = false;
            }

        }
    }
}
