using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rth : MonoBehaviour
{
    public float resistance;
    public GameObject node1;
    public GameObject node2;
    public GameObject homeResistor;
    private manageCollisions collisionsNode1;
    private manageCollisions collisionsNode2;
    public int totalContacts;


    // Start is called before the first frame update
    void Start()
    {
        collisionsNode1 = node1.GetComponent<manageCollisions>();
        collisionsNode2 = node2.GetComponent<manageCollisions>();

    }

    // Update is called once per frame
    void Update()
    {
        //calculate number of contacts 
        totalContacts = 0;
        //contacts touching node 1
        for (int i = 0; i < collisionsNode1.contacts.Length; i++)
        {
            if (collisionsNode1.contacts[i] != null && collisionsNode1.contacts[i] != homeResistor && collisionsNode1.contacts[i].tag != "rth")
            {
                totalContacts++;
            }
        }
        //contacts touching node 2
        for (int i = 0; i < collisionsNode2.contacts.Length; i++)
        {
            if (collisionsNode2.contacts[i] != null && collisionsNode2.contacts[i] != homeResistor && collisionsNode2.contacts[i].tag != "rth")
            {
                totalContacts++;
            }
        }

        //delete rth if more than 2 contacts
        if (totalContacts > 2)
        {
            gameObject.SetActive(false);
        }
    }


}
