using UnityEngine;

public class CubeHealth : MonoBehaviour
{
    [SerializeField] private CubeDataSO _cubeData;
    public int Health { private get; set; }
    void Start()
    {
        Health = _cubeData.Health;
    }
    private void Update()
    {
        if( Health <= 0 )
        {
            Death();
        }
    }
    void Death()
    {
        Destroy(gameObject);
    }
}
