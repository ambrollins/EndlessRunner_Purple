using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MovingParts {


    public GameObject effect;

	

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<Player>().ObstacleHit();
            Instantiate(effect, transform.position, Quaternion.identity);
           // Destroy(gameObject);
        }   
    }
}
