using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMobVehicle : MonoBehaviour
{
    private float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(2.5f,5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
