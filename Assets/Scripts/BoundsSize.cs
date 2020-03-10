using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsSize : MonoBehaviour
{
    private Renderer rend = null;
    public GameObject prefab;

    private GameObject top;
    private GameObject bottom;
    private GameObject left;
    private GameObject right;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        top = Instantiate(prefab);
        bottom = Instantiate(prefab);
        left = Instantiate(prefab);
        right = Instantiate(prefab);
    }

    private void Update()
    {
        var position = rend.transform.position;
        position.y += rend.bounds.size.y;

        top.transform.position = position;


        position = rend.transform.position;

        var rotation = Vector3.zero;
        rotation.z = 180;

        bottom.transform.position = position;
        bottom.transform.eulerAngles = rotation;


        position = rend.transform.position;
        position.x -= rend.bounds.extents.x;
        position.y += rend.bounds.extents.y;

        rotation = Vector3.zero;
        rotation.z = 90;

        left.transform.position = position;
        left.transform.eulerAngles = rotation;


        position = rend.transform.position;
        position.x += rend.bounds.extents.x;
        position.y += rend.bounds.extents.y;

        rotation = Vector3.zero;
        rotation.z = -90;

        right.transform.position = position;
        right.transform.eulerAngles = rotation;
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 1f, 0f, 0.3f);

        Gizmos.DrawCube(rend.bounds.center, rend.bounds.size);
    }
}
