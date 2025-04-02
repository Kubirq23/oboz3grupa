using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1.0f;
    [SerializeField]private Vector2 spawnR;

    [SerializeField] private GameObject[] enemyPrefab;

    [SerializeField] private bool canSpawn = true;
    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn)
        {
            yield return wait;
            Vector3 pos = new Vector3();
            int rand = Random.Range(0, enemyPrefab.Length);
            GameObject enemyToSpawn = enemyPrefab[rand];
            MainManager.instance.AddEnemy();
            if(spawnR.x == 0) pos.y = Random.Range(-spawnR.y,spawnR.y);
            if(spawnR.y == 0) pos.x = Random.Range(-spawnR.x,spawnR.x);
            Instantiate(enemyToSpawn, transform.position + pos, Quaternion.identity);
        }
    }
    public void stop(){
        canSpawn = false;
    }
    public void start(){
        canSpawn = true;
    }

}
