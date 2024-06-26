using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

    public class ChangeMessage : MonoBehaviour
    {
    private bool isTipShowed = false;
    public int index;
    private string tip;
    public TextMeshProUGUI textBox;
    public GameObject button;
    private void Start()
    {
        tip = ParseJson.ReadFile()[index].tip;
    }
    public void PrintTip()
    {
        if (isTipShowed)
        {
            textBox.text = tip;
        }
        else
        {
            textBox.text = "Хотите получить подсказку?";
        }
    }


    public void ShowButton()
    {
        if (isTipShowed)
        {
            button.gameObject.SetActive(false);
        }
        else
        {
            button.gameObject.SetActive(true);
        }
    }

    public void onClickPrintTip()
    {
        isTipShowed = true;
        ShowButton();
        PrintTip();
    }

    public void ExitTip()
    {
        button.gameObject.SetActive(false);
    }



}
