using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurseurManager : MonoBehaviour
{
    [SerializeField] private Texture2D Curseur;
    
    private Vector2 cursorHotspot;
    
    void Start()
    {
    	cursorHotspot = new Vector2(Curseur.width/2,Curseur.height/2);
    	Cursor.SetCursor(Curseur,cursorHotspot,CursorMode.Auto);
    }
    
}
