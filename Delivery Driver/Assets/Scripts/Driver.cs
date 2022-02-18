using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 80f;
    [SerializeField] float moveSpeed = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        float rotateAmount = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -rotateAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
