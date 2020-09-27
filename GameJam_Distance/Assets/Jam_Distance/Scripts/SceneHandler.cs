using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    //oui j'ai Hard code les Scenes (attention si vous changer le nom avec les majuscule)
    public static void GoToMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public static void GoToMainGame()
    {
        SceneManager.LoadScene("GameMain");
    }
    public static void GoToGDvolution()
    {
        SceneManager.LoadScene("GameOver-Revolution");
    }
    public static void GoToSchoolClosed()
    {
        SceneManager.LoadScene("GameOver - Covidead");
    }


}
