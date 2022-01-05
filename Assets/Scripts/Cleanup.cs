using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleanup : MonoBehaviour
{
   public GameObject box;
  
    public bool hit = false;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Blue") && (hit == false))
        {
            hit = true;
            Debug.Log("Blue Collision");
        }

         if (other.gameObject.CompareTag("Red") && (hit == false))
        {
            hit = true;
            Debug.Log("Red Collision");
        }

         if (other.gameObject.CompareTag("Green") && (hit == false))
        {
            hit = true;
            Debug.Log("Green Collision");
        }
         if (other.gameObject.CompareTag("Yellow") && (hit == false))
        {
            hit = true;
            Debug.Log("Yellow Collision");
        }
         if (other.gameObject.CompareTag("Orange") && (hit == false))
        {
            hit = true;
            Debug.Log("Orange Collision");
        }
         if (other.gameObject.CompareTag("Grey") && (hit == false))
        {
            hit = true;
            Debug.Log("Grey Collision");
        }
         if (other.gameObject.CompareTag("Purple") && (hit == false))
        {
            hit = true;
            Debug.Log("Purple Collision");
        }
    }
}

