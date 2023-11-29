using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    //Скрипт для вращения лабиринта

    public float speed = 3f;
    public Joystick joystick;
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(0, 0, speed * Input.GetAxis("Horizontal"));
        }
        if (joystick.Horizontal != 0)
        {
            transform.Rotate(0, 0, speed * joystick.Horizontal);
        }
    }
}
