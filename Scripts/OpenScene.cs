using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(CircleCollider2D))]
public class OpenScene : MonoBehaviour
{
    public int sceneId;
    private void Start()
    {
        sceneId = SceneManager.GetActiveScene().buildIndex + 1;
        gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(sceneId);
    }
}
