using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Cameras ;
    private int CameraOn = 0;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.V)){
            ToggleCamera();
        }
    }

    void ToggleCamera(){

         switch(CameraOn){
            case 0:
                Cameras[0].SetActive(true);
                Cameras[1].SetActive(false);
                CameraOn = 1;
            break;
            case 1:
                Cameras[0].SetActive(false);
                Cameras[1].SetActive(true);
                CameraOn = 0;
            break;
                
         }


        /* if(CameraOn == 0){
            Cameras[0].SetActive(true);
            Cameras[1].SetActive(false);
            CameraOn = 1;
        }else{
            Cameras[0].SetActive(false);
            Cameras[1].SetActive(true);
            CameraOn = 0;
        } */
    }
}
