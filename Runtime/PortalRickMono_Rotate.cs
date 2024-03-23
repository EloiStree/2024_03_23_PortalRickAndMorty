using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRickMono_Rotate : MonoBehaviour
{

    public Transform m_whatToRotate;
    [Range(-720,720)]
    [Tooltip("Angle per seconds of rotation")]
    public float m_rotateSpeedInAngle = 50;
    public Space m_rotationType = Space.Self;
    public Vector3 m_axisRotation = Vector3.forward;


    void Update()
    {
        m_whatToRotate.Rotate(m_axisRotation, m_rotateSpeedInAngle * Time.deltaTime,m_rotationType);
    }

    [ContextMenu("Inverse rotate")]
    public void InverseRotation() {
        m_rotateSpeedInAngle = -m_rotateSpeedInAngle;
    }
    private void Reset()
    {
        m_whatToRotate = transform;
    }
}
