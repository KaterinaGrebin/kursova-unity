using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogsName : MonoBehaviour
{
	public GameObject playerName;
	private string namePlayer;
	public string TextDialog;
	public Text txt1;
	public GameObject DialogPanel;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		namePlayer = playerName.GetComponent<PlayerName>().Name;
		txt1.text = "Привет " + namePlayer + TextDialog;
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			DialogPanel.SetActive(true);
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player")
		{
			DialogPanel.SetActive(false);
		}
	}
}
