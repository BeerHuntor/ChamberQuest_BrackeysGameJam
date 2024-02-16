using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    [SerializeField] private float playerMoveSpeed;

    [SerializeField] private GameInput gameInput; 

    private bool isWalking; 

    private void Update() {

        HandleMovement();


    
    }

    private void HandleMovement() {

        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, inputVector.y, 0);

        isWalking = moveDir != Vector3.zero;
        transform.position += moveDir * playerMoveSpeed * Time.deltaTime;
    }

    public bool IsWalking() {
        return isWalking;
    }
}
