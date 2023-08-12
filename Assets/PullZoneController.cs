using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullZoneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Is this on?");
        if (collision.tag == "Player")
        {
            Debug.Log("We have a collision");
        }
    }
}
