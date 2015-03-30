using UnityEngine;
using System.Collections;

public class WF_Fading : MonoBehaviour 
{
    public Texture2D fadeTex;
    public float faderate = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;
	
    void OnGUI()
    {
        alpha += fadeDir * faderate * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTex);
    }

    public float BeginFade (int dir)
    {
        fadeDir = dir;
        return faderate;
    }

    void OnLevelWasLoaded()
    {
        BeginFade(-1);
    }
}
