using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _botPrefab;
    [SerializeField]
    private float _spawnDamp = 8f;
    [SerializeField]
    private Text _counter;

    public int deadMobCount = 0;

    private void Awake()
    {
        StartCoroutine(SpawnProcess());
    }

    private void Update() 
    {
        _counter.text = deadMobCount.ToString();
    }

    IEnumerator SpawnProcess()
    {
        
        for(;;)
        {
            Vector3 position = new Vector3(Random.Range(-5f,5f),0f,Random.Range(-5f,5f));
            Instantiate(_botPrefab, position,Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(_spawnDamp-4,_spawnDamp+4));
        }
    }
}
