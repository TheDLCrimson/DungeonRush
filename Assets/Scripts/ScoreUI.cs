using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public CoinCollector player;
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = "Score: " + player.score.ToString();
    }
}
