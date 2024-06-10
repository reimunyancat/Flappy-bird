using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        Score.score++;
    }
}
