using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mBabyPrefabs;
    public int mSpawnTimer;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mSpawnTimer = Random.Range(0, 50);
        if (mSpawnTimer == 0)
        {
            int babyIndex = Random.Range(0, mBabyPrefabs.Length);
            Instantiate(mBabyPrefabs[babyIndex], new Vector3(0, 0, 0), mBabyPrefabs[babyIndex].transform.rotation);
            Instantiate(mBabyPrefabs[babyIndex], new Vector3(Random.Range(-15, 15), -6, 0), mBabyPrefabs[babyIndex].transform.rotation);
        }
    }
}
