using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "My Name")]
public class Card_Character : ScriptableObject
{

[Header("Sprite")]
    public Sprite head;
    public Sprite mask;
    public Sprite outfit;

[Header("Info")]
    public new string name;
    [Space(10)]
    public string situation;
    public bool isCovided;
    [Space(15)]
    public string replyGoodChoice;
    public string replyBadChoice;



}
