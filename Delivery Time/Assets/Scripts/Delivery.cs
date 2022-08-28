using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0,  0);

    bool isPickedup = false;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("bruh");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Package") && !isPickedup)
        {
            Debug.Log("Paket alýndý.");
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject);
            isPickedup = true;
        }

        if (collision.tag.Equals("Customer") && isPickedup)
        {       
            Debug.Log("Paket teslim edildi.");
            spriteRenderer.color = noPackageColor;
            Destroy(collision.gameObject);
            isPickedup = false;        
        }
    }
}
