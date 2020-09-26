using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "SpriteLibrairie")]
public class CharaManager : ScriptableObject
{
    //Variables
    [Header("Visual Men")]
    public Sprite[] body_men;
    public Sprite[] hat_men;
    public Sprite[] hairs_men;
    public Sprite[] masks_men;
    public Sprite[] bears_men;
    public Sprite[] outfits_men;

    [Header("Visual Women"), Space(15)]
    
    public Sprite[] body_women;
    public Sprite[] hat_women;
    public Sprite[] hairs_women;
    public Sprite[] masks_women;
    public Sprite[] outfits_women;
    public Sprite[] accessories_women;

    [Header("Color"), Space(25)]
    public Color[] skinColor;
    public Color[] hairColor;


    //Methods
    public Sprite GetRandomBody(bool isMale)
    {
        if (isMale)
        {
            int num = Random.Range(0, body_men.Length);
            return body_men[num];
        }
        else
        {
            int num = Random.Range(0, body_women.Length);
            return body_women[num];
        }
    }
    public Sprite GetRandomHat(bool isMale)
    {
        if (isMale)
        {
            int num = Random.Range(0, hat_men.Length);
            return hat_men[num];
        }
        else
        {
            int num = Random.Range(0, hat_women.Length);
            return hat_women[num];
        }
    }
    public Sprite GetRandomHairs(bool isMale)
    {
        if (isMale)
        {
            int num = Random.Range(0, hairs_men.Length);
            return hairs_men[num];
        }
        else
        {
            int num = Random.Range(0, hairs_women.Length);
            return hairs_women[num];
        }
    }
    public Sprite GetRandomMask(bool isMale)
    {
        if (isMale)
        {
            int num = Random.Range(0, masks_men.Length);
            return masks_men[num];
        }
        else
        {
            int num = Random.Range(0, masks_women.Length);
            return masks_women[num];
        }
    }
    public Sprite GetRandomBear(bool isMale)
    {
        if (isMale)
        {
            int num = Random.Range(0, bears_men.Length);
            return bears_men[num];

        }
        else
        {
            return null;
        }
    }
    public Sprite GetRandomOutfits(bool isMale)
    {
        if (isMale)
        {
            int num = Random.Range(0, outfits_men.Length);
            return outfits_men[num];
        }
        else
        {
            int num = Random.Range(0, outfits_women.Length);
            return outfits_women[num];
        }
    }

    public Sprite GetRandomAccessories(bool isMale)
    {
        if (isMale)
        {
            return null;
        }
        else
        {
            int num = Random.Range(0, accessories_women.Length);
            return accessories_women[num];
        }
    }
}
