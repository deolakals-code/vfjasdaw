// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Playables
public interface IPlayableBehaviour // TypeDefIndex: 16650
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData);
}
