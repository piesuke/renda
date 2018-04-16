using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartsceneManager : MonoBehaviour {

	public void StartButton(){
		SceneManager.LoadScene ("Main");
	}
}
