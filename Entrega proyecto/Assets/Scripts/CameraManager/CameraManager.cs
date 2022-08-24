using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
     public float mSensitivity = 250f ;
    public Transform PlayerBody;

    float YRotation = 0f;

    void Start()
    {
        Cursor.lockState= CursorLockMode.Locked;
    }

    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * mSensitivity * Time.deltaTime ;
        
        float MouseY = Input.GetAxis("Mouse Y")* mSensitivity* Time.deltaTime;
        
         YRotation = Mathf.Clamp(YRotation,-90f,90f);

        YRotation -= MouseY; 

        transform.localRotation = Quaternion.Euler(YRotation ,0,0);

        

        PlayerBody.Rotate(Vector3.up * MouseX);


    }



   
}
