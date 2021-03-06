using System;
using UnityEngine;

/// <summary>
/// Movement script for the dolphin character.
/// Adapted from UnityStandardAsset "Ball"
/// </summary>
public class PorpoiseController : MonoBehaviour
{
    [SerializeField] private float m_MovePower = 5; // The force added to the porpoise to move it.
    [SerializeField] private bool m_UseTorque = true; // Whether or not to use torque to move the ball.
    [SerializeField] private float m_MaxAngularVelocity = 25; // The maximum velocity the ball can rotate at.
    [SerializeField] private float m_JumpPower = 2; // The force added to the ball when it jumps.

    private const float k_GroundRayLength = 1f; // The length of the ray to check if the ball is grounded.
    private Rigidbody m_Rigidbody;


    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        // Set the maximum angular velocity.
        GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
    }


    public void Move(Vector3 moveDirection, bool jump)
    {
        // Otherwise add force in the move direction.
        m_Rigidbody.AddForce(moveDirection*m_MovePower);

        // If jump is pressed...
        if (jump)
        {
            // ... add force in upwards.
            m_Rigidbody.AddForce(Vector3.up*m_JumpPower, ForceMode.Impulse);
        }
    }

    public void ShootSonar( bool shoot )
    {
      if( shoot )
      {
        
      }
    }
}
