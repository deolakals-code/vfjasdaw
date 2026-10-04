// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class ReceiveSupportResult // TypeDefIndex: 4847
{
	// Methods

	// RVA: 0x25E5AC4 Offset: 0x25E1AC4 VA: 0x25E5AC4
	public static void OnActionPlayerSupport(GameReturnCode returnCode, short skillId, byte skillLv, SupportResultData supportData) { }

	// RVA: 0x25E7FEC Offset: 0x25E3FEC VA: 0x25E7FEC
	public static void OnActionNpcSupport(ArchetypeUid archetypeId, short skillId, byte skillLv, SupportResultData supportData) { }

	// RVA: 0x25E8214 Offset: 0x25E4214 VA: 0x25E8214
	public static void OnEventPlayerSupport(short skillId, byte skillLv, byte targetArchetypeType, int targetArchetypeId, SupportResultData supportData) { }

	// RVA: 0x25EAB10 Offset: 0x25E6B10 VA: 0x25EAB10
	public static void OnEventNpcSupport(ArchetypeUid archetypeUid, short skillId, byte lv, int targetId, SupportResultData supportData) { }
}
