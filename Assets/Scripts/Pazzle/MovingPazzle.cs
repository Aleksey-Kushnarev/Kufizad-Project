using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPazzle : MonoBehaviour
{
    bool isMooving = false;
    Vector2 mousePos;
    float startPosX;
    float startPosY;
    public GameObject form;
    private bool placed = false;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            isMooving = true;
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
        }
    }

    private void OnMouseUp()
    {
        isMooving = false;

        if ((Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= 10f) &&
            (Mathf.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 10f) && !placed)
        {
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = 1;
            var color = spriteRenderer.color;
            color.a = 1f;
            spriteRenderer.color = color;
            placed = true;
            ShowWinText.PlacedCount++;
            Debug.Log(ShowWinText.PlacedCount);
            this.gameObject.transform.localPosition = new Vector2(form.transform.localPosition.x, form.transform.localPosition.y);


        } 
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMooving && !placed) {
            mousePos = Input.mousePosition;
            this.gameObject.transform.localPosition = new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);
        }
    }
}
