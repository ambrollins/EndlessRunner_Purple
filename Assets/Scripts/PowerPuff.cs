using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPuff : MovingParts
{
    public GameObject PPEffect;
 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //other.GetComponent<Player>().health--;
            other.GetComponent<Player>().ActivatePowerUp();
            Instantiate(PPEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);   
                        
        }
        
        if (other.tag == "Obstacle")
        {
            Destroy(other.gameObject);
        }
        
    }
}
