using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Text txtCoin, txtScore;
	public GameObject gm;
	private void FixedUpdate()
	{
		if (!ConstComponent.Game)
		{
			Debug.Log (txtCoin.text);
			txtCoin.text = ConstComponent.coin.ToString ();
			txtScore.text = ConstComponent.MaxScore.ToString ();
		}

	}

	void Start()
	{
		txtCoin.text = "1";
	}

	public void PlayStart()
	{
		ConstComponent.Game = true;
		ConstComponent.coinCurrent = 0;
		SceneManager.LoadScene ("PlayScene");
		DontDestroyOnLoad (gm);
	}
	public void Shop()
	{
		
	}
	public void Stats()
	{
		
	}
	public void Music()
	{
		
	}
	public void GooglePlay()
	{
		Application.OpenURL ("https://kenney.nl/assets/page:3?q=2d");
	}
	public void Sound()
	{
		
	}
}
