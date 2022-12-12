using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject selectedPiece;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                
                    selectedPiece = hit.transform.gameObject;
                
                
            }
        }
        //Drag
        if (selectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
        //Drop 
        if (Input.GetMouseButtonUp(0))
        {
            if (selectedPiece.transform.GetComponent<PiecesPosition>().inRightPosition)
            {
                selectedPiece = null;
            }
        }
        
    }
}
