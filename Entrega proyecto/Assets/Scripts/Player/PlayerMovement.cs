using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
    
     

{
    [SerializeField ]float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftShift)){
            speed=6f;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            speed=4f;
        }
    }
}
