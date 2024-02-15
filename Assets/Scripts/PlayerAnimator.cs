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
    private string currentMovementDirection; 

    private Animator playerAnimator;

    private void Awake() {
        playerAnimator = GetComponent<Animator>();
    }
                
    private void Update() {
        playerAnimator.SetBool(IS_WALKING, player.IsWalking());
        playerAnimator.SetTrigger(MovementDirectionAnimationSelector());
        Debug.Log(gameInput.GetMovementVectorAsAngle());
    }

    private string MovementDirectionAnimationSelector() {
        float currentMovementAngle = gameInput.GetMovementVectorAsAngle();

        string currentMovementDirection = " ";

        if (currentMovementAngle == 0f) {
            //Moving North
            currentMovementDirection = "MOVING_NORTH";
        } else if (currentMovementAngle == 90f) {
            //Moving East
            currentMovementDirection = "MOVING_EAST";
        } else if (currentMovementAngle == 180f) {
            //Moving South
            currentMovementDirection = "MOVING_SOUTH";
        } else if (currentMovementAngle == 270f) {
            //Moving West
            currentMovementDirection = "MOVING_WEST";
        } else if (currentMovementAngle == 45f) {
            //Moving Nort East
            currentMovementDirection = "MOVING_NORTH_EAST";
        } else if (currentMovementAngle == 135f) {
            //Moving South East
            currentMovementDirection = "MOVING_SOUTH_EAST";
        } else if (currentMovementAngle == 225f) {
            //Moving South West
            currentMovementDirection = "MOVING_SOUTH_WEST";
        } else {
            //Moving North West
            currentMovementDirection = "MOVING_NORTH_WEST";
        }

            return currentMovementDirection;
        
    }
}
