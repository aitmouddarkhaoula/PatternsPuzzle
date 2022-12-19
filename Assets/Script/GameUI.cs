using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public static GameUI instance;
    public GameObject homeUI;
    public GameObject inGameUI;
    public GameObject winUI;
    private Slider slider;
    private float targetProgress = 0;
    public float fillSpeed = 0.5f;
    // Start is called before the first frame update
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        instance = this;
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(slider.value < targetProgress)
		{
            slider.value += fillSpeed * Time.deltaTime;
		}*/
        
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
        inGameUI.SetActive(false);
    }
    public void IncrementProgress(float newProgress)
	{
        //targetProgress = slider.value + newProgress; 
	}
}
 