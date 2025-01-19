using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistor : MonoBehaviour
{
    public float voltage;
    public float current;
    public float resistance;
    public Terminal[] terminals;

    // Start is called before the first frame update
    void Start()
    {
        voltage = -99;
        current = 0;
        terminals = GetComponentsInChildren<Terminal>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D( Collider2D collider){
        if (terminals[0].voltage != -99 && terminals[1].voltage != -99)
        {
            voltage = terminals[0].voltage - terminals[1].voltage;
            current = voltage / resistance;
        }
    }

}
