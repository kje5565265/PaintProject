using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class TextureResizerWindow : EditorWindow
{
    private string folderPath = "Assets";
    private Object folderObject;

    [MenuItem("Tools/Texture Resizer (4x Alignment)")]
    public static void ShowWindow()
    {
        GetWindow<TextureResizerWindow>("Texture Resizer");
    }

    void OnGUI()
    {
        GUILayout.Label("Target Folder", EditorStyles.boldLabel);

        EditorGUILayout.BeginHorizontal();
        folderPath = EditorGUILayout.TextField(folderPath);
        if (GUILayout.Button("Select", GUILayout.Width(60)))
        {
            string selected = EditorUtility.OpenFolderPanel("Select Folder", Application.dataPath, "");
            if (!string.IsNullOrEmpty(selected))
            {
                if (selected.StartsWith(Application.dataPath))
                    folderPath = "Assets" + selected.Substring(Application.dataPath.Length);
                else
                    Debug.LogWarning("Selected folder must be within the Assets directory.");
            }
        }
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(10);

        GUILayout.Label("Or Drag Folder Here:");
        folderObject = EditorGUILayout.ObjectField(folderObject, typeof(DefaultAsset), false);
        if (folderObject != null)
        {
            string objPath = AssetDatabase.GetAssetPath(folderObject);
            if (AssetDatabase.IsValidFolder(objPath))
            {
                folderPath = objPath;
            }
            else
            {
                Debug.LogWarning("Dragged object is not a valid folder.");
            }
        }

        GUILayout.Space(10);

        if (GUILayout.Button("Resize Textures to 4x Multiple"))
        {
            ResizeTexturesInFolder(folderPath);
        }
    }

    private void ResizeTexturesInFolder(string path)
    {
        string[] guids = AssetDatabase.FindAssets("t:Texture2D", new[] { path });
        List<string> resized = new List<string>();

        foreach (string guid in guids)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            Texture2D tex = AssetDatabase.LoadAssetAtPath<Texture2D>(assetPath);

            if (tex == null || tex.width % 4 == 0 && tex.height % 4 == 0)
                continue;

            string fullPath = Path.Combine(Application.dataPath, assetPath.Substring(7));

            Texture2D readableTex = new Texture2D(tex.width, tex.height, TextureFormat.RGBA32, false);
            byte[] fileData = File.ReadAllBytes(fullPath);
            readableTex.LoadImage(fileData);

            int newWidth = Mathf.CeilToInt(readableTex.width / 4f) * 4;
            int newHeight = Mathf.CeilToInt(readableTex.height / 4f) * 4;

            Texture2D newTex = new Texture2D(newWidth, newHeight, TextureFormat.RGBA32, false);
            Color32[] pixels = new Color32[newWidth * newHeight];

            for (int y = 0; y < readableTex.height; y++)
            {
                for (int x = 0; x < readableTex.width; x++)
                {
                    pixels[y * newWidth + x] = readableTex.GetPixel(x, y);
                }
            }

            newTex.SetPixels32(pixels);
            newTex.Apply();

            byte[] pngData = newTex.EncodeToPNG();
            File.WriteAllBytes(fullPath, pngData);

            resized.Add(assetPath);
        }

        AssetDatabase.Refresh();

        if (resized.Count > 0)
        {
            Debug.Log("[Texture Resizer] Resized the following textures:\n" + string.Join("\n", resized));
        }
        else
        {
            Debug.Log("[Texture Resizer] All textures were already 4x aligned.");
        }
    }
}
