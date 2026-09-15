using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float xValue = 0.00f;
    [SerializeField] float yValue = 0.01f;
    [SerializeField]float zValue = 0.00f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
