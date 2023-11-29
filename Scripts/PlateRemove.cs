using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateRemove : MonoBehaviour
{
    public GameObject obj;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(obj, 1);
    }
}
