using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(FPSCounter), typeof(Text))]
public class FPSDisplayer : MonoBehaviour
{
    FPSCounter fpsCounter;
    Text fpsText;

    // Start is called before the first frame update
    void Start()
    {
        fpsCounter = GetComponent<FPSCounter>();
        fpsText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        fpsText.text = "FPS: "+ fpsCounter.GetAverageFPSInInt();
    }
}
