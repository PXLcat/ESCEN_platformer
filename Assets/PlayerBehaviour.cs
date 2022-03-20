using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;
    [SerializeField]
    private float _movementSpeed = 0.5f;


    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello world!");
    }

    private void OnEnable()
    {
        Debug.Log("Je m'active!");
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Attention à avoir défini la référence
            movement.y += _movementSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y -= _movementSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x -= _movementSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x += _movementSpeed;
        }

        _playerTransform.position += movement * Time.deltaTime;
    }

    private void OnDisable()
    {
        Debug.Log("Je me désactive.");
    }
}
