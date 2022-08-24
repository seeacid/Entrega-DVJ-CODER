using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update

        private void OnTriggerEnter(Collider other) {
            if(other.gameObject.CompareTag("AmmoBox") && WorldManager.Instance.AkAmmo < 30){
                WorldManager.Instance.AkAmmo = other.gameObject.GetComponent<AmmoBox>().ammo;
                Destroy(other.gameObject);
            }
        }
    
}
