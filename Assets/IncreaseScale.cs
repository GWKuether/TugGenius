using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScale : MonoBehaviour
{
    public GameObject giant;
    private Vector3 scaleChange;


    void Start()
    {
        scaleChange = new Vector3(0.01f, 0.01f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        giant.transform.localScale += scaleChange;

    }
}
