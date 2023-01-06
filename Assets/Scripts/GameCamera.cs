using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class GameCamera : MonoBehaviour
{
    public Camera gameCamera;

    public float deltaX;
    public float deltaY;

    public float xRot;
    public float yRot;


    // Start is called before the first frame update
    void Start()
    {
        gameCamera = Camera.main;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCameraLook(InputValue value)
    {

    }
}
