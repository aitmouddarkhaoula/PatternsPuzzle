using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuzzleSelect : MonoBehaviour
{
    [SerializeField] DragAndDrop _dragAndDrop;
    public void SetPuzzlesPhoto(Image photo)
    {
        for (int i = 0; i < 10; i++)
        {
            _dragAndDrop.Init();
            GameObject.Find("" + i).transform.Find("puzzle").GetComponent<SpriteRenderer>().sprite = photo.sprite;
            GameObject.Find("puzzleBackground").GetComponent<SpriteRenderer>().sprite = photo.sprite;
           // _dragAndDrop.number = 0;

        }
        GameManager.instance.StartGame(true);
    }
   
   
}
