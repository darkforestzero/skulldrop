using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;


public class Main : MonoBehaviour
{
    public float timeBetweenLaneChange = 2f;
    private float timer = 0f;
    public TextMeshProUGUI timerText;

    public GameObject[] lanes;


    public int lastSelectedLaneIdx = -1;

    //every 2 seconds pick a random lane to call it's component "ScoringLane"'s function ActivateHighlight()
    // and call DeActivateHighlight() on all other lanes
    private void ActivateNextLane()
    {
        ++this.lastSelectedLaneIdx;
        if (this.lastSelectedLaneIdx >= lanes.Length)
        {
            this.lastSelectedLaneIdx = 0;
        }
        SetSelected(this.lastSelectedLaneIdx);
    }

    private void SetSelected(int index)
    {
        Assert.IsTrue(index >= 0 && index < lanes.Length);
        for (int i = 0; i < lanes.Length; i++)
        {
            bool isCurrentSelection = i == index;
            ScoringLane lane = lanes[i].GetComponent<ScoringLane>();
            Assert.IsNotNull(lane);
            bool isCurrentlyHighlighted = lane.IsHighlighted();
            // Debug.Log("SetSelected(): i=" + i + " isCurrentSelection=" + isCurrentSelection + " isCurrentlyHighlighted=" + isCurrentlyHighlighted);
            if (isCurrentlyHighlighted && isCurrentSelection)
            {
                continue;
            }

            lane.SetHighlighted(isCurrentSelection);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ActivateNextLane();
            timer = timeBetweenLaneChange;
        }
        timerText.SetText("Time: " + timer.ToString("F2"));
    }
}
