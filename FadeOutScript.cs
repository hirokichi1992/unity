using UnityEngine;
using System.Collections;

public class FadeOutScript : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    float delta;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime / 10;
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material.color -= new Color(0, 0, 0, this.delta);
        if (this.delta > 1)
        {
            Destroy(gameObject);
        }
    }
}