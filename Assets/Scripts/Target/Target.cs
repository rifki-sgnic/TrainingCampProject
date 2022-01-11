using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{

    public bool isTargetPractice;
    public float health = 10f;
    public float defaultHealth;

    public TextMeshProUGUI text;
    public int score = 0;
    public GameObject resetButton;

    private void Start()
    {
        defaultHealth = health;
        text.SetText("Score: " + score);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Dead();
            AddScore();
        }
    }

    private void Dead()
    {
        if (isTargetPractice)
        {
            health = defaultHealth;
            gameObject.transform.position = new Vector3(Random.Range(-9, 9), Random.Range(1.5f, 7.5f), Random.Range(-9.5f, 5.75f));
            gameObject.transform.localScale = new Vector3(Random.Range(0.5f, 1), Random.Range(0.5f, 1), Random.Range(0.5f, 1));
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void AddScore()
    {
        score++;
        text.SetText("Score: " + score);
    }

    public void ResetScore()
    {
        score = 0;
        text.SetText("Score: " + score);
    }
}
