using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EndSceneManager : MonoBehaviour {

	public Text lastScoreText;
	public Text highScoreText;
	int highScore;
	int lastScore;

	void Start(){
		lastScore = PlayerPrefs.GetInt ("score");
		lastScoreText.text = lastScore.ToString();


	}
	public void RetryButton(){
		SceneManager.LoadScene ("StartScene");
	}
}
