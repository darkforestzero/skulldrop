using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpScoreOnCollision : MonoBehaviour
{
    public int scoreAmount = 1;
    // call scoremanager's delegate function to bump score by scoreAmount
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
