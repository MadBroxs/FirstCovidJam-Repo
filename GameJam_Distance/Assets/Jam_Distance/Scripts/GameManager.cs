using Sirenix.OdinInspector;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int covidCase = 0;
    public static int studentRage = 0;

    private void Awake()
    {
        ResetStats();    
    }

    private void Update()
    {
        if (covidCase > 2)
        {
            EventManager.SchoolClose();
            Debug.LogError("Rubika ferme");
        }
        else
        if (studentRage > 2)
        {
            EventManager.Revolution();
            Debug.LogError("Revolution");

        }
    }

    [Button]
    public void ResetStats()
    {
        covidCase = 0;
        studentRage = 0;
    }
}
