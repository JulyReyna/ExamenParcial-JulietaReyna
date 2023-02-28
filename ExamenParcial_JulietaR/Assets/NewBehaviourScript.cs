using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
    
{
    public float force = 150;
    
    

    void Start()
    {
       
    }

    

    void Update()
    {
        float w = Input.GetAxis("Adelante");
        float s = Input.GetAxis("Atras");
        float a = Input.GetAxis("Izquierda");
        float d = Input.GetAxis("Derecha");

        Vector3 vector = new Vector3(w, 1.0f, s);


       
    }
}
