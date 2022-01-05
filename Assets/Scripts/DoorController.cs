using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Door Controller Class listens for collisions needed to solve
/// the first puzzle.  This class handles sound effects and colliders
/// in the storage room area of the Mars Escape VR Experience.
public class DoorController : MonoBehaviour
{
    public GameObject DoorTrigger;
    public GameObject AccessDenied;
    public GameObject AccessGranted;

    public AudioSource poweringOn;
    public AudioSource verbalcue;

    public bool solved = false;
  
    public GameObject[] colors = new GameObject[7];

    /* public GameObject particles; */
  
    void Update()
    {
        // listen for solve of 1st puzzle
        if (solved == false)
            CheckAllClean(colors);
       
    }

    void CheckAllClean(GameObject[] colors)
    {
        int all = 0;

        Debug.Log("Made it into CHECKALLCLEAN");
        // check component has made colission with match
        foreach (GameObject color in colors)
        {
            if (color.GetComponent<Cleanup>().hit == true)
            {
                Debug.Log(all);
                all += 1;
            }
        }
        // if all 7 have made collision
        if (all == 7)
        {
            // activate trigger collider for door anim
            // change UI on info panels
            // stop listening for collisions
            // play UX cues and sound effects

            DoorTrigger.SetActive(true);
            AccessGranted.SetActive(true);
            AccessDenied.SetActive(false);
            solved = true;
            poweringOn.Play();
            verbalcue.Play();
        }
    } 
}
