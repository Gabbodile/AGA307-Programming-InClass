using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TriggerPad : MonoBehaviour
{
    //DONT FORGET TO CALL THE OBJECT INTO THE SCRIPT
    public GameObject sphere;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("In trigger");
        if (other.CompareTag("Player"))
        {
            //change colour of the sphere. The GameObject is the sphere
            sphere.GetComponent<Renderer>().material.color = Color.red;

            //Acknowledge player and open door

        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("staying");
        if (other.CompareTag("Player"))
        {
            //change size of the sphere by 0.01f
            sphere.transform.localScale += Vector3.one * 0.01f;

            //Open door

        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        //revert to original
        if (other.CompareTag("Player"))
        {
            sphere.transform.localScale = Vector3.one;
            sphere.GetComponent<Renderer>().material.color = Color.white;

            //Close the door

        }
    }
}
