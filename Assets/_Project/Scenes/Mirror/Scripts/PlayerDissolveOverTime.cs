using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SkinnedMeshRenderer))]
public class PlayerDissolveOverTime : MonoBehaviour
{
    private SkinnedMeshRenderer meshRenderer;

    public float speed = .5f;

    public float t = 0.0f;

    private void Start()
    {
        meshRenderer = this.GetComponent<SkinnedMeshRenderer>();
    }

    private void Update()
    {
        Material[] mats = meshRenderer.materials;
        mats[0].SetFloat("_Cutoff", Mathf.Sin(t * speed));
        mats[1].SetFloat("_Cutoff", Mathf.Sin(t * speed));
        t += Time.smoothDeltaTime;

        meshRenderer.materials = mats;
    }
}
