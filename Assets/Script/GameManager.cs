using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    bool _gameWin = false;
	void Awake()
	{
        instance = this;
	}
	void Start()
    {
		isInGame = _gameWin = false;
    }

	// Update is called once per frame
	public void Init()
	{
		StartGame(false);
		_gameWin = false;
	}

	public void Win()
	{
		if (!_gameWin)
		{
		   GameUI.instance.ShowWinUI();
			_gameWin = true;
			isInGame = false;
		}
	}

    public void StartGame(bool active)
	{
        isInGame = active;
		if (active)
		{
            GameUI.instance.ShowInGameUI();
		}
		else
		{
            GameUI.instance.ShowHomeUI();
		}
	}

    public bool isInGame { get; set; }


}
