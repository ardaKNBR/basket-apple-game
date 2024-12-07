using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxManager : MonoBehaviour
{
    public GameObject boxPrefab;
    public Transform[] spawnPoint;
    public static SpawnBoxManager instance;

    public void Awake()
    {
        instance = this;
    }
    public void SpawnBox()
    {
        int index = Random.Range(0, spawnPoint.Length);
        Instantiate(boxPrefab, spawnPoint[index].position, Quaternion.identity);
    }
}