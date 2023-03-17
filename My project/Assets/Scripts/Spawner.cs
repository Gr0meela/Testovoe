using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private MeshFilter _plane;
    [SerializeField] private int _cubesCount;
    private Mesh _planeMesh;
    void Start()
    {
        _planeMesh = _plane.mesh;
        Spawn(_cube);
    }
    void Spawn(GameObject cube)
    {
        for(int i = 0; i<_cubesCount; i++)
        {
            float xPos = Random.Range(-_planeMesh.bounds.size.x, _planeMesh.bounds.size.x);
            float zPos = Random.Range(-_planeMesh.bounds.size.z, _planeMesh.bounds.size.z);
            Vector3 position = new Vector3(xPos, 0, zPos);
            Instantiate(cube, position, Quaternion.identity);
        }
    }
}
