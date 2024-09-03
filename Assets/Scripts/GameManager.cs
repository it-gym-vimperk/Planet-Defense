using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public GameObject gameOverPanel;
    public TextMeshProUGUI scoreText;
    
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Instance = this;
    }

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        DestroyAllObjectsWithTag("Airship");
        DestroyAllObjectsWithTag("Spawner");
        DestroyAllObjectsWithTag("Meteor");
        DestroyAllObjectsWithTag("Bomb");
        DestroyAllObjectsWithTag("Projectile");
    }

    private void DestroyAllObjectsWithTag(string tagName)
    {
        var gameObjects = GameObject.FindGameObjectsWithTag(tagName);
        foreach (var gameObject in gameObjects)
        {
            Destroy(gameObject);
        }
    }
}
