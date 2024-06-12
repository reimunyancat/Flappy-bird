using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimate : MonoBehaviour
{
    [SerializeField] Animator anim;
    public GameObject button;

    void Start()
    {
        button = this.gameObject;
    }

    public void ToDifficultySelect()
    {
        anim.Play("toDifficulty");
    }
}
