using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 4;
    private float timer = 0;
    private float heigthOffSet = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
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
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = pipe.transform.position.y - heigthOffSet;
        float higestPoint = pipe.transform.position.y + heigthOffSet;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint, higestPoint)), transform.rotation);

    }
}
