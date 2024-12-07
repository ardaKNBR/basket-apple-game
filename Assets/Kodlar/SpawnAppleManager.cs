using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAppleManager : MonoBehaviour
{
    public GameObject applePrefab;
    public Transform spawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(applePrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
