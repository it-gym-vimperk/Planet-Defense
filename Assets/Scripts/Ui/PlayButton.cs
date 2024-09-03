using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void OpenGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }   
}
