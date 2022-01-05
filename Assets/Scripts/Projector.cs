using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projector : MonoBehaviour
{
   public GameObject particles;

    public void onTriggerEnter(Collider other)
    {   
        
        if (other.CompareTag("Player"))
        {
            particles.SetActive(true);
            Debug.Log("Particles?");
        }
    }

    public void onTriggerExit(Collider other)
    {
          if (other.CompareTag("Player"))
        {
            particles.SetActive(false);
            Debug.Log("Particles?");
        }
    }
}
