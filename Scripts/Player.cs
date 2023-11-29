using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Player : MonoBehaviour
{
    public int health;
    public GameObject labirint;
	[SerializeField]
    private Vector3 pointRespawn;

    private void Start()
    {
        pointRespawn = transform.position;
        labirint = GameObject.Find("Labirint").gameObject;
        labirint.transform.rotation = new Quaternion(0, 0, 0, 1);
    }
    public void Respawn()
    {
		labirint.transform.rotation = new Quaternion(0, 0, 0, 1);
        transform.position = pointRespawn;   
    }
}
