using UnityEngine;
using System.Collections;

public class Transparency : MonoBehaviour
{
    private Renderer rend;
    private float timer;
    private Color originalColor;
    private Color newColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
        newColor = originalColor;

        //Set new colour's alpha to half of old colour
        newColor.a = newColor.a / 2;
        rend.material.SetColor("Black", newColor);
        rend.material.color = newColor;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.05f)
        {
            //Turn off transparency
            Debug.Log("Turned off");
            rend.enabled = true;
            rend.material.color = originalColor;
            Destroy(this);
        }
    }

    public void ResetTimer()
    {
        timer = 0f;
    }

}