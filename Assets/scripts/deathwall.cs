using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathwall : MonoBehaviour
{

    public GameObject notePrefabBottom;
    public GameObject notePrefabTop;
    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "Death")
            {
                Destroy(notePrefabBottom);

            }

            if (collision.gameObject.tag == "Death")
            {
                Destroy(notePrefabTop);

            }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
