using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mBabyPrefabs;
    [Header("Cooldowns")]
    [Tooltip("Wait time between spawns")]
    [SerializeField] private float mSpawnTimer;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCycle());
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    IEnumerator SpawnCycle()
    {
        yield return new WaitForSeconds(mSpawnTimer);
        SpawnBaby();
        StartCoroutine(SpawnCycle());
    }


    private void SpawnBaby()
    {
        int babyIndex = Random.Range(0, mBabyPrefabs.Length);
        // Instantiate(mBabyPrefabs[babyIndex], new Vector3(0, 0, 0), mBabyPrefabs[babyIndex].transform.rotation);
        Instantiate(mBabyPrefabs[babyIndex], new Vector3(Random.Range(-15, 15), -6, 0), mBabyPrefabs[babyIndex].transform.rotation);

    }
}
