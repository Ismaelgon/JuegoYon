using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject yon;
    void Update()
    {
        if(yon != null)
        {
        Vector3 position = transform.position;
        position.x = yon.transform.position.x;
        transform.position = position;
        }
    }
}
