using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject selectedPiece;
    private Vector3 position;
    public List<GameObject> puzzle = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void Init()
	{
		foreach (var piece in puzzle)
		{
            piece.transform.GetComponent<PiecesPosition>().Init();
        
           
        }
	}
	// Update is called once per frame
	void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit) {
                if (hit.transform.CompareTag("Puzzle"))
                {

                    selectedPiece = hit.transform.gameObject;
                    position = selectedPiece.transform.position;
                }
            }
            
        }
        //Drag
        if (selectedPiece != null && !selectedPiece.GetComponent<PiecesPosition>().inRightPosition)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
        //Drop 
        if (Input.GetMouseButtonUp(0))
        {
            if (selectedPiece) {
                if (selectedPiece.transform.GetComponent<PiecesPosition>().inRightPosition)
                {
                    selectedPiece = null;
                }
                else
                {
                    selectedPiece.transform.position = position;
                    //selectedPiece.transform.GetComponent<PiecesPosition>().Init();
                    selectedPiece = null;
                }
            }
            
        }
        int index = 0;
        int number = 0;
        foreach (var piece in puzzle)
        {
            if (piece.transform.GetComponent<PiecesPosition>().inRightPosition && !selectedPiece)
            {
                GameUI.instance.SetProgress(number/10f);
                number++;
            }

            index++;
        }
        if (number == 10 && !selectedPiece)
        {
			foreach (var piece in puzzle)
			{
                piece.GetComponent<PiecesPosition>().inRightPosition = false;
			}
            GameManager.instance.Win();
        }
        if (GameManager.instance.isInGame)
		{
            foreach (var piece in puzzle)
            {
                piece.GetComponent<PiecesPosition>().inRightPosition = false;
            }

        }

    }
}
