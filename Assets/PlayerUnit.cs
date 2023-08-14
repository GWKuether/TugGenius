using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public GameObject pullZone;
    public GameObject rope;
    public int speed;
    public float strength;
    private float distance;

    void Start()
    {

    }

    public void Update()
    {
        distance = Vector2.Distance(transform.position, pullZone.transform.position);
        Vector2 direction = pullZone.transform.forward - transform.position;

        transform.position = Vector2.MoveTowards(transform.position, pullZone.transform.position, speed * Time.deltaTime);


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Triggering Left");
        rope.transform.position = rope.transform.position + Vector3.left * strength * Time.deltaTime;
    }
}


