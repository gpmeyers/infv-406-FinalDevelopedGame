using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    public bool gameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
