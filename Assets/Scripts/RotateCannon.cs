using UnityEngine;
using System.Collections;

public class RotateCannon : MonoBehaviour
{
    public Color c1 = Color.yellow;
    public Color c2 = Color.red;

    // Use this for initialization
    void Start()
    {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        c1.a = 0.4f;
        c2.a = 0.2f;
        lineRenderer.SetColors(c2, c1);
        lineRenderer.SetWidth(0.1f, 0.1f);
        lineRenderer.SetVertexCount(2);
        lineRenderer.sortingOrder = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, gameObject.transform.position);
        lineRenderer.SetPosition(1, mousePos);
    }
}
