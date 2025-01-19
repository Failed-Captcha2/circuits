using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    // Start is called before the first frame update
    public float current;
    public Terminal[] terminals;
    public Collider2D other;

    void Start()
    {
        terminals=GetComponentsInChildren<Terminal>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collider){
        if (terminals[0].voltage != -99){
            terminals[1].voltage = terminals[0].voltage;
        }
        else if (terminals[1].voltage != -99){
            terminals[0].voltage = terminals[1].voltage;
        }
    }
}
