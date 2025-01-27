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
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        other = collision.gameObject.GetComponent<ComponentAttributes>();
        component.voltage = other.voltage;
        component.current = other.current;
       

    }

}
