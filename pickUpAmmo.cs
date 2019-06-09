using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpAmmo : MonoBehaviour
{
      private  GameObject thePlayer;
       private IDictionary<string, int> ammos;
        void Start()
    {
        
       
    }     

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("entered");
        thePlayer= GameObject.FindGameObjectWithTag("Player");
        if(other.gameObject.CompareTag("ammo")){
            other.gameObject.SetActive(false);
            ammos = thePlayer.GetComponent<PLayerController> ().ammoCounts;
            ammos[other.gameObject.name] = ammos[other.gameObject.name] + 1;
            Debug.Log(ammos[other.gameObject.name]);
        
        
        }
    }

}
