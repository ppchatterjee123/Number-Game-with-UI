using UnityEngine;
using System.Collections;

public class levelManager2 : MonoBehaviour {

	public void LoadLevel(string game)
	{
	Debug.Log("Request level:" +game);
	Application.LoadLevel(game);
	}
}
