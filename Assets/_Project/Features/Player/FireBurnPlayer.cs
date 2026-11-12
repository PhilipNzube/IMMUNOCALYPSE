using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBurnPlayer : NetworkBehaviour
{
    public BoxCollider FireCol;
    public bool Burn = true;
    public ParticleSystem PS;

    void Start()
    {
        StartCoroutine(WaitForIM());
    }

    public IEnumerator WaitForIM()
    {
        while (Burn == true)
        {
            yield return new WaitForSeconds(2f);
            PS.Play();
            FireCol.enabled = true;
            yield return new WaitForSeconds(3.6f);
            PS.Stop();
            FireCol.enabled = false;
        }
    }

}
