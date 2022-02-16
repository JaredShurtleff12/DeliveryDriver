using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oops, I bumped into a circle!");
    }
    void OnTriggerEnter2D(Collider2D other) {
        // if (the thing we trigger is the package){
        // then print "package picked up" to the console
        //  }
        if (other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer" && hasPackage){
            Debug.Log("Package Delivered!");
            hasPackage = false;
        }
    }
}
