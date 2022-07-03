using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public GameObject obstaclePrefab;
    private PlayerControll playerControllerScript;
    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControll>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
