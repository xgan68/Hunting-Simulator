using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class MicInput : MonoBehaviour {

	public delegate void VoiceAction();
	public static event VoiceAction OnHeard;

	public float sensitivity = 100;
	public float loudness = 0;
	AudioSource aaudio; 

	float voiceInterval = 1f;
	float nextVoiceTime = 0f;

	void Start() {
		
		GetComponent<AudioSource>().clip = Microphone.Start(null, true, 10, 44100);
		GetComponent<AudioSource>().loop = true; // Set the AudioClip to loop
		GetComponent<AudioSource>().mute = true; // Mute the sound, we don't want the player to hear it
		while (!(Microphone.GetPosition(null) > 0)){} // Wait until the recording has started
		GetComponent<AudioSource>().Play(); // Play the audio source!
		GetComponent<AudioSource>().mute = false;
	}

	void Update(){
		

		loudness = GetAveragedVolume() * sensitivity;
		if (loudness >= 10 && Time.time>=nextVoiceTime) {
			print (loudness);
			nextVoiceTime = Time.time + voiceInterval;
			if (OnHeard != null)
				OnHeard ();
		}

	}

	float GetAveragedVolume()
	{ 
		float[] data = new float[256];
		float a = 0;
		int micPosition = Microphone.GetPosition (null) - (256 + 1);
		GetComponent<AudioSource>().GetOutputData(data,0);
		foreach(float s in data)
		{
			a += Mathf.Abs(s);
		}
		return a/256;
	}





}