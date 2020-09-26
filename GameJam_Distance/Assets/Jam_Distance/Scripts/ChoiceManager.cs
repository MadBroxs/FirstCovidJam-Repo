using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public static SituationSCO situation;

    public Button validateButton;
    public Button rejectButton;

    public MMFeedback goodFeedBack;
    public MMFeedback badFeedBack;
     
    void OnEnable()
    {
        validateButton.onClick.AddListener(OnAccept);
        rejectButton.onClick.AddListener(OnRefuse);
    }

    void OnAccept()
    {
        if (!situation.isCovided)
        {
            GoodReaction();
        }
        else
        {
            BadReaction();
        }
    }
    void OnRefuse()
    {
        if (situation.isCovided)
        {
            GoodReaction();
        }
        else
        {
            BadReaction();
        }
    }

    private void GoodReaction()
    {
        goodFeedBack.Play(transform.position, 1);
    }

    private void BadReaction()
    {
        badFeedBack.Play(transform.position, 1);

        if (situation.isCovided)
        {
            //ecole infectée
        }
        else
        {
            //étudiant en colère
        }
    }



}
