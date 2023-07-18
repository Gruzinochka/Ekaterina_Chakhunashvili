using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLvl : MonoBehaviour
{
   public GameObject Screapt;
   public GameObject Screapt2;
   
   public void Enable()
   {
      Screapt.SetActive(true);
      Screapt2.SetActive(true);
      gameObject.SetActive(false);
   }
}
