using Sirenix.OdinInspector;
using UnityEngine;

[System.Serializable]
public struct Persona
{
    [Header("Name")]
    public string name;
    [Header("Apparence")]
    public bool isMale;
    public Sprite body;
    public Sprite hat;
    public Sprite hair;
    public Sprite mask;
    public Sprite bear;
    public Sprite outfit;
}


[CreateAssetMenu(fileName = "CovidOuPasCovid?")]
public class SituationSCO : ScriptableObject
{
    [Header("Personnage")]
    public Persona character;

    [Button()]
    public void RandomPerso()
    {

    }

    [Header("Info"), MultiLineProperty(5)]
    public string situationContexte;
    public bool isCovided;
    [Space(25), MultiLineProperty(2)]
    public string replyGoodChoice;
    [MultiLineProperty(2)]
    public string replyBadChoice;
}

