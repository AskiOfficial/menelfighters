using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    //Parametry itemu
    public enum ItemType
    {
        Chleb,
        Vodka,
        Mefedron,
        Zaza,
        Puszka,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Chleb: return ItemAssets.Instance.Chleb;
            case ItemType.Vodka: return ItemAssets.Instance.Vodka;
            case ItemType.Mefedron: return ItemAssets.Instance.Mefedron;
            case ItemType.Zaza: return ItemAssets.Instance.Zaza;
            case ItemType.Puszka: return ItemAssets.Instance.Puszka;
        }
    } 
}
