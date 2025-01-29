using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VoltageSource : MonoBehaviour
{
    public float voltage;
    public ComponentAttributes negativeTerminal;
    public ComponentAttributes positiveTerminal;
    public TextMeshPro label;
    // Start is called before the first frame update
    void Start()
    {
        label = GetComponentInChildren<TextMeshPro>();
        label.text = voltage.ToString("F2") + "V";
    }

    // Update is called once per frame
    void Update()
    {
        positiveTerminal.voltage = negativeTerminal.voltage + voltage;
        positiveTerminal.current = negativeTerminal.current;
    }

}
