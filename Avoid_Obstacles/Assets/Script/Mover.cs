using UnityEngine;

public class Mover : MonoBehaviour
{
    void Start()
    {
    }
    
    [SerializeField] float MoveSpeed = 10f;
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
