using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaManager : MonoBehaviour
{
    #region Singleton Pattern
    static CharaManager _instance = null;
    public static CharaManager Instance
    {
        get
        {
            if (!_instance)
                _instance = GameObject.FindGameObjectWithTag("SpriteLibrairie").GetComponent<CharaManager>();
            return _instance;
        }
    }

    #endregion

    //Variables
    [Header("Visual")]
    public Sprite[] heads;
    public Sprite[] masks;
    public Sprite[] bears;
    public Sprite[] outfits;
    [Header("Color"), Space(25)]
    public Color[] skinColor;
    public Color[] hairColor;

    //Methods
    public static Sprite GetRandomMask()
    {
        int num = Random.Range(0, _instance.masks.Length);
        return _instance.masks[num];
    }
    public Sprite GetRandomHead()
    {
        int num = Random.Range(0, heads.Length);
        return heads[num];
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
