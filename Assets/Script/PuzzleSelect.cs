using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleSelect : MonoBehaviour
{
    public GameObject StartPanel;
    public void SetPuzzlesPhoto(Image photo)
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject.Find("" + i).transform.Find("puzzle").GetComponent<SpriteRenderer>().sprite = photo.sprite;
            GameObject.Find("puzzleBackground").GetComponent<SpriteRenderer>().sprite = photo.sprite;

        }
        StartPanel.SetActive(false);

    }
    public void BackToPanel()
    {
        StartPanel.SetActive(false);
    }
}
