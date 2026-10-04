// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
[Serializable]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 16653
{
	// Methods

	// RVA: 0x37FCE1C Offset: 0x37F8E1C VA: 0x37FCE1C
	public void .ctor() { }

	// RVA: 0x37FCE24 Offset: 0x37F8E24 VA: 0x37FCE24 Slot: 13
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x37FCE28 Offset: 0x37F8E28 VA: 0x37FCE28 Slot: 14
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x37FCE2C Offset: 0x37F8E2C VA: 0x37FCE2C Slot: 15
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x37FCE30 Offset: 0x37F8E30 VA: 0x37FCE30 Slot: 16
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x37FCE34 Offset: 0x37F8E34 VA: 0x37FCE34 Slot: 17
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x37FCE38 Offset: 0x37F8E38 VA: 0x37FCE38 Slot: 18
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x37FCE3C Offset: 0x37F8E3C VA: 0x37FCE3C Slot: 19
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x37FCE40 Offset: 0x37F8E40 VA: 0x37FCE40 Slot: 20
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x37FCE44 Offset: 0x37F8E44 VA: 0x37FCE44 Slot: 21
	public virtual object Clone() { }
}
