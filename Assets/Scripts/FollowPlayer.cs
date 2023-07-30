using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;//select player's vehicle in the insperctor
    private Vector3 offset;// = new Vector3(0, 6, -9);//camera's offset from player's vehicle

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    //void Update()//camera has stuttering effect as position updates too frequently 
    //as both camera and vehicle change pos-s at the same time because both use Update
    void LateUpdate()//camera hasn't stuttering effect as LateUpdate happens after Update 
    {
        //move camera with player's vehicle
        transform.position = player.transform.position + offset;
    }
}
