using UnityEngine;

public abstract class WeaponRecoilBase : MonoBehaviour, IRecoil
{
    public Transform recoilPosition;
    public Transform rotationPoint;
    public float positionalRecoilSpeed = 8f;
    public float rotationalRecoilSpeed = 8f;
    public float positionalReturnSpeed = 18f;
    public float rotationalReturnSpeed = 38f;
    public Vector3 RecoilRotation = new Vector3(10f, 5f, 7f);
    public Vector3 RecoilKickBack = new Vector3(0.015f, 0f, -0.2f);
    public Vector3 RecoilRotationAim = new Vector3(10f, 4f, 6f);
    public Vector3 RecoilKickBackAim = new Vector3(0.015f, 0f, -0.2f);
    public bool aiming = false;

    protected Vector3 rotationalRecoil;
    protected Vector3 positionalRecoil;
    protected Vector3 Rot;

    protected virtual void FixedUpdate()
    {
        rotationalRecoil = Vector3.Lerp(rotationalRecoil, Vector3.zero, rotationalReturnSpeed * Time.deltaTime);
        positionalRecoil = Vector3.Lerp(positionalRecoil, Vector3.zero, positionalReturnSpeed * Time.deltaTime);
        if (recoilPosition != null)
        {
            recoilPosition.localPosition = Vector3.Slerp(recoilPosition.localPosition, positionalRecoil, positionalRecoilSpeed * Time.fixedDeltaTime);
        }
        Rot = Vector3.Slerp(Rot, rotationalRecoil, rotationalRecoilSpeed * Time.fixedDeltaTime);
        if (rotationPoint != null)
        {
            rotationPoint.localRotation = Quaternion.Euler(Rot);
        }
    }

    public virtual void Recoil()
    {
        if (aiming)
        {
            rotationalRecoil += new Vector3(-RecoilRotationAim.x, Random.Range(-RecoilRotationAim.y, RecoilRotationAim.y), Random.Range(-RecoilRotationAim.z, RecoilRotationAim.z));
            positionalRecoil += new Vector3(Random.Range(-RecoilKickBackAim.x, RecoilKickBackAim.x), Random.Range(-RecoilKickBackAim.y, RecoilKickBackAim.y), RecoilKickBackAim.z);
        }
        else
        {
            rotationalRecoil += new Vector3(-RecoilRotation.x, Random.Range(-RecoilRotation.y, RecoilRotation.y), Random.Range(-RecoilRotation.z, RecoilRotation.z));
            positionalRecoil += new Vector3(Random.Range(-RecoilKickBack.x, RecoilKickBack.x), Random.Range(-RecoilKickBack.y, RecoilKickBack.y), RecoilKickBack.z);
        }
    }
}
