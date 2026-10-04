// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIMahjongSettingContentManagerBase : MonoBehaviour // TypeDefIndex: 5954
{
	// Fields
	public readonly string button_on_key; // 0x20
	public readonly string button_off_key; // 0x28

	// Properties
	public virtual UIMahjongSettingContentManagerBase.SettingType settingType { get; }

	// Methods

	// RVA: 0x18524C0 Offset: 0x184E4C0 VA: 0x18524C0 Slot: 4
	public virtual UIMahjongSettingContentManagerBase.SettingType get_settingType() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Initialize(MahjongRoomData roomData);

	// RVA: 0x185243C Offset: 0x184E43C VA: 0x185243C
	protected void .ctor() { }
}
