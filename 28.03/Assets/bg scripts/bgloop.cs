using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgloop : MonoBehaviour
{
    public float speed = 0.1f;//швидкість руху фону
    private Vector2 offset = Vector2.zero;
    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.x += speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", offset);
    }
}
