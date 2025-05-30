using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public int numberOfCoins = 10;
    public Vector3 areaSize = new Vector3(20f, 0f, 20f);


    void Start()
    {
        for (int i = 0; i < numberOfCoins; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-areaSize.x / 2f, areaSize.x / 2f), 0.5f, Random.Range(-areaSize.z / 2f, areaSize.z / 2f));
            Instantiate(coinPrefab, spawnPosition, Quaternion.Euler(90, 0, 0));
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, areaSize);
    }
}
