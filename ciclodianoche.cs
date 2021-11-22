using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciclodianoche : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isDay;
    public Light myLight;
    public Material mat1;
    public Material mat2;
    void Start()
    {
        DiaNoche.evento_noche += noche;
        DiaNoche.evento_dia += dia;
        isDay = true;
    }
    void noche() {
       if (isDay) {
           RenderSettings.skybox = mat1;
           myLight.intensity = Mathf.PingPong(Time.time, 0.5f);
           isDay = false;
       }
    }

    void dia() {
       if (!isDay) {
           RenderSettings.skybox = mat2;
           Debug.Log("dia");
           isDay = true;
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
