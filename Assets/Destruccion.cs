﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("DestrucTrig"))
        {
            Destroy(other.gameObject);
        }
    }
}
