using UnityEngine;

public class applefinder : MonoBehaviour

{

    private void OnTriggerEnter2D(Collider2D collision)

    {

        if (!collision.gameObject.CompareTag("Player"))

            return;

        AppleUIManager uiManager = FindObjectOfType<AppleUIManager>();

        if (uiManager != null)

        {

            uiManager.AddApple();

        }

        Destroy(gameObject);

    }

}
