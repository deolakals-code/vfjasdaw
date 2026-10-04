// Assembly: Asobimo.Photon.UnityHash.dll
// Namespace: Asobimo.Photon.UnityHash
public abstract class UnityHashBase // TypeDefIndex: 17909
{
	// Fields
	private string errorMessage; // 0x10
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x18

	// Properties
	public abstract byte Code { get; }
	public bool IsValid { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_Code();

	// RVA: 0x16FE900 Offset: 0x16FA900 VA: 0x16FE900
	public void .ctor() { }

	// RVA: 0x16FE920 Offset: 0x16FA920 VA: 0x16FE920
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x16FE9E0 Offset: 0x16FA9E0 VA: 0x16FE9E0
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x16FE9E8 Offset: 0x16FA9E8 VA: 0x16FE9E8
	protected void set_IsValid(bool value) { }

	// RVA: 0x16FE9F4 Offset: 0x16FA9F4 VA: 0x16FE9F4
	protected void SetErrorMessage(string errorMessage) { }

	// RVA: 0x16FEA00 Offset: 0x16FAA00 VA: 0x16FEA00
	protected void SetErrorMessage(bool valid, string errorMessage) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool SetValue(Dictionary<object, object> parameters);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Dictionary<object, object> GetValue();

	// RVA: -1 Offset: -1
	public static T[] GetArray<T>(Dictionary<object, object> unityHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FA450 Offset: 0x26F6450 VA: 0x26FA450
	|-UnityHashBase.GetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static Dictionary<object, object> GetUnityHash<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FA730 Offset: 0x26F6730 VA: 0x26FA730
	|-UnityHashBase.GetUnityHash<object>
	*/
}
