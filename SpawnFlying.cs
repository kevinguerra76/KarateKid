using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class FlyingSpawner : MonoBehaviour
{
    public GameObject FlyingObstaclePrefab;
    public float spawnInterval = 6f;
    public Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        // Start spawning cacti
        StartCoroutine(SpawnCacti());
    }

    IEnumerator SpawnCacti()
    {
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        while (true)
        {
            // Instantiate a new cactus at the spawner's position
            GameObject obj = Instantiate(FlyingObstaclePrefab) as GameObject;
            obj.transform.position = new Vector2(25, -0.5f);

            // Wait for the specified interval before spawning the next cactus
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}