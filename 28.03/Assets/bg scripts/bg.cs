using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var height = Camera.main.orthographicSize * 2f;
        var width = height * Screen.width / Screen.height;//налаштовуємо об'єкт по осі х

        if (gameObject.name == "Background")
        {
            transform.localScale = new Vector3(width, height, 0);
        }
        
    }

    
}
