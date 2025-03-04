using UnityEngine;
using UnityEngine.InputSystem;

public class ShootInput : MonoBehaviour
{
    public void OnShoot(InputValue value)
    {
        Debug.Log("Shoot");
    }
}
