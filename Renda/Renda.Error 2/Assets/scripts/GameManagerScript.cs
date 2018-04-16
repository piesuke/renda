using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

	int count;
	public Text countText;
	public Text timerText;
	float timer = 10.0f;
	public Text buttonText;
	bool isPlaying = false;
	GameObject rendaSound;

	void Start ()
	{
		buttonText.text = "スタート";
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isPlaying == true) {

			timer -= Time.deltaTime;
			timerText.text = timer.ToString ("f2");
		}
		if (timer < 0) {
			isPlaying = false;	
			timer = 0;
			timerText.text = timer.ToString ("f2");
			buttonText.text = "フィニッシュ";
			PlayerPrefs.GetInt ("score", count);
			SceneManager.LoadScene ("EndScene");
		}
	}

	public void CountUP ()
	{
		if (isPlaying == true) {
			count += 1;
			countText.text = count.ToString ();
			GameObject rendaSoundClone= Instantiate (rendaSound) as GameObject;
			Destroy (rendaSoundClone, 3.0f);

		} else {
			isPlaying = true;
			buttonText.text = "おせ！";
			countText.text = "0";
			
		}
	}
}
