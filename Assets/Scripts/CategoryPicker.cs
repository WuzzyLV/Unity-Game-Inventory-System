using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryPicker : MonoBehaviour
{
	[SerializeField] public GameObject[] categories;

	private void Awake()
	{
		SetCategory(0);
	}

	public void SetCategory(int i)
	{
		foreach (var category in categories)
		{
			category.SetActive(false);
		}
		categories[i].SetActive(true);
	}
}
