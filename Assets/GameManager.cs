using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Text txtCoin, txtScore;
	void OnApplicationQuit()
	{
		Debug.Log (ConstComponent.coin + " and " + ConstComponent.MaxScore);
		PlayerPrefs.SetInt ("Coin", ConstComponent.coin);
		PlayerPrefs.SetInt ("Score", ConstComponent.MaxScore);
		PlayerPrefs.Save ();

	}

	void Awake () {
        if (ConstComponent.loadResours)
        {
            if (PlayerPrefs.HasKey("Coin"))
            {
                int coin = PlayerPrefs.GetInt("Coin");
                ConstComponent.coin = coin;
                txtCoin.text = coin.ToString();
            }

            if (PlayerPrefs.HasKey("Score"))
            {
                int score = PlayerPrefs.GetInt("Score");
                ConstComponent.MaxScore = score;
                txtScore.text = score.ToString();
            }

            ConstComponent.loadResours = false;
        }
	}

}
