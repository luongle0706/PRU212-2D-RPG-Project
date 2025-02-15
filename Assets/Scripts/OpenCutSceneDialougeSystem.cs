using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenCutSceneDialougeSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;

    public void Start()
    {
        textLabel.text = "Hello!\nThis is my demo";
    }
}
