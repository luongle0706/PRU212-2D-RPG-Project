using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [Range(0, 10)]
    public float smoothFactor;
    private Vector3 offset;
    public Vector3 minValue, maxValue;
    Vector3 playerPosition;

    void Start()
    {
        offset = new Vector3(0, 0, -10);
    }

    void FixedUpdate()
    {
        playerPosition = player.position + offset;
        transform.position = playerPosition;
        Vector3 boundPos = new Vector3(
        Mathf.Clamp(playerPosition.x, minValue.x, maxValue.x),
        Mathf.Clamp(playerPosition.y, minValue.y, maxValue.y),
        Mathf.Clamp(playerPosition.z, minValue.z, maxValue.z));
        transform.position = Vector3.Lerp(transform.position, boundPos,
       smoothFactor);
    }
}