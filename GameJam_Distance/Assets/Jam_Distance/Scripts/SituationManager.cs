using UnityEngine;

public class SituationManager : MonoBehaviour
{
    public SituationSCO[] allSituations;

    private void Awake()
    {
        EventManager.onNewSituation += NextSituation;
    }
    public void NextSituation()
    {
        ChoiceManager.actuelSituation = allSituations[Random.Range(0, allSituations.Length)];
    }
}
