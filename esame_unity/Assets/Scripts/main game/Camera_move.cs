using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    public GameObject camera_target;
    public float speed_cam = 3.0f;

    void FixedUpdate()
    {
        float interpolation = speed_cam * Time.deltaTime;

        Vector3 position = this.transform.position;

        position.x = Mathf.Lerp(this.transform.position.x, camera_target.transform.position.x, interpolation);
        position.z = Mathf.Lerp(this.transform.position.z, camera_target.transform.position.z, interpolation)-0.3f;

        this.transform.position = position;
    }

}
