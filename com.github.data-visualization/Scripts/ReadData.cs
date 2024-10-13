using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class ReadData : MonoBehaviour
{
    public string[] filePath = {"path/to/your/file.csv", "path/to/your/second/file.csv"};
    public int selectedFileIndex = 0;
    private List<Vector3> scatterPlotPositions;

    void Start() {
        string filePath = this.filePath[selectedFileIndex];
        scatterPlotPositions = ReadCSV(filePath);
        foreach (var position in scatterPlotPositions) {
            // Create scatterplot points in Unity
            GameObject point = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            point.transform.position = position;
        }
    }

    List<Vector3> ReadCSV(string path) {
        List<Vector3> positions = new List<Vector3>();
        using (StreamReader sr = new StreamReader(path)) {
            string line;
            while ((line = sr.ReadLine()) != null) {
                string[] values = line.Split(',');
                if (values.Length == 6) {
                    float x = float.Parse(values[1]) * 10;
                    float y = float.Parse(values[2]) * 10;
                    float z = float.Parse(values[3]) * 10;
                    positions.Add(new Vector3(x, y, z));
                }
            }
        }
        return positions;
    }
}
