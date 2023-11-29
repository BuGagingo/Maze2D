using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSpawner : MonoBehaviour
{
    public List<GameObject> objs;
    public float width = 12;
    public float intervalSpawn = 1;
    public bool isReadySpawn = true;
    public int maxCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isReadySpawn)
        {
            isReadySpawn = false;
            int c = Random.Range(0, maxCount);
            for (int i = 0; i < c; i++)
            {
                Invoke("Spawn", i);
            }
            StartCoroutine(Reload());
        }
    }

    void Spawn()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        int r = Random.Range(0, objs.Count-1);
        Vector3 pos = new Vector3(Random.Range(posX-width,posX+width), posY, 0);
        GameObject newObject = Instantiate(objs[r], pos, transform.rotation);
        Destroy(newObject, 12);
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(Random.Range(intervalSpawn-0.2f, intervalSpawn+1));
        isReadySpawn = true;
    }
}
