using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void SetDifficulty(float difficulty)
    {
        Difficulty.SetDiff(difficulty);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }
}
