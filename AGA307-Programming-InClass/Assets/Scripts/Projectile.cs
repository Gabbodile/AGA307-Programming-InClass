using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Target"))
        {
            //changes colour
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
           //destroys the collision object
            Destroy(collision.gameObject, 1);
            //Destroys this object
            Destroy(gameObject);
        }
    }
}
