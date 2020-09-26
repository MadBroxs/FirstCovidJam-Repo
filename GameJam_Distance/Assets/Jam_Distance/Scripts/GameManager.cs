using Sirenix.OdinInspector;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int covidCase = 0;
    public static int studentRage = 0;

    private bool eventProk = false;
    private void Awake()
    {
        ResetStats();    
    }

    private void Update()
    {
        if (!eventProk)
        {
            if (covidCase > 2)
            {
                EventManager.SchoolClose();
                Debug.LogError("Rubika ferme");
                eventProk = true;
            }
            else
            if (studentRage > 2)
            {
                EventManager.Revolution();
                Debug.LogError("Revolution");
                eventProk = true;
            }
        }
    }

    [Button]
    public void ResetStats()
    {
        covidCase = 0;
        studentRage = 0;
    }
}
