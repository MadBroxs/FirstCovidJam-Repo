using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region Singletton Pattern
    public static EventManager current;
    private void Awake()
    {
        current = this;
    }
    #endregion

    public static event Action onCharaUpdate;

    public static event Action onNewSituation;

    public static event Action onRevolution;
    public static event Action onSchoolClose;

    public static void CharaUpdate()
    {
        onCharaUpdate?.Invoke();
    }
   
    public static void NewSituation()
    {
        onNewSituation?.Invoke();
    }
    
    public static void Revolution()
    {
        onRevolution?.Invoke();
    }
    public static void SchoolClose()
    {
        onSchoolClose?.Invoke();
    }

}
