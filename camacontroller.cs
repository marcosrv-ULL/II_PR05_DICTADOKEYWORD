using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camacontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isMade = true;
    public GameObject jugador1;
    public GameObject blanket;
    void Start()
    {
        Cama.deshacer += mostrar;
        Cama.hacer += ocultar;
    }
    void mostrar() {
       float distanceP1 = Vector3.Distance(transform.position, jugador1.transform.position);
       if (distanceP1 < 4 && isMade) {
            blanket.SetActive(false);
            isMade = false;
        }
    }

    void ocultar() {
       float distanceP1 = Vector3.Distance(transform.position, jugador1.transform.position);
       if (distanceP1 < 4 && !isMade) {
            blanket.SetActive(true);
            isMade = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
