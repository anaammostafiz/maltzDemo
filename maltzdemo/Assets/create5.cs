using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create5 : MonoBehaviour
{

    public GameObject Duplicate5;
    void OnMouseDown()
    {
        GameObject monitorClone = Instantiate(Duplicate5);
        monitorClone.transform.position = new Vector3(2, 2, -7);

    }
}
