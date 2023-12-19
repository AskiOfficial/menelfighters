using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetFullscreen(bool isFulscreen)
    {
        Screen.fullScreen = isFulscreen;
    }

    List<int> widths = new List<int>() {1280, 1920};
    List<int> heights = new List<int>() {720, 1080};

    public void SetScreenSize (int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
    }

}

    
