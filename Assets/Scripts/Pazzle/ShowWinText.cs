using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWinText : MonoBehaviour
{

    public static int PlacedCount { get; set; }
    public int countDetails;
    public bool showWinText = false;
    public Animator animator;

    public void ShowText()
    {
        showWinText = true;
        animator.SetBool("isActivated", true);
    }

    void Update() { 
        
        
        if ((PlacedCount == countDetails) &&  !showWinText)
        {
            Debug.Log(PlacedCount == countDetails);
            ShowText();
        }

    }
}
