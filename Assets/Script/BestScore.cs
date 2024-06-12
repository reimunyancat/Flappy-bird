using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<TMP_Text>();
        text.text = "Best Score: " + (Score.bestScores.ContainsKey(Difficulty.difficulty) ? Score.bestScores[Difficulty.difficulty] : 0);
    }
}
