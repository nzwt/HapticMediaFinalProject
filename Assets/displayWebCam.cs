using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class displayWebCam : MonoBehaviour
{
    [SerializeField] private UnityEvent _nightTime;
    [SerializeField] private UnityEvent _dayTime;
    WebCamTexture webcamTexture;
    void Start ()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        // for debugging purposes, prints available devices to the console
        for(int i = 0; i < devices.Length; i++)
        {
            print("Webcam available: " + devices[i].name);
        }

        Renderer rend = this.GetComponentInChildren<Renderer>();

        // assuming the first available WebCam is desired
        this.webcamTexture = new WebCamTexture(devices[0].name);
        rend.material.mainTexture = this.webcamTexture;
        this.webcamTexture.Play();
    }

    void Update()
    {
        // check if the camera is dark or bright
        float totalBrightness = 0;
        float counter = 0;
        for(int i = 0; i < this.webcamTexture.width; i++)
        {
            for(int j = 0; j < this.webcamTexture.height; j++)
            {
                float brightness = this.webcamTexture.GetPixel(i, j).grayscale;
                totalBrightness += brightness;
                counter++;
            }
        }
        float averageBrightness = totalBrightness / counter;
        Debug.Log(averageBrightness);
        if (averageBrightness < 0.1)
        {
            onCameraDark();
        }
        else
        {
            onCameraBright();
        }
    }

    private void onCameraDark()
    {
        _nightTime.Invoke();
    }

    private void onCameraBright()
    {
        _dayTime.Invoke();
    }
}