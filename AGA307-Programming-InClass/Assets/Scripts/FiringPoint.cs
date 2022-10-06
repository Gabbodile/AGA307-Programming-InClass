using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class FiringPoint : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject hitSparks;
    public LineRenderer laser;
    public float projectileSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        //left click
        if (Input.GetButtonDown("Fire1"))
        {
            fireRigProjectile();
        }
        //right click
        if (Input.GetButtonDown("Fire2"))
        {
            fireRaycast();
        }
    }

    void fireRigProjectile()
    {
        //create a reference to hold our instantiated object. Create object
        GameObject projectileInstance;

        //instandiate our projectile prefab
        projectileInstance = Instantiate(projectilePrefab, transform.position, transform.rotation);

        //GetComponent the rigidbody attatched and add force to it
        projectileInstance.GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed);
    }

    void fireRaycast()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.Log("We hit " + hit.collider.name + " at point " + hit.point + " which was " + hit.distance + " units away.");
            laser.SetPosition(0, transform.position);
            laser.SetPosition(1, hit.point);
            GameObject party = Instantiate(hitSparks, hit.point, transform.rotation);
            Destroy(party, 2);
        }
    }
}
