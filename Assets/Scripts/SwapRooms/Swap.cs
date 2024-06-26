using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{

    
    public string Pos;
    public GameObject Player;
    public Animator upArrow;
    public Animator downArrow;
    public Animator rightArrow;
    public Animator leftArrow;

    private void Start()
    {
        GetCenter.IsCenter = true;
    }

    void SwapRoom()
    {
        if (GetCenter.IsCenter)
        {
            switch (Pos)
            {
                case "Down":
                    SwitchArrows(false, true, false, false);
                    Player.transform.position = new Vector2(0, Player.transform.position.y - 15);
                    break;
                case "Up":
                    SwitchArrows(false, false, false, true);
                    Player.transform.position = new Vector2(0, Player.transform.position.y + 15);
                    break;
                case "Right":
                    SwitchArrows(true, false, false, false);
                    Player.transform.position = new Vector2(Player.transform.position.x + 30, 0);
                    break;

                case "Left":
                    SwitchArrows(false, false, true, false);
                    Player.transform.position = new Vector2(Player.transform.position.x - 30, 0);
                    break;
            }
            
        }
        else
        {

            SwitchArrows(true, true, true, true);
            Player.transform.position = new Vector3(0, 0, 0);
            
        }
        GetCenter.IsCenter = !GetCenter.IsCenter;
    }
    
    private void SwitchArrows(bool left, bool up, bool right, bool down)
    {
        upArrow.SetBool("isArrowUp", up);
        downArrow.SetBool("isArrowDown", down);
        rightArrow.SetBool("isArrowRight", right);
        leftArrow.SetBool("isArrowLeft", left);
    }
     
  }

    




    





