using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    float DestroyTime = 1f;
    private void DestroyObj(){
        Destroy(gameObject);
    }
    void Start()
    {
        Invoke("DestroyObj", DestroyTime );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }
}
