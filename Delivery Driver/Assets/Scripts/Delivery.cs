using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyTime = 0.5f;

    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 0);

    SpriteRenderer spriteRenderer;
        private void Start()
    {
        hasPackage = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision`s just happened");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("You`ve just picked the delivery");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyTime);
        }

        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("The delivery is successfully delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
