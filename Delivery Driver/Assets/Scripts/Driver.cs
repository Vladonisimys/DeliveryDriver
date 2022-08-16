using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 80f;
    [SerializeField] float moveSpeed = 11f;
    [SerializeField] float SlowSpeed = 7.5f;
    [SerializeField] float fastSpeed = 17f;
   
    void Update()
    {
        float rotateAmount = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -rotateAmount);
        transform.Translate(0, moveAmount, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = SlowSpeed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boost")
        {
            moveSpeed = fastSpeed;
            Destroy(collision.gameObject, 0.2f);
        }
    }
}
