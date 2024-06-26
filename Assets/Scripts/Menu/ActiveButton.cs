using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveButton : MonoBehaviour
{

    public GameObject[] blocks = new GameObject[4];
    List<int> actives = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(blocks.Length);
        actives.Add(1);
        for (int i = 1; i < blocks.Length; i++) {
            actives.Add(0);
        }
        //Debug.Log(string.Join(' ', actives));
        ReloadMenu();


    }

    private void ReloadMenu()
    {
        for (int i = 0; actives.Count > i; i++)
        {
            //Debug.Log(i);
            blocks[i].SetActive(actives[i] == 1);
            //Debug.Log(blocks[i].name);
            //Debug.Log(actives[i] == 1);
        }
    }

    public void SwapActive(int id)
    {
        for (int i = 0; i < actives.Count; i++)
        {
            if (actives[i] == 1)
            {
                actives[i] = 0;
            }

        }
       
        actives[id] = 1;
        ReloadMenu();
        //Debug.Log(string.Join(' ', actives));
    }

   
}
