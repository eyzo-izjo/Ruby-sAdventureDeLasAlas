using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class HealthCollectible : MonoBehaviour
{
    public GameObject healEffect;
    public AudioClip collectedClip;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
       
        RubyController controller = other.GetComponent<RubyController>();
      
        
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
                {

                    
                    controller.ChangeHealth(1);
                    G=nstantiate(healEffect, rigidbody2d.position, Quaternion.identity);
                    Destroy(gameObject);

                    controller.PlaySound(collectedClip);
                    
                }
            
        }
    }

    //public void PlayPS(ParticleSystem ps)
    
      //  ParticleSystem.PlayOneShot(ps);
    
}
