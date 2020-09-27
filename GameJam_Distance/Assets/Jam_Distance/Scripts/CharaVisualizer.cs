using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharaVisualizer : MonoBehaviour
{
    public ChoiceManager choice;

    [Header("Character")]
    public TextMeshProUGUI blabla;

    [Header("Character")]
    public SpriteRenderer body;
    public SpriteRenderer hat;
    public SpriteRenderer hair;
    public SpriteRenderer mask;
    public SpriteRenderer bear;
    public SpriteRenderer outfit;


    void Update()
    {
        body.sprite = choice.actuelSituation.character.body;
        hat.sprite = choice.actuelSituation.character.hat;
        hair.sprite = choice.actuelSituation.character.hair;
        mask.sprite = choice.actuelSituation.character.mask;
        bear.sprite = choice.actuelSituation.character.bear;
        outfit.sprite = choice.actuelSituation.character.outfit;

        blabla.text = choice.actuelSituation.situationContexte;
        //body.color = choice.actuelSituation.character.skinColor;
    }
}
