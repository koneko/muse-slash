using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomhit : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Note"))
        {
            Debug.Log("bottom noteeeeee");
        }
    }
}
