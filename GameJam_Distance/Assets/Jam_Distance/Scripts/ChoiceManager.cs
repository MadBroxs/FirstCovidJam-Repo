using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public SituationSCO actuelSituation;

    public Button validateButton;
    public Button rejectButton;

    public MMFeedback goodFeedBack;
    public MMFeedback badFeedBack;

    void Awake()
    {
        validateButton.onClick.AddListener(OnAccept);
        rejectButton.onClick.AddListener(OnRefuse);
    }

    void OnAccept()
    {
        if (!actuelSituation.isCovided)
        {
            GoodReaction();
            GameManager.countWin ++;
        }
        else
        {
            BadReaction();
        }

        EventManager.NewSituation();
    }
    void OnRefuse()
    {
        if (actuelSituation.isCovided)
        {
            GoodReaction();
            GameManager.countWin ++;
        }
        else
        {
            BadReaction();
        }

        EventManager.NewSituation();
    }

    private void GoodReaction()
    {
        goodFeedBack.Play(transform.position, 1);
        
    }

    private void BadReaction()
    {
        badFeedBack.Play(transform.position, 1);

        if (actuelSituation.isCovided)
        {
            GameManager.covidCase++;
        }
        else
        {
            GameManager.studentRage++;
        }
    }

}
