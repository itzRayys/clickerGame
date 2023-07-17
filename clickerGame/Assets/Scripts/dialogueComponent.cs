using UnityEngine;

[System.Serializable]
public class dialogueComponent : MonoBehaviour
{
    public string speakerName;

    [TextArea(3, 10)]
    public string[] speakerLines;
}
