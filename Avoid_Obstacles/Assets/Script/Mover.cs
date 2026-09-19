using UnityEngine;

public class Mover : MonoBehaviour
{
    void Start()
    {
    }
    
    [SerializeField] float moveSpeed = 10f;
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
