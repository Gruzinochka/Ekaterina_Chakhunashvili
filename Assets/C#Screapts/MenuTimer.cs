using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuTimer : MonoBehaviour
{
  public Text Record;
  public float Rec;

  public void Start()
  {
    if (PlayerPrefs.HasKey("NewMax"))
    {
      Rec = PlayerPrefs.GetFloat("NewMax");
      if (Convert.ToDouble(Record.text) < Rec)
      {
        Record.text = Rec.ToString();
      }
    }
  }
  


}
