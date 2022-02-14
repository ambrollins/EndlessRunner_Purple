using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score = 0;
    public Text scoreDisplay;

    private void Update()
    {
        scoreDisplay.text = score.ToString("SCORE :0");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);

    }

    
}
