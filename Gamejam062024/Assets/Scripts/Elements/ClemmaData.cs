using UnityEngine;

public class ClemmaData : MonoBehaviour
{
    public enum ClemmaType
    {
        L = 0,
        N = 1
    }

    public ClemmaType Type;

    public WireConnection Connection { get; set; } = null;
}
