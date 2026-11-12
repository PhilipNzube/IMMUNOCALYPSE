using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightFlickerScript : MonoBehaviour
{
    public GameObject LightGO;
    public bool FlickerLoop=true;

    void Start()
    {
     StartCoroutine(Flicker());
    }

    public IEnumerator Flicker(){
        while (FlickerLoop == true)
        {
        LightGO.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        LightGO.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        LightGO.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        LightGO.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        }
    }
}
