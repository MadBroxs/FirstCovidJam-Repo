using Sirenix.OdinInspector;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int countWin = 0;
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
                eventProk = true;
                SceneHandler.GoToSchoolClosed();
            }
            else
            if (studentRage > 2)
            {
                EventManager.Revolution();
                eventProk = true;
                SceneHandler.GoToGDvolution();
            }

            if (countWin > 15)
            {
                EventManager.VictorySchool();
                eventProk = true;
                SceneHandler.GoToSchoolVictoryScene();

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
