using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CroquetSettings", order = 1)]
public class CroquetSettings : ScriptableObject
{
    public string apiKey;
    public string appPrefix;
    public int preferredPort;
#if !UNITY_EDITOR_OSX && !UNITY_EDITOR_LINUX
    [HideInInspector]
#endif
    public string pathToNode;
}
