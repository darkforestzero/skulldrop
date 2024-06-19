using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public delegate void BumpScore(int amount);
    public static BumpScore OnBumpScore;

    private GameObject[] lanes;
    public int playerScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        OnBumpScore = IncrementScore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementScore(int amount)
    {
        playerScore += amount;
        Debug.Log("Score: " + playerScore + " bump: " + amount);
    }

    public int GetScore()
    {
        return playerScore;
    }
}