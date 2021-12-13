using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color playerColor;

    public Camera gameCamera;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = playerColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameCamera.GetComponent<Camera>().backgroundColor = playerColor;
    }
}
