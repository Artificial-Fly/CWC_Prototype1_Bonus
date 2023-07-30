using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    public GameObject[] cameras = new GameObject[4];//get cameras
    private bool mainCamera1 = true;//true if used main camera
    private bool mainCamera2 = true;//true if used main camera
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate(){
        if(Input.GetKeyDown(KeyCode.F)){
            if(mainCamera1){
                cameras[0].gameObject.SetActive(false);
                cameras[1].gameObject.SetActive(true);
                mainCamera1=false;
            }else{
                cameras[1].gameObject.SetActive(false);
                cameras[0].gameObject.SetActive(true);
                mainCamera1=true;
            }
        }
        if(Input.GetKeyDown(KeyCode.Keypad5)){
            if(mainCamera2){
                cameras[2].gameObject.SetActive(false);
                cameras[3].gameObject.SetActive(true);
                mainCamera2=false;
            }else{
                cameras[3].gameObject.SetActive(false);
                cameras[2].gameObject.SetActive(true);
                mainCamera2=true;
            }
        }
    }
}
