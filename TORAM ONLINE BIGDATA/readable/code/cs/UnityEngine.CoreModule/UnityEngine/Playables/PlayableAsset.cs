// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
[AssetFileNameExtension("playable", new[] {  })]
[Serializable]
public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 16652
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x37FCC6C Offset: 0x37F8C6C VA: 0x37FCC6C Slot: 5
	public virtual double get_duration() { }

	// RVA: 0x37FCCC4 Offset: 0x37F8CC4 VA: 0x37FCCC4 Slot: 6
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCode]
	// RVA: 0x37FCD1C Offset: 0x37F8D1C VA: 0x37FCD1C
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x37FCDF0 Offset: 0x37F8DF0 VA: 0x37FCDF0
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x37FCE18 Offset: 0x37F8E18 VA: 0x37FCE18
	protected void .ctor() { }
}
