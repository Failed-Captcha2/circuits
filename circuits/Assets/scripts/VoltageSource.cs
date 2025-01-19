using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VoltageSource : MonoBehaviour
{
    public float voltage;
    public float current;
    public Terminal negative;
    public Terminal positive;
    public TextMeshPro label;
    // Start is called before the first frame update
    void Start()
    {
        label = GetComponentInChildren<TextMeshPro>();
        label.text = voltage.ToString("F2") + "V";
        positive.voltage = negative.voltage + voltage;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay2D(Collider2D collider){
        positive.voltage = negative.voltage + voltage;
    }
}
