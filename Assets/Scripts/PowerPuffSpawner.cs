using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPuffSpawner : MonoBehaviour
{

    public GameObject PowerPuff;

    private void Start()
    {
        Instantiate(PowerPuff, transform.position, Quaternion.identity);
    }
}
