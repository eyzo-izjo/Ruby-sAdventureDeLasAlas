using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    //public ParticleSystem healEffect;
    public AudioClip collectedClip;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        //healEffect.Play();
        RubyController controller = other.GetComponent<RubyController>();
        
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
                {
                    
                    controller.ChangeHealth(1);
                    Destroy(gameObject);

                    controller.PlaySound(collectedClip);
                    
                }
            
        }
    }

    
}
