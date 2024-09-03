using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void OpenMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }   
}