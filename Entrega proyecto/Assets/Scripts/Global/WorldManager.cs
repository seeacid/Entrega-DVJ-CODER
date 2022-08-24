using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorldManager : MonoBehaviour
{
   
   public static WorldManager Instance {get; private set;}
    public TextMeshProUGUI AmmoCounter ;

   public int AkAmmo = 30 ;

   private void Update(){
        AmmoCounter.text = AkAmmo.ToString()+"/30";
   }

private void Awake() {
    Instance = this;
   }
}
