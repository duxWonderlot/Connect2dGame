using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//will not included in build version of project
public class UnityUITools : EditorWindow
{
    //far fancy textures looks
    Texture2D hearderSectiontexture;
    Texture2D magesectiontexute;
    Texture2D warriorsectiontexture;
    Texture2D rouguesectiontexture;

    Color headerSelector = new Color(13f / 255f, 32f / 255f, 44f / 255f, 1f);

    Rect headerSection;
    Rect mageSection;
    Rect warriorSection;
    Rect rougeSection;


    [MenuItem("Window/playerDesigner")]
    static void OpenWindow()
    {
        UnityUITools window = (UnityUITools)GetWindow(typeof(UnityUITools));
        window.maxSize = new Vector3(Screen.width, Screen.height);
        window.Show();
    }
    //Awake or start
    void OnEnable()
    {
        InitTextures(); //for fancytextures and normals ones
    }  
     void OnGUI()
    {
        DrawLayouts();
        DrawHearder();
        DrawMageSettings();
        DrawRougeSettings();
        DrawWarriorSettings();
    }
    //intialize text 2d values
    void InitTextures()
    {
        hearderSectiontexture = new Texture2D(1, 1);
        hearderSectiontexture.SetPixel(0, 0, headerSelector);
        hearderSectiontexture.Apply();
    }
    void DrawLayouts()
    {
        headerSection.x = 0;
        headerSection.y = 0;
        headerSection.width = Screen.width;
        headerSection.height = 40;

        GUI.DrawTexture(headerSection, hearderSectiontexture);
    }
    void DrawHearder()
    {
        GUILayout.BeginArea(headerSection);
        GUILayout.Label("Enemy Designer");
        GUILayout.EndArea();
    }
    void DrawMageSettings()
    {

    }
    void DrawWarriorSettings()
    {

    }
    void DrawRougeSettings()
    {

    }
}
