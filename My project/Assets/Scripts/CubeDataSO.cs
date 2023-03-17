using UnityEngine;

[CreateAssetMenu(fileName = "CubeData", menuName = "ScriptableObjects/Cube")]
public class CubeDataSO : ScriptableObject
{
    [Range(1, 100)]
    public int Health;

    [Range(5, 50)]
    public int Damage;

}
