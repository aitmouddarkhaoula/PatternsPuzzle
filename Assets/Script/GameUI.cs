using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static GameUI instance;
    public GameObject homeUI;
    public GameObject inGameUI;
    public GameObject winUI;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowHomeUI()
    {
        homeUI.SetActive(true);
        inGameUI.SetActive(false);
        winUI.SetActive(false);

    }
    public void ShowInGameUI()
    {
        homeUI.SetActive(false);
        inGameUI.SetActive(true);
    }
    public void ShowWinUI()
    {
        winUI.SetActive(true);
    }
}
 