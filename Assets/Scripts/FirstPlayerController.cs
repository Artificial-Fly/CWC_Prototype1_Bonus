using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    private float speed = 7.5f;//vehicle's speed
    private float turnSpeed = 8.5f;//vehicle's speed
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get player's input
        horizontalInput = Input.GetAxis("Horizontal1");
        forwardInput = Input.GetAxis("Vertical1");
        //Move the vehicle forward
        //transform.Translate(0,0,1);//move every frame
        //transform.Translate(Vector3.forward);//move every frame
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);//move every second instead of every frame
        //transform.Translate(Vector3.right*Time.deltaTime*turnSpeed*horizontalInput);//move vehicle left or right
        //transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed*horizontalInput);//turn vehicle left or right
        transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed*horizontalInput*forwardInput);//turn vehicle left or right, but only when vehicle moves
        
        

    }
    
}
