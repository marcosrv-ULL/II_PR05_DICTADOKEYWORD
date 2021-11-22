using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject puerta1;
    public GameObject jugador1;
    private bool isOpen;
    void Start()
    {
        abrirPuertas.evento_abrir += abrirPuerta;
        abrirPuertas.evento_cerrar += cerrarPuerta;
        isOpen = false;
    }

    void abrirPuerta() {
       float distanceP1 = Vector3.Distance(transform.position, jugador1.transform.position);
       float distanceP2 = Vector3.Distance(transform.position, jugador1.transform.position);
       if (distanceP1 < 3 && !isOpen) {
            transform.rotation = transform.rotation * Quaternion.Euler(0, 90, 0);
            isOpen = true;
        }
    }

    void cerrarPuerta() {
       float distanceP1 = Vector3.Distance(transform.position, jugador1.transform.position);
       float distanceP2 = Vector3.Distance(transform.position, jugador1.transform.position);
       if (distanceP1 < 3 && isOpen) {
            transform.rotation = transform.rotation * Quaternion.Euler(0, -90, 0);
            isOpen = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}