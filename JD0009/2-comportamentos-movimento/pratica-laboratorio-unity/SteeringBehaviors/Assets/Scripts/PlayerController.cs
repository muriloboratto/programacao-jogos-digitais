using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float maxVelocity = 6f;

    Rigidbody2D physics = null;

    void Update()
    {
        Vector3 normalizedInputDirection = new Vector3
        (
            x: Input.GetAxis("Horizontal"),
            y: Input.GetAxis("Vertical"),
            z: 0.0f
        ).normalized;

        physics.velocity = normalizedInputDirection * maxVelocity;
    }

    void Awake()
    {
        physics = GetComponent<Rigidbody2D>();
    }
}
