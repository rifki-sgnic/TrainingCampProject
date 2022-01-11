using UnityEngine;

public class Target : MonoBehaviour
{
    
    public int score = 0;

    public void TakeDamage()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
