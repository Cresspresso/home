﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(KeyCardReader))]
public class VictoryKcr : MonoBehaviour
{
	public KeyCardReader interactable { get; private set; }

	public ParticleSystem ps;
	public GroundhogDay groundhogDay;

	private void Awake()
	{
		interactable = GetComponent<KeyCardReader>();

		Debug.Assert(groundhogDay, "groundhogDay is null", this);

		interactable.interactEventComponent.onInteract.AddListener(OnInteract);
	}

	private void OnDestroy()
	{
		interactable.interactEventComponent.onInteract.RemoveListener(OnInteract);
	}

	private void OnInteract(InteractEventArgs eventArgs)
	{
		groundhogDay.enabled = false;
		ps.Play();
	}
}
