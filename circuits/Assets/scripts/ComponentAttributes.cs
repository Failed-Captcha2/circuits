using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentAttributes : MonoBehaviour
{
    public float voltage;
    public float current;
    public GameObject[] contacts;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //update contacts array to remove objects when no longer colliding
    void OnCollisionExit2D(Collision2D collision) {

        //create copy of original array
        GameObject[] contactscopy = new GameObject[contacts.Length];
        for (int i = 0; i < contacts.Length; i++)
        {
            contactscopy[i] = contacts[i];
        }

        //decrement array size
        contacts = new GameObject[contacts.Length - 1];

        //copy back objects from copy array to original array, leaving out removed object
        int count = 0;
        for (int i = 0; i < contactscopy.Length; i++)
        {   if (contactscopy[i] != collision.gameObject)
            {
                contacts[count] = contactscopy[i];
                count++;
            }
        }

    }
    
    //update contacts array to add objects on collision enter
    void OnCollisionEnter2D(Collision2D collision)
    {   

        //create copy of original array
        GameObject[] contactscopy = new GameObject[contacts.Length];
        for (int i = 0; i < contacts.Length; i++)
        {
            contactscopy[i] = contacts[i];
        }

        //increment size of array
        contacts = new GameObject[contacts.Length + 1];

        //copy back all objects into original array
        for (int i = 0; i < contactscopy.Length; i++)
        {
            contacts[i] = contactscopy[i];
        }

        //add new contact to original array
        contacts[contacts.Length - 1] = collision.gameObject;
    }

}
