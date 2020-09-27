using System.Collections.Generic;
using UnityEngine;

public class SituationManager : MonoBehaviour
{
    [Header("Toutes les situtations"), Space(10)]
    public SituationSCO[] allSituations;

    [Header("Situation Facile"), Space(10)]
    public SituationSCO[] easySituations;

    [Header("Situation Moyenne"), Space(10)]
    public SituationSCO[] mediumSituations;

    [Header("Situation Dur"), Space(10)]
    public SituationSCO[] hardSituations;

    public ChoiceManager choice;



    private void Awake()
    {
        EventManager.onNewSituation += NextSituation;

    }
    public void NextSituation()
    {
        //choice.actuelSituation = allSituations[Random.Range(0, allSituations.Length)];

        choice.actuelSituation = easySituations[Random.Range(0, easySituations.Length)];

        if (GameManager.countWin > 5)
        {
            choice.actuelSituation = mediumSituations[Random.Range(0, mediumSituations.Length)];
            if (GameManager.countWin > 10)
            {
                choice.actuelSituation = hardSituations[Random.Range(0, hardSituations.Length)];
            }
        }
    }
}
