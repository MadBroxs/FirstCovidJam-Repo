using UnityEngine;

public class CharaVisualizer : MonoBehaviour
{
    [Header("Sprite")]
    public SpriteRenderer body;
    public SpriteRenderer hat;
    public SpriteRenderer hair;
    public SpriteRenderer mask;
    public SpriteRenderer bear;
    public SpriteRenderer outfit;

    public ChoiceManager choice;

    void Update()
    {
        body.sprite = choice.actuelSituation.character.body;
        hat.sprite = choice.actuelSituation.character.hat;
        hair.sprite = choice.actuelSituation.character.hair;
        mask.sprite = choice.actuelSituation.character.mask;
        bear.sprite = choice.actuelSituation.character.bear;
        outfit.sprite = choice.actuelSituation.character.outfit;

        //body.color = choice.actuelSituation.character.skinColor;
    }
}
