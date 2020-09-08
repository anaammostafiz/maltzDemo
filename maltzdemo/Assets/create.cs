using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{

    public GameObject Duplicate;
    void OnMouseDown()
    {
            GameObject ChairClone = Instantiate(Duplicate);
        ChairClone.transform.position = new Vector3(3, 3, -2);
    
    }
}
