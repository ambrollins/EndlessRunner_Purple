using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour {

    public GameObject obstacle;
    public Player player;

    private void Start()
    {
        player.GetComponent<Player>().die();
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
