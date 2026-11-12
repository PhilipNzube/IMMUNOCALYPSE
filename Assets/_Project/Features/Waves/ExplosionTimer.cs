using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplosionTimer : MonoBehaviour
{
    public ParticleSystem FireBall;
    public Collider Col;
    public bool LoopE = true;

    void Start()
    {
        Col.enabled = false;
        StartCoroutine(Explode());
    }

    public IEnumerator Explode()
    {
        while (LoopE == true)
        {
            Col.enabled = true;
            FireBall.Play();
            yield return new WaitForSeconds(2f);
            Col.enabled = false;
            yield return new WaitForSeconds(20f);
            Col.enabled = true;
            FireBall.Play();
            yield return new WaitForSeconds(2f);
            Col.enabled = false;
            yield return new WaitForSeconds(20f);
        }
    }

}
