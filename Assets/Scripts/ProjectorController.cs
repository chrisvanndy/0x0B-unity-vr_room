using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorController : MonoBehaviour
{
    public GameObject particles;
    public GameObject light;
    public AudioSource congrats;
    public AudioSource whoosh;
   
   public void Particles()
   {
       particles.SetActive(true);
       light.SetActive(true);
       whoosh.Play();
       congrats.Play();

   }
}
