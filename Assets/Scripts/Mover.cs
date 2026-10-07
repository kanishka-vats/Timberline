using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float movespeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Translate(xValue, yValue, zValue);
    }
}
