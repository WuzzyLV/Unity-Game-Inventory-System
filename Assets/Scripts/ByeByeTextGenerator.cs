using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ByeByeTextGenerator : MonoBehaviour
{

	// Use this for initialization
	[SerializeField] public String[] stories;
	private void Awake()
	{
		GetComponent<Text>().text = stories[UnityEngine.Random.Range(0, stories.Length)]
			.Replace("{name}", GameManager.GetName()).Replace("{age}", GameManager.GetAge().ToString());
	}
}