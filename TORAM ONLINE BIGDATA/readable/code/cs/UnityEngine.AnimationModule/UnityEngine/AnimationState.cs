// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimationState.h")]
public sealed class AnimationState : TrackedReference // TypeDefIndex: 17671
{
	// Properties
	public WrapMode wrapMode { get; set; }
	public float time { get; set; }
	public float normalizedTime { get; set; }
	public float speed { get; set; }
	public float length { get; }
	public AnimationClip clip { get; }
	public string name { get; set; }

	// Methods

	// RVA: 0x37C8570 Offset: 0x37C4570 VA: 0x37C8570
	public WrapMode get_wrapMode() { }

	// RVA: 0x37C85AC Offset: 0x37C45AC VA: 0x37C85AC
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x37C85F0 Offset: 0x37C45F0 VA: 0x37C85F0
	public float get_time() { }

	// RVA: 0x37C862C Offset: 0x37C462C VA: 0x37C862C
	public void set_time(float value) { }

	// RVA: 0x37C8678 Offset: 0x37C4678 VA: 0x37C8678
	public float get_normalizedTime() { }

	// RVA: 0x37C86B4 Offset: 0x37C46B4 VA: 0x37C86B4
	public void set_normalizedTime(float value) { }

	// RVA: 0x37C8700 Offset: 0x37C4700 VA: 0x37C8700
	public float get_speed() { }

	// RVA: 0x37C873C Offset: 0x37C473C VA: 0x37C873C
	public void set_speed(float value) { }

	// RVA: 0x37C8788 Offset: 0x37C4788 VA: 0x37C8788
	public float get_length() { }

	// RVA: 0x37C8430 Offset: 0x37C4430 VA: 0x37C8430
	public AnimationClip get_clip() { }

	// RVA: 0x37C87C4 Offset: 0x37C47C4 VA: 0x37C87C4
	public string get_name() { }

	// RVA: 0x37C8800 Offset: 0x37C4800 VA: 0x37C8800
	public void set_name(string value) { }

	// RVA: 0x37C8844 Offset: 0x37C4844 VA: 0x37C8844
	public void .ctor() { }
}
