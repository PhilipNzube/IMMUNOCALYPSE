using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SniperScopeSlider : MonoBehaviour
{
    public SniperScopeEffect SSE;
    public Slider ScopeSlider;
    public FirstPersonControls FPC;
    public Look2 L2;

    void Start()
    {

    }
    public void SetScope()
    {
        float sliderValue = ScopeSlider.value;
        SSE.ScopeFOV = sliderValue;

    }
    public void DisableTouch()
    {
        FPC.Look = false;
        L2.Look = false;
    }
    public void EnableTouch()
    {
        FPC.Look = true;
        L2.Look = true;
    }

    void Update()
    {

    }
}
