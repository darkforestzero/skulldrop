using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreManager scoreManager;
    public String scoreTextPrefix = "Score\n";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        if (scoreText == null)
        {
            Debug.LogError("ScoreText: scoreText is null");
            return;
        }
        scoreText.text = scoreTextPrefix + scoreManager.GetScore();
    }
}
