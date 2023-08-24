using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public Vector3 rotvector;
    [SerializeField] private GameObject TurbineObject;
    private bool rotate = true;

    public void ToggleRotation()
    {
        rotate = !rotate;
    }

    private void Update()
    {
        if (rotate && TurbineObject != null)
        {
            TurbineObject.transform.Rotate(rotvector * Time.deltaTime);
        }
    }
}
