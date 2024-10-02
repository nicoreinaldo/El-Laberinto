using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterAnimation : MonoBehaviour
{
    private Animator agentAnimator;

    private void Awake()
    {
        agentAnimator = GetComponent<Animator>();
    }

    public void SetWalkAnimation(bool up, bool down, bool sideways)
    {
        agentAnimator.SetBool("WalkUp", up);
        agentAnimator.SetBool("WalkDown", down);
        agentAnimator.SetBool("WalkSize", sideways);
    }

    public void AnimatePlayer(Vector2 velocity)
    {
        if (velocity.y > 0) // Moviendo hacia arriba
        {
            SetWalkAnimation(true, false, false);
        }
        else if (velocity.y < 0) // Moviendo hacia abajo
        {
            SetWalkAnimation(false, true, false);
        }
        else if (velocity.x != 0) // Moviendo lateralmente
        {
            SetWalkAnimation(false, false, true);
        }
        else // No hay movimiento
        {
            SetWalkAnimation(false, false, false);
        }
    }
}
