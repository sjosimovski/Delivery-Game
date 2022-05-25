using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    bool hasPackage;

    int carCrash;

    [SerializeField] GameObject deliveredPopup;
    [SerializeField] GameObject GameOverPopup;

    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    
    SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        carCrash++;

        if(carCrash == 10)
        {
            GameOverPopup.gameObject.SetActive(true);

            gameObject.SetActive(false);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            // Debug.Log("package");
            hasPackage = true;

            spriteRenderer.color = hasPackageColor;

            Destroy(collision.gameObject, 0.3f);
        }
        if(collision.tag == "DLocation" && hasPackage)
        {
            // Debug.Log("Delivered");
            hasPackage = false;

            spriteRenderer.color = noPackageColor;

            deliveredPopup.gameObject.SetActive(true);
            // Destroy(collision.gameObject, 0.3f);

            Invoke( "popUpDisable",1.2f);
        }
    }


    public void popUpDisable() // disable the delivered popup
    {
        deliveredPopup.gameObject.SetActive(false);
    }

   

}
