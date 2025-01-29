using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public ComponentAttributes component;
    public ComponentAttributes other;

    void Start()
    {
        component = GetComponent<ComponentAttributes>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < component.contacts.Length; i++)
        {
            other = component.contacts[i].GetComponent<ComponentAttributes>();
            component.voltage = other.voltage;
            if (other.current != 0)
            {
                component.current = other.current;
            }
        }

    }


}
