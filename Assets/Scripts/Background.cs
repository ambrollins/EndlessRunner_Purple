using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MovingParts {

    public float Xend;
    public float Xstart;
    public bool ActivatePowerUp = false;

    public override void MoveObject()
    {
        if (ActivatePowerUp!)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x < Xend)
            {
                Vector2 pos = new Vector2(Xstart, transform.position.y);
                transform.position = pos;
            }
        }
        else
        {
            transform.Translate(Vector2.left * (speed + 10 ) * Time.deltaTime);
            if (transform.position.x < Xend)
            {
                Vector2 pos = new Vector2(Xstart, transform.position.y);
                transform.position = pos;
            }
        }

    }

    
}
