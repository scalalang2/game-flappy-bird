using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float spawnOffset = 10;
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            float lowestPoint = transform.position.y - spawnOffset;
            float highestPoint = transform.position.y + spawnOffset;
            
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
        }
    }
}
