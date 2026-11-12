using UnityEngine;
using UnityEngine.UI;

public class PlayerFpsTracker
{
    private int framePassed = 0;
    private float fpsTotal = 0f;
    private float minFPS = Mathf.Infinity;
    private float maxFPS = 0f;

    public void UpdateFPS(Text fpsDisplay, Text averageFPSDisplay, Text minFPSDisplay, Text maxFPSDisplay)
    {
        float currentFPS = 1.0f / Time.smoothDeltaTime;
        framePassed++;
        fpsTotal += currentFPS;

        if (currentFPS < minFPS && currentFPS > 5f) minFPS = currentFPS;
        if (currentFPS > maxFPS) maxFPS = currentFPS;

        if (fpsDisplay != null) fpsDisplay.text = ((int)currentFPS).ToString();
        if (averageFPSDisplay != null) averageFPSDisplay.text = ((int)(fpsTotal / framePassed)).ToString();
        if (minFPSDisplay != null) minFPSDisplay.text = ((int)minFPS).ToString();
        if (maxFPSDisplay != null) maxFPSDisplay.text = ((int)maxFPS).ToString();
    }

    public void Reset()
    {
        framePassed = 0;
        fpsTotal = 0f;
        minFPS = Mathf.Infinity;
        maxFPS = 0f;
    }
}
