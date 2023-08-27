using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject greatCircle;
    public GameObject spawnLocation;
    public void GameOverScene()
    {
        greatCircle.GetComponent<GreatCircle>().enabled = false;
        spawnLocation.GetComponent<SpawnLocation>().enabled = false;
    }
}
