using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestarter : MonoBehaviour
{
    public void RestartLevel(int levelNumber)
    {
        SceneManager.LoadScene(levelNumber);
    }
}
