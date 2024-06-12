using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCheck : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            gameManager.score++;
        }
    }

}