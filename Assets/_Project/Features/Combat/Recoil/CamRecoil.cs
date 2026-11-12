using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRecoil : MonoBehaviour
{
    public float rotationSpeed = 6;
    public float returnSpeed = 25;
    public Vector3 RecoilRotation = new Vector3(2f, 2f, 2f);
    public Vector3 RecoilRotationAiming = new Vector3(0.5f, 0.5f, 1.5f);
    public bool aiming = false;
    private Vector3 currentRotation;
    private Vector3 Rot;

    void Start()
    {

    }
    void FixedUpdate()
    {
        currentRotation = Vector3.Lerp(currentRotation, Vector3.zero, returnSpeed * Time.deltaTime);
        Rot = Vector3.Slerp(Rot, currentRotation, rotationSpeed * Time.fixedDeltaTime);
        transform.localRotation = Quaternion.Euler(Rot);
    }

    public void Recoil()
    {
        if (aiming == true)
        {
            currentRotation += new Vector3(-RecoilRotationAiming.x, Random.Range(-RecoilRotationAiming.y, RecoilRotationAiming.y), Random.Range(-RecoilRotationAiming.z, RecoilRotationAiming.z));
        }
        else if (aiming == false)
        {
            currentRotation += new Vector3(-RecoilRotation.x, Random.Range(-RecoilRotation.y, RecoilRotation.y), Random.Range(-RecoilRotation.z, RecoilRotation.z));
        }
    }

    void Update()
    {

    }
}
