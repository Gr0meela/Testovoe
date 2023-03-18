using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAttack : MonoBehaviour
{
    public int Score = 0;
    private int _damage;
    [SerializeField] private CubeDataSO _cubeData;
    void Start()
    {
        _damage = _cubeData.Damage;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CubeHealth>())
        {
            IEnumerator coroutine = Attack(collision.gameObject.GetComponent<CubeHealth>());
            StartCoroutine(coroutine);
        }
    }
    IEnumerator Attack(CubeHealth cube)
    {
        if (cube != null)
        {
            cube.Health -= _damage;
            if (cube.Health <= 0)
                Score++;
            yield return new WaitForSeconds(1);
            IEnumerator coroutine = Attack(cube);
            StartCoroutine(coroutine);
        }
        else 
            yield return null;
    }
}
