using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    public AudioClip Scream;
    public Animator zombieAnimator ;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("bullet")){
            audioSource.PlayOneShot(Scream);
            zombieAnimator.SetBool("isDead",true);

            Invoke("DestroyEnemy",.8f);
        }
    }


    private void DestroyEnemy(){


        Destroy(this.gameObject);


    }}
