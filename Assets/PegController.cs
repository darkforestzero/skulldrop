using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PegController : MonoBehaviour
{
    public int level = 0;

    // array of int[]s to define each of the first 5 levels
    public int[][] levels = new int[][]
    {
    new int[] {5, 10, 15},
    new int[] {1, 5, 7, 10, 12, 15},
    new int[] {1, 3, 5, 7, 9, 11, 13, 15},
    new int[] {1, 3, 5, 7, 9, 11, 13, 15, 2, 4, 6, 8, 10, 12, 14},
    new int[] {1, 3, 5, 7, 9, 11, 13, 15, 2, 4, 6, 8, 10, 12, 14, 0, 16}
    };

    private peglook[] pegs;
    // Start is called before the first frame update
    void Start()
    {
        // store a reference to array of child objects of prefab "Peg"
        pegs = GetComponentsInChildren<peglook>();

        Debug.Log("Pegs: " + pegs.Length);
        SetPegsForLevel(levels[level]);
    }
    void SetPegsForLevel(params int[] enabledIndexes)
    {
        // Disable all pegs
        foreach (peglook peg in pegs)
        {
            peg.gameObject.SetActive(false);
        }

        // Enable specific indexes
        foreach (int index in enabledIndexes)
        {
            if (index >= 0 && index < pegs.Length)
            {
                Debug.Log("ShowPegIdx" + pegs[index]);
                pegs[index].gameObject.SetActive(true);
            }
            else
            {
                Debug.LogWarning("Invalid peg index: " + index);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            level++;
            if (level >= levels.Length)
            {
                level = 0;
            }
            SetPegsForLevel(levels[level]);
        }
    }
}
