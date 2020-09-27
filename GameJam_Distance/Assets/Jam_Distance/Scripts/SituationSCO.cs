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
    public Sprite accessoires;

    //ajout couleur
}


[CreateAssetMenu(fileName = "CovidOuPasCovid?")]
public class SituationSCO : ScriptableObject
{
    public CharaManager spriteLib;

    [Header("Personnage")]
    public Persona character;

    [Button()]
    public void RandomPerso()
    {
        character.body = spriteLib.GetRandomBody(character.isMale);
        
        character.hat = spriteLib.GetRandomHat(character.isMale);

        character.hair = spriteLib.GetRandomHairs(character.isMale);

        character.mask = spriteLib.GetRandomMask(character.isMale);

        character.bear = spriteLib.GetRandomBear(character.isMale);

        character.outfit = spriteLib.GetRandomOutfits(character.isMale);
        
        character.accessoires = spriteLib.GetRandomAccessories(character.isMale);
    }

    [Header("Info"), MultiLineProperty(5)]
    public string situationContexte;
    public bool isCovided;
}

