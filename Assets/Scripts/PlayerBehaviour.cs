using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _playerRB;
    [SerializeField]
    private Rigidbody2D _movePositionRB;
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
        Vector2 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Attention � avoir d�fini la r�f�rence
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

        //Le composant RigidBody prend d�j� en compte le DeltaTime! Le rappliquer le rendrait � nouveau d�pendant.
        _playerRB.velocity += movement.normalized * _movementSpeed;
        _movePositionRB.MovePosition(_movePositionRB.position + movement.normalized * _movementSpeed);
    }

    private void OnDisable()
    {
        Debug.Log("Je me d�sactive.");
    }
}
