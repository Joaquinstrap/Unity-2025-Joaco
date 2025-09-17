using UnityEngine;
using UnityEngine.InputSystem;
public class movimiento : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public float m_speed;
    [SerializeField] private UnityEngine.RigidBody2D m_rigidbody;
    private Vector2 appliedMovement;

    private void FixedUpdate()
    {
        HandleXMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onmove(InputAction.CallbackContext context)
    {
        appliedMovement = context.ReadValue<Vector2>();
    }

    private void HandleXMovement()
    {
        m_rigidbody.linearVelocity = new(m_speed * Time.deltaTime * appliedMovement.x, m_rigidbody.linearVelocity.y);
    }



}   
