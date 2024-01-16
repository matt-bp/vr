using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActivateAllDisplays : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"Displays connected: {Display.displays.Length}");

        List<DisplayInfo> temp = new();
        Screen.GetDisplayLayout(temp);

        foreach (var l in temp)
        {
            Debug.Log($"Info: {l.name}");
        }
        
        foreach (var t in Display.displays)
        {
            // Debug.Log($"Display info: {t.}")

            t.Activate();
        }
    }
}
