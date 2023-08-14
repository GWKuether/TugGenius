using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScale : MonoBehaviour
{
    public GameObject giant;
    private Vector3 scaleChange;
    public float scaleSize;
    public GameObject pullZone;
    public GameObject rope;
    public int speed;
    public float strength;
    private float distance;
    private bool growing = true;



    void Start()
    {
        scaleChange = new Vector3(0.01f, 0.01f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Grow();
        if (growing == false)
        {
            SeekRope();
        }

    }

    

    public void Grow()
    {
        if (growing == true)
        {
            giant.transform.localScale += scaleChange;
            Vector3 fullSize = new Vector3(scaleSize, scaleSize, 0);
            Debug.Log(giant.transform.localScale);
            if (giant.transform.localScale == fullSize)
            {
                Debug.Log("Cut");
                growing = false;
            }

        }


    }
    public void SeekRope()
    {
        distance = Vector2.Distance(transform.position, pullZone.transform.position);
        Vector2 direction = pullZone.transform.forward - transform.position;

        transform.position = Vector2.MoveTowards(transform.position, pullZone.transform.position, speed * Time.deltaTime);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Big boi on rope");
        rope.transform.position = rope.transform.position + Vector3.left * strength * Time.deltaTime;
    }
}
