using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucleon : MonoBehaviour
{
	public Rigidbody body;
	public float attractionForce;

    void Start()
    {
    body=GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
     body.AddForce(transform.localPosition*-attractionForce);
    }
}
