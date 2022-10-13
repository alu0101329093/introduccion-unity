using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayHello : MonoBehaviour
{
  public string objectName;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    Debug.Log("Soy un " + objectName);
  }
}
