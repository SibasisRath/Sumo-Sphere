using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemy;
    [SerializeField] private GameObject[] _powerUp;
    private int _enemyCount;
    private int _waveNumber;
    // Start is called before the first frame update
    void Start()
    {
        _enemyCount = 0;
        _waveNumber = 0;
        InvokeRepeating("PowerUpSpawner",0,20);
       
    }

    private Vector3 GenerateSpawnPosition()
    {
        float x = UnityEngine.Random.Range(-9f,9f);
        float z = UnityEngine.Random.Range(-9f, 9f);
        return new Vector3(x,0,z);
    }

    private void EnemyWave(int waveNumber)
    {

        for (int i = 0; i<=waveNumber; i++)
        {
            Instantiate(_enemy[UnityEngine.Random.Range(0,_enemy.Length)], GenerateSpawnPosition(), _enemy[UnityEngine.Random.Range(0, _enemy.Length)].transform.rotation);
        }
        _waveNumber++;
       
    }

    // Update is called once per frame
    void Update()
    {
        _enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (_enemyCount == 0)
        {
            EnemyWave(_waveNumber);
        }
    }

    private void PowerUpSpawner()
    {
        Instantiate(_powerUp[UnityEngine.Random.Range(0, _powerUp.Length)], GenerateSpawnPosition(), _powerUp[0].transform.rotation);
    } 
}
