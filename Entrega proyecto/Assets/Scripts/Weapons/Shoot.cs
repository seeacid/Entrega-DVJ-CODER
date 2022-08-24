using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform bulletSpawn;
    public GameObject bullet ; 
    private AudioSource audioSource;

    public float shootForce = 1500f ;
    public float cd = 1f ; 

    private float cdActive = 0f ;

    public AudioClip shootFx;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(shootFx);

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0)&& Time.time > cdActive){

            if(WorldManager.Instance.AkAmmo > 0){
            GameObject newBullet ; 
            
            audioSource.PlayOneShot(shootFx);
            newBullet = Instantiate(bullet,bulletSpawn.position, bulletSpawn.rotation);

            newBullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward*shootForce);

            cdActive = Time.time + cd ;

            WorldManager.Instance.AkAmmo -= 1;
            }
        }
        
    }



}
