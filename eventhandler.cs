using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class eventhandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            controllercommand.keywordsstart();
            Debug.Log("Keyword starting!!");
        }
        if (Input.GetKeyDown("l"))
        {
            controllercommand.keywordsstop();
            Debug.Log("Keyword stop!!");
        }
        if (Input.GetKeyDown("n"))
        {
            controllercommand.dictadostart();
            Debug.Log("Dictation starting!!");
        }
        if (Input.GetKeyDown("m"))
        {
            controllercommand.dictadostop();
            Debug.Log("Dictation stop!!");
        }
    }
}

public static class controllercommand {
    public static Action keywordsstart;
    public static Action keywordsstop;
    public static Action dictadostart;
    public static Action dictadostop;
}