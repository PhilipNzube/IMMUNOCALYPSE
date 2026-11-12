using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Mirror;

public class FlankScript2 : NetworkBehaviour
{
    [Header("References")]
    public Transform cam;
    public Transform attackPoint;
    public GameObject objectToThrow;

    [Header("Settings")]
    public int totalThrows;
    public float throwCooldown;
    [Header("Throwing")]
    public float throwForce;
    public float throwUpwardForce;

    void Start()
    {

    }

    public void Throw()
    {
        GameObject projectile = Instantiate(objectToThrow, attackPoint.position, cam.rotation);
        NetworkServer.Spawn(projectile);
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        Vector3 forceDirection = cam.transform.forward;

        RaycastHit hit;

        if (Physics.Raycast(cam.position, cam.forward, out hit, 500f))
        {
            forceDirection = (hit.point - attackPoint.position).normalized;
        }

        Vector3 forceToAdd = forceDirection * throwForce + transform.up * throwUpwardForce;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

    }

}
