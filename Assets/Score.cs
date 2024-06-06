using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<TextMeshPro>();
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }
}
