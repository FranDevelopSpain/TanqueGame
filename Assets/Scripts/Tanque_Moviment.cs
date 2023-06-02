using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque_Moviment : MonoBehaviour
{
    public float velocidadAvance;
    public float velocidadRotacion;
    public Contador contador;
    public GameObject bala;
    public GameObject cañon;
    public float fuerzaDisparo;
    float cañonListo;
    public float cadencia;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (contador.haciaAtras == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0, 0, 1) * velocidadAvance * Time.deltaTime, Space.Self);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, 0, -1) * velocidadAvance * Time.deltaTime, Space.Self);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(new Vector3(0, -1, 0) * velocidadRotacion * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(new Vector3(0, 1, 0) * velocidadRotacion * Time.deltaTime);
            }

            cañonListo += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (cañonListo > cadencia)
                {
                    GameObject Disparo = Instantiate(bala, cañon.transform.position, cañon.transform.rotation);
                    Disparo.GetComponent<Rigidbody>().AddForce(Disparo.transform.forward * fuerzaDisparo);
                    cañonListo = 0;
                }
            }
        }
        else
        {

        }

    }



}

