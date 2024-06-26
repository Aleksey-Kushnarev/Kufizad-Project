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
        PlayerPrefs.SetInt("isPazzleFinish", 1);
        animator.SetBool("isActivated", true);
    }

    void Update() { 
        
        
        if ((PlacedCount == countDetails) &&  !showWinText)
        {
         
            ShowText();
        }

    }

    private void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("isPazzleFinish") + " debud");
        if (!PlayerPrefs.HasKey("isPazzleFinish"))
        {
            PlayerPrefs.SetInt("isPazzleFinish", 0);
        }
        else if (PlayerPrefs.GetInt("isPazzleFinish") == 1)
        {
            ShowText();
            
        }
    }
}
