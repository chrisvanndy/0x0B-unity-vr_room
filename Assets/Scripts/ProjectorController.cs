using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorController : MonoBehaviour
{
    public GameObject particles;
    public GameObject light;
   
   public void Particles()
   {
       particles.SetActive(true);
       light.SetActive(true);
   }
}
