using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFactory
{
    SnackProduct SP;
    GhostProduct GP;

    InterfaceProduct CreateObject(string objectType)
    {
        switch(objectType)
        {
            case "snack":
                return new SnackProduct();
            case "Ghost":
                return new GhostProduct();
            default:
                return null;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
