using UnityEngine;
using UnityEngine.UI;

public class CubeUI : MonoBehaviour
{
    private CubeAttack _cubeAttack;
    private CubeHealth _cubeHealth;
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _healthText;
    [SerializeField] private GameObject _canvas;
    void Start()
    {
        _cubeAttack = GetComponent<CubeAttack>();
        _cubeHealth = GetComponent<CubeHealth>();
    }
    void Update()
    {
        _scoreText.text = "Score: " + _cubeAttack.Score.ToString();
        _healthText.text = "Health: " + _cubeHealth.Health.ToString();
        LookAtCamera();
    }
    void LookAtCamera()
    {
        Vector3 toCamera = Camera.main.gameObject.transform.position - _canvas.transform.position;
        _canvas.transform.rotation = Quaternion.LookRotation(toCamera);
    }
}
