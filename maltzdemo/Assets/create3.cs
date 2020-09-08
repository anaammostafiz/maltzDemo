using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create3 : MonoBehaviour
{

    public GameObject Duplicate3;
    void OnMouseDown()
    {
        GameObject TableClone = Instantiate(Duplicate3);
        TableClone.transform.position = new Vector3(3, 4, 5);

    }
}
