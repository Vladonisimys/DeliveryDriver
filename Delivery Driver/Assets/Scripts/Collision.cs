using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision`s just happened");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You passed the trigger");
    }
}
