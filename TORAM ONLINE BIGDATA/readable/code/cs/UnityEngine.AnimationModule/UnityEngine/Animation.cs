// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Animation/Animation.h")]
[DefaultMember("Item")]
public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 17670
{
	// Properties
	public bool playAutomatically { set; }
	public WrapMode wrapMode { set; }
	public bool isPlaying { get; }
	public AnimationState Item { get; }
	public AnimationCullingType cullingType { set; }

	// Methods

	// RVA: 0x37C7A34 Offset: 0x37C3A34 VA: 0x37C7A34
	public void set_playAutomatically(bool value) { }

	// RVA: 0x37C7A78 Offset: 0x37C3A78 VA: 0x37C7A78
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x37C7ABC Offset: 0x37C3ABC VA: 0x37C7ABC
	public void Stop() { }

	// RVA: 0x37C7AF8 Offset: 0x37C3AF8 VA: 0x37C7AF8
	public void Sample() { }

	[NativeName("IsPlaying")]
	// RVA: 0x37C7B34 Offset: 0x37C3B34 VA: 0x37C7B34
	public bool get_isPlaying() { }

	// RVA: 0x37C7B70 Offset: 0x37C3B70 VA: 0x37C7B70
	public bool IsPlaying(string name) { }

	// RVA: 0x37C7BB4 Offset: 0x37C3BB4 VA: 0x37C7BB4
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocs]
	// RVA: 0x37C7C3C Offset: 0x37C3C3C VA: 0x37C7C3C
	public bool Play() { }

	// RVA: 0x37C7C7C Offset: 0x37C3C7C VA: 0x37C7C7C
	public bool Play(PlayMode mode) { }

	[NativeName("Play")]
	// RVA: 0x37C7CC0 Offset: 0x37C3CC0 VA: 0x37C7CC0
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x37C7D04 Offset: 0x37C3D04 VA: 0x37C7D04
	public bool Play(string animation) { }

	// RVA: 0x37C7D4C Offset: 0x37C3D4C VA: 0x37C7D4C
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x37C7DA0 Offset: 0x37C3DA0 VA: 0x37C7DA0
	public void CrossFade(string animation) { }

	[ExcludeFromDocs]
	// RVA: 0x37C7DF0 Offset: 0x37C3DF0 VA: 0x37C7DF0
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x37C7E48 Offset: 0x37C3E48 VA: 0x37C7E48
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x37C7EAC Offset: 0x37C3EAC VA: 0x37C7EAC
	public AnimationState CrossFadeQueued(string animation) { }

	[ExcludeFromDocs]
	// RVA: 0x37C7F00 Offset: 0x37C3F00 VA: 0x37C7F00
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	[ExcludeFromDocs]
	// RVA: 0x37C7F5C Offset: 0x37C3F5C VA: 0x37C7F5C
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = True)]
	// RVA: 0x37C7FC4 Offset: 0x37C3FC4 VA: 0x37C7FC4
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x37C8030 Offset: 0x37C4030 VA: 0x37C8030
	public AnimationState PlayQueued(string animation) { }

	[ExcludeFromDocs]
	// RVA: 0x37C807C Offset: 0x37C407C VA: 0x37C807C
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	[FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = True)]
	// RVA: 0x37C80D4 Offset: 0x37C40D4 VA: 0x37C80D4
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x37C8130 Offset: 0x37C4130 VA: 0x37C8130
	public void AddClip(AnimationClip clip, string newName) { }

	[ExcludeFromDocs]
	// RVA: 0x37C8190 Offset: 0x37C4190 VA: 0x37C8190
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x37C8200 Offset: 0x37C4200 VA: 0x37C8200
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x37C8274 Offset: 0x37C4274 VA: 0x37C8274 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunction("AnimationBindings::GetState", HasExplicitThis = True)]
	// RVA: 0x37C7BF8 Offset: 0x37C3BF8 VA: 0x37C7BF8
	internal AnimationState GetState(string name) { }

	[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37C831C Offset: 0x37C431C VA: 0x37C831C
	internal AnimationState GetStateAtIndex(int index) { }

	[NativeName("GetAnimationStateCount")]
	// RVA: 0x37C8360 Offset: 0x37C4360 VA: 0x37C8360
	internal int GetStateCount() { }

	// RVA: 0x37C839C Offset: 0x37C439C VA: 0x37C839C
	public AnimationClip GetClip(string name) { }

	// RVA: 0x37C846C Offset: 0x37C446C VA: 0x37C846C
	public void set_cullingType(AnimationCullingType value) { }

	// RVA: 0x37C84B0 Offset: 0x37C44B0 VA: 0x37C84B0
	public void .ctor() { }
}
