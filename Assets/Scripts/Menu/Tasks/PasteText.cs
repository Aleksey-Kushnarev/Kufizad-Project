using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PasteText : MonoBehaviour
{

    public TextMeshProUGUI textBox;
    private List<Task> textList = ParseJson.ReadFile();
    public int index;
    // Start is called before the first frame update
    public void PrintTaskText()
    {
        textBox.SetText(textList[index].text);
    }

    
}
