using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static float difficulty { get; private set; } = 1.0f;
    public static void SetDiff(float difficulty)
    {
        Difficulty.difficulty = difficulty;
    }
}