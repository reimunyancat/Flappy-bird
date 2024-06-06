using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour
{
    public Text scoreText;
    private void OnTriggerExit2D(Collider2D other)
    {
        Score.score++;
    }
}
