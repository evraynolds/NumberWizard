using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class NumberWizard : MonoBehaviour {

	int min = 1, max = 1000, guess;
	public int maxGuessesAllowed = 5;
	public TextMeshProUGUI textDisplayed;
	
	void Start () {

		max = max + 1;
		NextGuess();
	}
	

	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	public void NextGuess(){
		guess = Random.Range(min, max + 1);
		textDisplayed.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if(maxGuessesAllowed <= 0){
			SceneManager.LoadScene("Win");
		}
	}
}
