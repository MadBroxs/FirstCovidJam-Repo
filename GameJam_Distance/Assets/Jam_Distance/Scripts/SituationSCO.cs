using Sirenix.OdinInspector;
using UnityEngine;

[System.Serializable]
public struct Persona
{
    [Header("Name")]
    public string name;
    [Header("Apparence")]
    public bool isMale;
    public Sprite hat;
    public Sprite hair;
    public Sprite mask;
    public Sprite bear;
    public Sprite outfit;

    public Persona(string name, Sprite hat, Sprite hair, Sprite mask, Sprite bear, Sprite outfit)
    {
        this.name = "Philémon";
        this.isMale = true;
        this.hat = null;
        this.hair = null;
        this.mask = null;
        this.bear = null;
        this.outfit = null;
    }
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

