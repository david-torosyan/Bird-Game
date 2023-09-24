using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 4;
    private float timer = 0;
    private float heigthOffSet = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCloud();

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
            SpawnCloud();
            timer = 0;
        }
    }

    public void SpawnCloud()
    {
        float lowestPoint = cloud.transform.position.y - heigthOffSet;
        float higestPoint = cloud.transform.position.y + heigthOffSet;
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, higestPoint)), transform.rotation);

    }
}
