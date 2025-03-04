using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mBabyPrefabs;
    public int mSpawnTimer = Random.Range(2, 4);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mSpawnTimer -= deltaTime;
        if (mSpawnTimer = 0)
        {
            int babyIndex = Random.Range(0, mBabyPrefabs.Length);
            Instatiate(mBabyPrefabs[babyIndex], new Vector3(0, 0, 0), mBabyPrefabs[babyIndex].transform.rotation);
        }
        mSpawnTimer = Random.Range(2, 4);
    }
}
