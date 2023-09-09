using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody rb;

    [Range(10, 30)]

    public float velocidad = 20;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.velocity = transform.forward*velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
