using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
    [SerializeField] Color32 hasPacakgeColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPacakgeColor = new Color32(1, 1, 1, 1);

    public bool hasPackage;
    public bool deliverComplete;
    float destroyDelay = 0.1f;

    Score score;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        score = GetComponent<Score>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage )
        {
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPacakgeColor;
            score.CalculateTime();
        }

        if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            deliverComplete = true;
            spriteRenderer.color = noPacakgeColor;
            score.CalculateScore();
        }
    }
}
