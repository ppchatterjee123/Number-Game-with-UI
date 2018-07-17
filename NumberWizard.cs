using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxtries = 9;
	public Text text;
	
	void Start () 
	{
		 StartGame();
	}
	
	void StartGame()
	{
		max=1000;
		min=1;
		//guess=500;
		NextGuess();
		max = max+1;
		/*print("+++++++++++++++++++++++++++++++++++++++++++");
		print("welcome to Number Wizard");
		print("Pick a number and dont tell me");
		
		
		print (" The highest number you can pick is "    +max);
		*/
	
		/*
		print (" The lowest number you can pick is "   +min);
		
		print (" Is the number higher or lower than " +guess);
		
		/*print (" If the number is higher than 500 press up arrow");
		print (" If the number is lower than 500 press down arrow");
		print (" If the number is equal to 500 press Enter");
		*/
		//print (" up = higher, down = lower, Return = Equal");
	}
	
// Update is called once per frame
	
		
		/*if (Input.GetKeyUp(KeyCode.UpArrow)){
			// print("Up arrow pressed");
			min = guess;
			NextGuess ();
			
			}
		else if (Input.GetKeyUp(KeyCode.DownArrow)){
			
			//print("Down arrow pressed");
			max= guess;
			NextGuess ();
			
			}
		else if (Input.GetKeyUp(KeyCode.Return)){
			print("Won, Well Played");
			StartGame();
			}*/
	
	public void lower(){
		min = guess;
		NextGuess ();
	}
	public void higher(){	
		max= guess;
		NextGuess ();
	}
	
	
			
	
	void NextGuess()
	{
		//guess = (min + max)/ 2;
		guess =  Random.Range(min,max);
		text.text=guess.ToString();
		maxtries = maxtries - 1 ;
		if (maxtries<=0){
		Application.LoadLevel("Lose");
		}
		
		
		
		
		
		
		//print ("Higher or lower than"  +guess);
		//print (" up = higher, down = lower, Return = Equal");
	}
}
