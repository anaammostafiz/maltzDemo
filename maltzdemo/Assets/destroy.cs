﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "trash")
        {
            Destroy(gameObject);
        }
            
    }
}
