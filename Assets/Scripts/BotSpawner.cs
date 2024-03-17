using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _botPrefab;
    [SerializeField]
    private float _spawnTime = 8f;

    private void Awake()
    {
        StartCoroutine(SpawnProcess());
    }

    IEnumerator SpawnProcess()
    {
        
        for(;;)
        {
            Vector3 position = new Vector3(Random.Range(-5f,5f),0f,Random.Range(-5f,5f));
            Instantiate(_botPrefab, position,Quaternion.identity);
            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
