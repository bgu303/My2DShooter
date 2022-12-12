using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{

    public GameObject player;

    void Start()
    {
        // Cursor.visible = false;
    }

    
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
        transform.rotation = player.transform.rotation;
    }
}
