# Rube_Goldberg_Machine

## Part 1
* BallGoBack
* AudioPlay
  * Collision
  * Trigger
* GenericEvent
* CamFollow Ball

## Part 2
* Text Mesh Pro, eigener Font
  * Time
  * Rounds
* Trampolin
* Teleporter 
* ResetPosition

Übung: Particle System mit GenericEvents
Magic Effects Free von Hovi Studio https://assetstore.unity.com/packages/vfx/particles/spells/magic-effects-free-247933

## Collider & Trigger

```
private void OnTriggerEnter(Collider other)
Debug.Log("Generic Trigger detected with " + other.gameObject.name);

private void OnCollisionEnter(Collision collision)
Debug.Log("Generic Collision detected with " + collision.gameObject.name);
```

## Event Example

```
[SerializeField] private UnityEvent myColliderEventEnter = null;
```
