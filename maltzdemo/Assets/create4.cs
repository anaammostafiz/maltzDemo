using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create4 : MonoBehaviour
{

    public GameObject Duplicate4;
    void OnMouseDown()
    {
        GameObject arrayClone = Instantiate(Duplicate4);
        arrayClone.transform.position = new Vector3(2, 2, -4);

    }
}
