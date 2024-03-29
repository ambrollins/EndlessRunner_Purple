﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed;
    public float increment;
    public float maxY;
    public float minY;

    private Vector2 targetPos;

    public int health = 3;

    public GameObject moveEffect;
    public Animator camAnim;
    public Animator playerAnim;
    public Text healthDisplay;

    public GameObject spawner;
    public GameObject restartDisplay;

    public bool PowerupIsActivated = false;
    public bool isAlive = true;
    // public bool TimeForTimeScale1;

    private void Update()
    {

        if (health <= 0)
        {
            die();
        }

        healthDisplay.text = health.ToString();

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        // if (coll)

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
    public void ActivatePowerUp() //power up activation
    {
        PowerupIsActivated = true;
        playerAnim.SetTrigger("Invincible");
        Time.timeScale = 1.5f;
        StartCoroutine(PowerUpBoost());


    }
    IEnumerator PowerUpBoost()  //coroutine for delay of speed=1
    {
        yield return new WaitForSeconds(5f);
        Time.timeScale = 1;
        PowerupIsActivated = false;
    }
    public void ObstacleHit() //after hitting the obstacles
    {
        if (PowerupIsActivated == false)
        {
            health--;
            camAnim.SetTrigger("shake");
        }

    }
    public void die()
    {
        if (isAlive == true)
        {
            DelayForDeath();
            spawner.SetActive(false);
            restartDisplay.SetActive(true);
            Destroy(gameObject);
            isAlive = false;
        }
    }

    public void DeathTrigger()
    {
        Time.timeScale = .3f;
        playerAnim.SetTrigger("death");
        StartCoroutine(DelayForDeath());
    }
    IEnumerator DelayForDeath()  //coroutine for delay of speed=1
    {
        yield return new WaitForSeconds(5f);
        Time.timeScale = 1;
        isAlive = false;
    }
}
