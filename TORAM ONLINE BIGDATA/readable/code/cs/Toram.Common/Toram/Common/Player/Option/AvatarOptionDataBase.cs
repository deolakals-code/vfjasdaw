// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Player.Option
public abstract class AvatarOptionDataBase : BinaryBase // TypeDefIndex: 11107
{
	// Properties
	public abstract byte Type { get; }

	// Methods

	// RVA: 0x35BC3A8 Offset: 0x35B83A8 VA: 0x35BC3A8
	public void .ctor() { }

	// RVA: 0x35BC3B0 Offset: 0x35B83B0 VA: 0x35BC3B0
	public void .ctor(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract byte get_Type();

	// RVA: 0x35BC3B8 Offset: 0x35B83B8 VA: 0x35BC3B8
	public byte[] Serialize() { }

	// RVA: 0x35BC59C Offset: 0x35B859C VA: 0x35BC59C
	public bool Deserialize(MemoryStream ms, bool isThrow) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Serialize(MemoryStream ms);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void Deserialize(MemoryStream ms);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool CheckDiff(AvatarOptionDataBase option);

	// RVA: 0x35BC5DC Offset: 0x35B85DC VA: 0x35BC5DC Slot: 3
	public override string ToString() { }

	// RVA: 0x35BC670 Offset: 0x35B8670 VA: 0x35BC670 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35BC690 Offset: 0x35B8690 VA: 0x35BC690 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35BC790 Offset: 0x35B8790 VA: 0x35BC790
	public static AvatarOptionDataBase[] GetAvatarOptionList(byte[] binary) { }
}
