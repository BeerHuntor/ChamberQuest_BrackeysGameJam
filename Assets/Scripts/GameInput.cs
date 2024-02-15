using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private float angle;
    public Vector2 GetMovementVectorNormalized() {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W)) {
            inputVector.y = 1f;
        }
        if (Input.GetKey(KeyCode.S)) {
            inputVector.y = -1f;
        }
        if (Input.GetKey(KeyCode.A)) {
            inputVector.x = -1f;
        }
        if (Input.GetKey(KeyCode.D)) {
            inputVector.x = 1f;
        }

        Debug.Log(inputVector);

        return inputVector.normalized;
    }

    private void CalculateMovementVectorAsAngle() {
        angle = Mathf.Atan2(GetMovementVectorNormalized().x, GetMovementVectorNormalized().y) * Mathf.Rad2Deg;

        if ( angle < 0) {
            angle += 360f;
        }
    }

    public float GetMovementVectorAsAngle() {
        CalculateMovementVectorAsAngle();
        return angle;
    }
}
