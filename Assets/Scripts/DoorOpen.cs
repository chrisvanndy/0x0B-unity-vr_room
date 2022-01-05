using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator DoorAnim;
    public AudioSource doormovement;
    public AudioSource verbalcue2;

    private int opens = 0;
    public void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("Player"))
        {   
            DoorAnim.SetBool("character_nearby", true);
            if (opens == 0)
            {
                verbalcue2.Play();
                opens++;
                Debug.Log(opens);
    
            }
            doormovement.Play();
            // particles.SetActive(true);
            Debug.Log("Door Opens");
            
        }   
    }

    public void OnTriggerExit(Collider other)
    {
         if (other.CompareTag("Player"))
        {
            DoorAnim.SetBool("character_nearby", false);
            doormovement.Play();
            // particles.SetActive(false);
            Debug.Log("Door Closes");
        }
    }

}
