using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.AI;

public class CubeMovement : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private List <CubeMovement> _targets;
    [SerializeField] private Transform _target;
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if(_target != null)
        {
            MoveToPoint(_target.position);
        }
        else
        {
            FindTarget();
        }
    }
    void FindTarget()
    {
        _targets = FindObjectsOfType<CubeMovement>().ToList();
        _targets.Remove(gameObject.GetComponent<CubeMovement>());
        if (_targets.Count == 0)
        {
            _target = null;
        }
        else
        {
            int index = Random.Range(0, _targets.Count);
            _target = _targets[index].gameObject.transform;
        }
    }
    void MoveToPoint(Vector3 point)
    {
        _navMeshAgent.SetDestination(point);
    }
}
