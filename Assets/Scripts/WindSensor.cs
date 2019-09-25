using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSensor : MonoBehaviour {

    public WindZone windZone;
    private ParticleSystem partSystem;
    private ParticleSystem.Particle[] particles;
    private ParticleSystem.Particle particle;
    private ParticleSystem.EmitParams emitParams;

    private Vector3 windVelocity;

	void Start () {
        windZone = gameObject.GetComponent<WindZone>();
        partSystem = gameObject.GetComponent<ParticleSystem>();
        particles = new ParticleSystem.Particle[partSystem.main.maxParticles];
        this.emitParams = new ParticleSystem.EmitParams();
        emitParams.position = transform.position;
        emitParams.velocity = Vector3.zero;
        emitParams.startLifetime = 0.3f;
        partSystem.Emit(this.emitParams,1);
        partSystem.GetParticles(particles);
        particle = particles[0];
        particle.remainingLifetime = Mathf.Infinity;
        this.windVelocity = particle.velocity;
    }
	

    private void FixedUpdate()
    {
        partSystem.GetParticles(particles);
        this.particle = particles[0];
        this.windVelocity = particle.velocity;

        partSystem.Clear();
        emitParams.position = transform.position;
        emitParams.velocity = Vector3.zero;
        emitParams.startLifetime = 0.3f;
        partSystem.Emit(this.emitParams, 1);
        partSystem.GetParticles(particles);
        this.particle = particles[0];
        this.particle.velocity = Vector3.zero;
        
    }

    public Vector3 GetVelocity()
    {
        Debug.Log(this.windVelocity * 100);
        return this.windVelocity;
    }

}
