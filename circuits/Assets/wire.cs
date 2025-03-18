using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wire : MonoBehaviour
{
    public float current;
    public GameObject[] terminals;
    //TODO: move all collision boxes of wire contacts to the same spot
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject[] getContacts(GameObject terminal)
    {
        if (terminal == terminals[0])
        {
            return terminals[1].GetComponent<manageCollisions>().contacts;
        }
        else if (terminal == terminals[1])
        {
            return terminals[0].GetComponent<manageCollisions>().contacts;
        }
        Debug.Log("get contacts failed!" + terminal.name);
        return null;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<manageCollisions>().addContact(gameObject);
    }
}
