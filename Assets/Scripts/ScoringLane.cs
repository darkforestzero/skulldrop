using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringLane : MonoBehaviour
{
    public int scoreAmount = 1;
    public GameObject glowPulse;

    void AvtivateHighlights()
    {
        glowPulse.SetActive(true);
    }
    void DeActivateHighlights()
    {
        glowPulse.SetActive(false);
    }
    // call scoremanager's delegate function to bump score by scoreAmount

    // Bump score on collision with ball
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if the object that collided with this object has the tag "ball"
        if (other.gameObject.tag == "ball")
        {

            Debug.Log("OnTriggerEnter2D(): scoreAmount" + scoreAmount);
            ScoreManager.OnBumpScore(scoreAmount);

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
