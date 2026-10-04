// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class TextManagerBase // TypeDefIndex: 5277
{
	// Fields
	public bool IsInitialized; // 0x10
	[CompilerGenerated]
	private bool <IsErr>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <IsLoading>k__BackingField; // 0x12

	// Properties
	public bool IsErr { get; set; }
	public bool IsLoading { get; set; }

	// Methods

	// RVA: 0x261BA80 Offset: 0x2617A80 VA: 0x261BA80
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public virtual T Get<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F6910 Offset: 0x26F2910 VA: 0x26F6910
	|-TextManagerBase.Get<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual T Get<T>(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F6918 Offset: 0x26F2918 VA: 0x26F6918
	|-TextManagerBase.Get<object>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Initialize(byte[] binary);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();

	// RVA: 0x26219D8 Offset: 0x261D9D8 VA: 0x26219D8
	public void LoadingStart() { }

	[CompilerGenerated]
	// RVA: 0x26219E4 Offset: 0x261D9E4 VA: 0x26219E4
	public bool get_IsErr() { }

	[CompilerGenerated]
	// RVA: 0x26219EC Offset: 0x261D9EC VA: 0x26219EC
	protected void set_IsErr(bool value) { }

	[CompilerGenerated]
	// RVA: 0x26219F8 Offset: 0x261D9F8 VA: 0x26219F8
	public bool get_IsLoading() { }

	[CompilerGenerated]
	// RVA: 0x2621A00 Offset: 0x261DA00 VA: 0x2621A00
	protected void set_IsLoading(bool value) { }
}
