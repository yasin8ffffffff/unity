using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSoundController : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource engineAudio;
    public float minPitch = 0.8f;
    public float maxPitch = 2.0f;
    public float maxSpeed = 5f;
   

    // Update is called once per frame
    void Update()
    {
        float speed = rb.velocity.magnitude;
        float pitch = Mathf.Lerp(minPitch, maxPitch, speed / maxSpeed);
        engineAudio.pitch = pitch;
    }
}
