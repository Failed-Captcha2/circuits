using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour
{
  public string connecting;
  public string direction;
  public Terminal other;
  public float voltage;
  // Start is called before the first frame update
  void Start()
  {
    voltage = -99;

  }

  // Update is called once per frame
  void Update()
  {

  }
  void OnTriggerStay2D(Collider2D collider)
  {

    connecting = collider.name;
    float colliderVoltage = -99;
    if (collider.GetComponent<Terminal>() == null)
    {
      direction = "negative";
      other.direction = "positive";
      colliderVoltage = 0;
      voltage = 0;
    }
    else if (collider.GetComponent<Terminal>().direction == "positive")
    {
      direction = "negative";
      other.direction = "positive";
      colliderVoltage = collider.GetComponent<Terminal>().voltage;
    }
    else if (collider.GetComponent<Terminal>().direction == "negative")
    {
      direction = "positive";
      other.direction = "negative";
      colliderVoltage = collider.GetComponent<Terminal>().voltage;

    }
    
    if (colliderVoltage != -99)
    {
      voltage = colliderVoltage;
    }

  }
}
