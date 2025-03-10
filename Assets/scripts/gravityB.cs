using System;
using UnityEngine;

public class gravityB : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
     rb = GetComponent<Rigidbody>();
     }

    void attrack(gravityB other)
    {
     Rigidbody otherRb = other.rb;
     Vector3 direction = rb.position - otherRb.position;
        
     // get distance in meter
     float distance = direction.magnitude;
     
     // calculate gravity force
     float forceMagnitude = 
    }
    
    
    
}
