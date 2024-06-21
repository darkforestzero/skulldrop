using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringLane : MonoBehaviour
{
    public int scoreAmount = 1;
    public GameObject glowPulse;

    private bool isHighlighted = false;
    public bool IsHighlighted()
    {
        return isHighlighted;
    }

    public void SetHighlighted(bool val)
    {
        isHighlighted = val;
        glowPulse.SetActive(val);
    }

    // Bump score on collision with ball
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if the object that collided with this object has the tag "ball"
        if (other.gameObject.tag == "ball" && isHighlighted)
        {

            Debug.Log("OnTriggerEnter2D(): scoreAmount" + scoreAmount);
            ScoreManager.OnBumpScore(scoreAmount);

        }
        if (!isHighlighted)
        {
            Debug.Log("OnTriggerEnter2D(): hit unhighlighted lane");
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
