using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public static Dictionary<float, int> bestScores = new();
    [SerializeField] private TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }


}
