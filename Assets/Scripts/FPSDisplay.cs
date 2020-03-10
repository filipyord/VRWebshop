using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    public float hudRefreshRate = 1f;
    public TextMeshPro textMesh;

    private float deltaTime = 0.0f;
    private float timer;

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        if (Time.unscaledTime > timer)
        {
            
            float fps = 1.0f / deltaTime;

            string text = string.Format("{0:0.} fps", fps);

            textMesh.text = text;

            timer = Time.unscaledTime + hudRefreshRate;
        }
    }
}
