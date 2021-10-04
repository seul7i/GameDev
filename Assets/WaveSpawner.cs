using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5.5f;
    private float coundown = 2f;

    public Text waveCountDownText;


    private int waveIndex = 0;
    void Update()
    {
        if(coundown <= 0f)
        {
            //start spwaing
            StartCoroutine(SpawnWave());
            coundown = timeBetweenWaves;
        }

        coundown -= Time.deltaTime;

        waveCountDownText.text = Mathf.Round(coundown).ToString();
    }
    IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
