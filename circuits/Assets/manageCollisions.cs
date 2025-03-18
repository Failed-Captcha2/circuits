using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageCollisions : MonoBehaviour
{
    public GameObject[] contacts;
    public GameObject[] wireContacts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addContact(GameObject contact)
    {
        //create copy of original array
        GameObject[] contactscopy = new GameObject[contacts.Length];
        for (int i = 0; i < contacts.Length; i++)
        {
            contactscopy[i] = contacts[i];
        }

        if (contact.tag == "wire")
        {
            //get opposite wire terminal contacts
            wireContacts = contact.GetComponentInParent<wire>().getContacts(contact);

            if (wireContacts != null)
            {
                //add wire contacts to contacts list
                for (int i = 0; i < wireContacts.Length; i++)
                {
                    addContact(wireContacts[i]);
                }
            }
        }
            else
            {
                //increment size of array
                contacts = new GameObject[contacts.Length + 1];

                //add new contact to original array
                contacts[contacts.Length - 1] = contact;
            }

        //copy back all objects into original array
        for (int i = 0; i < contactscopy.Length; i++)
        {
            contacts[i] = contactscopy[i];
        }

    }

    public void removeContact(GameObject contact)
    {
        //create copy of original array
        GameObject[] contactscopy = new GameObject[contacts.Length];
        for (int i = 0; i < contacts.Length; i++)
        {
            contactscopy[i] = contacts[i];
        }

        //decrement array size
        // Count the number of elements that will remain
        int newSize = 0;
        for (int i = 0; i < contacts.Length; i++)
        {
            if (contacts[i] != contact)
                newSize++;
        }

        // Create a new array with the correct size
        contacts = new GameObject[newSize];

        int index = 0;
        for (int i = 0; i < contacts.Length; i++)
        {
            if (contactscopy[i] != contact)
            {
                contacts[index] = contactscopy[i];
                index++;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        addContact(collision.gameObject);
    }

    //update contacts array to remove objects when no longer colliding
    void OnCollisionExit2D(Collision2D collision)
    {

        removeContact(collision.gameObject);

    }
}
