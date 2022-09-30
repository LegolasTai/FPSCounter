using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    private int SampleNumber = 120;

    private List<float> lFps = new List<float>();
    private float fFpsSum;

    // Update is called once per frame
    void Update()
    {
        lFps.Add(1 / Time.deltaTime);
        fFpsSum += lFps[lFps.Count - 1];

        if (lFps.Count> SampleNumber)
        {
            fFpsSum -= lFps[0];
            lFps.RemoveAt(0);
        }

        Debug.Log(GetAverageFPSInInt());
    }

    private float GetAverageFPS()
    {
        return fFpsSum / lFps.Count;
    }

    public int GetAverageFPSInInt()
    {
        return (int)GetAverageFPS();
    }
}
