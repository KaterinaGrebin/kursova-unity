using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public GameObject namePan;
    [SerializeField] private AudioSource bgSound;



    private void Start()
    {
        if (!PlayerPrefs.HasKey("Name")) namePan.SetActive(true);
        else Debug.Log("Welcome , " + PlayerPrefs.GetString("Name") + "\nYour age: " + PlayerPrefs.GetInt("Age"));

        bgSound.Play();
    }

    public void CheckName(string name)
    {
        if (!string.IsNullOrEmpty(name) && name.Length >= 3)
        {
            PlayerPrefs.SetString("Name", name);
            Debug.Log("Your name : " + name);
        }
        else Debug.Log("Input another name!!!!!!!!!!!");
    }

    public void CheckAge(string age)
    {
        if (!string.IsNullOrEmpty(age) && age.Length > 0)
        {
            PlayerPrefs.SetInt("Age", int.Parse(age));
            Debug.Log("Your age : " + age);
        }
        else Debug.Log("Input another age!!!!!!!!!!!");
    }
}
