using UnityEngine;

public class CubeHealth : MonoBehaviour
{
    [SerializeField] private CubeDataSO _cubeData;
    public int Health;
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
