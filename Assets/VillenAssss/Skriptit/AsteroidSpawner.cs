using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject[] Asteroid;
    public Vector3 spawnValue;
    public int waveCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < waveCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Asteroid[Random.Range(0, Asteroid.Length)], spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }

            //yield return new WaitForSeconds(waveWait);
        }

    }

}
