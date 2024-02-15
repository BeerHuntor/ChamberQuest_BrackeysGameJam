using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private GameInput gameInput;

    private const string IS_WALKING = "IS_WALKING";
    private const string X_MOVEMENT_VALUE = "X_MOVEMENT_VALUE";
    private const string Y_MOVEMENT_VALUE = "Y_MOVEMENT_VALUE";

    private Animator playerAnimator;

    private void Awake() {
        playerAnimator = GetComponent<Animator>();
    }
                
    private void Update() {
        playerAnimator.SetBool(IS_WALKING, player.IsWalking());
        SelectWalkAnimation(gameInput.GetMovementVectorNormalized());
    }

    private void SelectWalkAnimation(Vector3 direction) {

        playerAnimator.SetFloat(X_MOVEMENT_VALUE, direction.x);
        playerAnimator.SetFloat(Y_MOVEMENT_VALUE , direction.y);    

    }
}
