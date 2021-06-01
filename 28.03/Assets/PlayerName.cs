using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
	public InputField inputF;
	public string Name;
	public GameObject Panel;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Name = inputF.textComponent.text;
	}
	public void ApplyName()
	{
		Panel.SetActive(false);
	}
}
