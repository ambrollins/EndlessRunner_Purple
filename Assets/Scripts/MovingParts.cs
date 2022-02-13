using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingParts : MonoBehaviour
{
    public float speed;
    //   public GameObject effect;

    void Update()
    {
        MoveObject();
    }

    public virtual void MoveObject()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
