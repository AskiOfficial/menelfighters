using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite Chleb;
    public Sprite Mefedron;
    public Sprite Puszka;
    public Sprite Vodka;
    public Sprite Zaza;
}
