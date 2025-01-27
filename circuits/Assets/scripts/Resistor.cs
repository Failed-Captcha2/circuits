using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistor : MonoBehaviour
{
    // Start is called before the first frame update
    public float voltage;
    public float current;
    public float resistance;
    public ComponentAttributes leftTerminal;
    public ComponentAttributes rightTerminal;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        voltage = leftTerminal.voltage - rightTerminal.voltage;
        current = voltage / resistance;
        leftTerminal.current = current;
        rightTerminal.current = current;
    }

}
