using UnityEngine;

public class SituationManager : MonoBehaviour
{
    public SituationSCO[] allSituations;
    public ChoiceManager choice;
    

    private void Awake()
    {
        EventManager.onNewSituation += NextSituation;
    }
    public void NextSituation()
    {
        choice.actuelSituation = allSituations[Random.Range(0, allSituations.Length)];
    }
}
