using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {   
        float r = Random.Range(0.0f, 100.0f)/100;
        float b = Random.Range(0.0f, 100.0f)/100;
        float g = Random.Range(0.0f, 100.0f)/100;
        sr.color = new Color(r, g, b, 1);
    }
}
