using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farsight_Pickup : MonoBehaviour
{
    public Camera cam;
    public LayerMask buyables;
    BinContent BinContent;

    // Start is called before the first frame update
    void Start()
    {
        cam = FindAnyObjectByType<Camera>();
        //BinContent = FindAnyObjectByType(BinContent);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);

        if (Input.GetMouseButtonDown(0)) 
        { 
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.Log("You have, indeed, pressed Mouse1");

            if (Physics.Raycast(ray, out hit, 100, buyables)) 
            {
                Debug.Log(hit.transform.name);
                if (hit.collider.TryGetComponent(out BinContent bin))
                {
                    bin.AddToInventory();
                }

            }
        }
    }
}
