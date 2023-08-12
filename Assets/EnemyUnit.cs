using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
    public GameObject pullZone;
    public GameObject rope;
    public int speed;
    public float strength;


    private float distance;

    void Start()
    {

    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, pullZone.transform.position);
        Vector2 direction = pullZone.transform.forward - transform.position;

        transform.position = Vector2.MoveTowards(transform.position, pullZone.transform.position, speed * Time.deltaTime);


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Triggering Right");
        rope.transform.position = rope.transform.position + Vector3.right * strength * Time.deltaTime;
    }
}



