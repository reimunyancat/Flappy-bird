using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Score.bestScores.ContainsKey(Difficulty.difficulty))
        {
            if(Score.score > Score.bestScores[Difficulty.difficulty]) Score.bestScores[Difficulty.difficulty] = Score.score;
        }
        else
        {
            Score.bestScores.Add(Difficulty.difficulty, Score.score);
        }
        SceneManager.LoadScene("GameOver");
    }
}
