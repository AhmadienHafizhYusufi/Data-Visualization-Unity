using UnityEditor;
using UnityEngine;

public class CustomToolbar : EditorWindow
{
    [MenuItem("Window/Custom Toolbar")]
    public static void ShowWindow() {
        GetWindow<CustomToolbar>("Custom Toolbar");
    }

    void OnGUI() {
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Button 1")) {
            Debug.Log("Button 1 clicked");
        }

        if (GUILayout.Button("Button 2")) {
            Debug.Log("Button 2 clicked");
        }

        if (GUILayout.Button("Button 3")) {
            Debug.Log("Button 3 clicked");
        }

        GUILayout.EndHorizontal();
    }
}
