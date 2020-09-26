using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "SpriteLibrairie")]
public class CharaManager : ScriptableObject
{
    //Variables
    [Header("Visual")]
    public Sprite [] hat;
    public Sprite[] hairs;
    public Sprite[] masks;
    public Sprite[] bears;
    public Sprite[] outfits;

    [Header("Color"), Space(25)]
    public Color[] skinColor;
    public Color[] hairColor;


    //Methods
    public Sprite GetRandomHat()
    {
        int num = Random.Range(0, hat.Length);
        return hat[num];
    }
    public Sprite GetRandomHairs()
    {
        int num = Random.Range(0, hairs.Length);
        return hairs[num];
    }
    public Sprite GetRandomMask()
    {
        int num = Random.Range(0, masks.Length);
        return masks[num];
    }
    public Sprite GetRandomBear()
    {
        int num = Random.Range(0, bears.Length);
        return bears[num];
    }
    public Sprite GetRandomOutfits()
    {
        int num = Random.Range(0, outfits.Length);
        return outfits[num];
    }
}
