using UnityEngine;
using UnityEditor;

public class CustomTool : EditorWindow
{
    [MenuItem("CustomTools/Make Primitive")]
    public static void ShowWindow()
    {
        GetWindow<CustomTool>("Make Primitive");
    }

    private void OnGUI()
    {
        if(GUILayout.Button("Make Cube"))
        {
            CreateCube();
        }
    }

    private void CreateCube()
    {
        GameObject cube=GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
