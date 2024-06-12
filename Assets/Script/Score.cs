using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static Dictionary<float, int> bestScores = new();
    private TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text = this.gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }
}