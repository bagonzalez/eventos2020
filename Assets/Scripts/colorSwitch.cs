using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){

        GetComponent<Renderer>().material.color = Color.blue;
    }

     void OnCollisionExit(Collision collision){

        GetComponent<Renderer>().material.color = Color.red;
    }
}
