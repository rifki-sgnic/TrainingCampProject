using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    Target targetScore;
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (targetScore.score != null)
        {
            score = targetScore.score;
            text.SetText("Score: " + score);
        }
    }
}
