using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}

