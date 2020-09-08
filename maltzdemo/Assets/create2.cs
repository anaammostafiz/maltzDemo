using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create2 : MonoBehaviour
{

    public GameObject Duplicate2;
    void OnMouseDown()
    {
        GameObject StandClone = Instantiate(Duplicate2);
        StandClone.transform.position = new Vector3(2, 2, 0);

    }
}
