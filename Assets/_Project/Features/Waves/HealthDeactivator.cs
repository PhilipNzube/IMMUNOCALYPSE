using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDeactivator : MonoBehaviour
{
    public PlayerHealth PH;

    void Start()
    {
        PH = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        StartCoroutine(Deactivate());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (PH.CurrentHealth < 375)
            {
                PH.RefillHealth();
                this.gameObject.SetActive(false);
            }
        }
    }

    public IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(60.0f);
        this.gameObject.SetActive(false);
    }

}
