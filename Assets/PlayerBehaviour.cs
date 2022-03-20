using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Transform transformByGetComponent;
    [SerializeField]
    private Transform transformByReference;


    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello world!");
        transformByGetComponent = GetComponent<Transform>();
    }

    private void OnEnable()
    {
        Debug.Log("Je m'active!");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transformByGetComponent.position = transformByGetComponent.position + new Vector3(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Attention à avoir défini la référence
            transformByReference.position = transformByGetComponent.position + new Vector3(0, -0.1f, 0);
        }
    }

    private void OnDisable()
    {
        Debug.Log("Je me désactive.");
    }
}
