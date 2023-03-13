using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   
    public Transform player;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = player.position.z.ToString("0");
    }
}