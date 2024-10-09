using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public PlayerController playerOver;
    // Start is called before the first frame update
    void Start()
    {
        playerOver = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("spawn", 1, 3);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        if (!playerOver.gameOver)
            Instantiate(prefab, spawnPos, prefab.transform.rotation);
    }
}
