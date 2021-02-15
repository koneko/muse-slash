using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tophit : MonoBehaviour
{
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            Debug.Log("I touch top");

        }


    }
    */


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Note"))
        {
            Debug.Log("Big sad note here");
        }
    }

}
