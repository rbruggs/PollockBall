using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject cap;
    Vector3 spawnPos;

    public float MinX = -60;
    public float MaxX = 60;
    public float MinZ = -60;
    public float MaxZ = 60;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObj()
    {
        float x = Random.Range(MinX, MaxX);
        float z = Random.Range(MinZ, MaxZ);
        float y = 1.1f;

        Instantiate(cap, new Vector3(x, y, z), Quaternion.identity);
    }
}
