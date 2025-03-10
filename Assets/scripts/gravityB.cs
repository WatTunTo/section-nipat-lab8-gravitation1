using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class gravityB : MonoBehaviour
{
    private Rigidbody rb;
    const float G = 0.006674f;
    public static List<gravityB> planetList;
    
    
    private void FixedUpdate()
    {
        foreach (var planet in planetList)
        {
            if (planet != this)
            {
                attrack(planet);

            }
        }
    }

    private void Awake()
    {
     rb = GetComponent<Rigidbody>();
     if (planetList == null)
     {
         planetList = new List<gravityB>();
     }
     planetList.Add(this);
     
    }

    void attrack(gravityB other)
    {
     Rigidbody otherRb = other.rb;
     Vector3 direction = rb.position - otherRb.position;
        
     // get distance in meter
     float distance = direction.magnitude;
     
     // calculate gravity force
     float forceMagnitude = G * ((rb.mass * otherRb.mass) / (distance * distance));
     Vector3 finalForce = forceMagnitude * direction.normalized;
     
     otherRb.AddForce(finalForce);
    }
    
    
    
}
