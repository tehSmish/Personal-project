using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public static CursorController instance;

    [SerializeField] Texture2D crosshair;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        activateCrosshair();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateCrosshair()
    {
        Cursor.SetCursor(crosshair, new Vector2(crosshair.width / 2, crosshair.height / 2), CursorMode.Auto);
    }
}
