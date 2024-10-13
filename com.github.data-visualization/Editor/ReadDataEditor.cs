using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ReadData))]
public class ReadDataEditor : Editor
{
    public override void OnInspectorGUI() {
        ReadData readData = (ReadData)target;
        readData.selectedFileIndex = EditorGUILayout.Popup("Select File", readData.selectedFileIndex, readData.filePath);
        if (GUI.changed) {
            EditorUtility.SetDirty(readData);
        }

        DrawDefaultInspector();
    }
}
