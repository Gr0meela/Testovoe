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
        for (int i = 0; i < _cubesCount; i++)
        {
            float xPos = Random.Range(-_planeMesh.bounds.size.x, _planeMesh.bounds.size.x);
            float zPos = Random.Range(-_planeMesh.bounds.size.z, _planeMesh.bounds.size.z);
            Spawn(_cube, xPos, zPos);
        }
    }
    private void Update()
    {
        Vector3 spawnPosition = Vector3.zero;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            spawnPosition = hit.point;
            if (Input.GetMouseButtonDown(0))
            {
                Spawn(_cube, spawnPosition.x, spawnPosition.z);
            }
        }
    }
    void Spawn(GameObject cube, float x, float z)
    {
        Vector3 position = new Vector3(x, 0, z);
        Instantiate(cube, position, Quaternion.identity);
    }
}
