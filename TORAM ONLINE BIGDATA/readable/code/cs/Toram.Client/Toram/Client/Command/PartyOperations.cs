// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class PartyOperations // TypeDefIndex: 15141
{
	// Methods

	// RVA: 0x35A4FD8 Offset: 0x35A0FD8 VA: 0x35A4FD8
	public static void Invitation(Game game, int targetArchetypeId, string message) { }

	// RVA: 0x35A50EC Offset: 0x35A10EC VA: 0x35A50EC
	public static void InvitationCancel(Game game, int cancelSenderId, int partyId) { }

	// RVA: 0x35A51F0 Offset: 0x35A11F0 VA: 0x35A51F0
	public static void MemberInvitedCancel(Game game, int cancelTargetId, string cancelTargetName) { }

	// RVA: 0x35A5304 Offset: 0x35A1304 VA: 0x35A5304
	public static void Acceptance(Game game, int senderId, int partyId) { }

	// RVA: 0x35A5408 Offset: 0x35A1408 VA: 0x35A5408
	public static void Secede(Game game) { }

	// RVA: 0x35A5500 Offset: 0x35A1500 VA: 0x35A5500
	public static void Kickout(Game game, byte targetType, int targetId) { }

	// RVA: 0x35A5608 Offset: 0x35A1608 VA: 0x35A5608
	public static void LeaderChange(Game game, int targetId) { }

	// RVA: 0x35A5708 Offset: 0x35A1708 VA: 0x35A5708
	public static void Dissolution(Game game) { }

	// RVA: 0x35A5800 Offset: 0x35A1800 VA: 0x35A5800
	public static void UnreceivedMessage(Game game, DateTime latestPartyMsgTime) { }

	// RVA: 0x35A5914 Offset: 0x35A1914 VA: 0x35A5914
	public static void PartnerJoin(Game game, byte parameterNo, StanceType partnerStance) { }

	// RVA: 0x35A5A30 Offset: 0x35A1A30 VA: 0x35A5A30
	public static void PetJoin(Game game, long petUuid) { }

	// RVA: 0x35A5B44 Offset: 0x35A1B44 VA: 0x35A5B44
	public static void PetList(Game game) { }

	// RVA: 0x35A5C50 Offset: 0x35A1C50 VA: 0x35A5C50
	public static void MercenaryRegisterGet(Game game) { }

	// RVA: 0x35A5D5C Offset: 0x35A1D5C VA: 0x35A5D5C
	public static void MercenaryRegister(Game game, StanceType mercenaryStance, Dictionary<short, byte> skills) { }

	// RVA: 0x35A5E84 Offset: 0x35A1E84 VA: 0x35A5E84
	public static void MercenaryEmploymentList(Game game, MercenaryEmploymentType entryType) { }

	// RVA: 0x35A5F98 Offset: 0x35A1F98 VA: 0x35A5F98
	public static void MercenaryJoin(Game game, int gold, MercenaryEmploymentType employmentType, int mercenaryId, DateTime registerData) { }

	// RVA: 0x35A60CC Offset: 0x35A20CC VA: 0x35A60CC
	public static void CompanionCheckRespawnTime(Game game, byte archetypeType, int archetypeId) { }

	// RVA: 0x35A61E8 Offset: 0x35A21E8 VA: 0x35A61E8
	public static void PetKickout(Game game, int kickPetId) { }

	// RVA: 0x35A62FC Offset: 0x35A22FC VA: 0x35A62FC
	public static void LinkInvitation(Game game, int targetId) { }

	// RVA: 0x35A6410 Offset: 0x35A2410 VA: 0x35A6410
	public static void LinkInviteCancel(Game game, PartyLinkInviteData invite) { }

	// RVA: 0x35A6530 Offset: 0x35A2530 VA: 0x35A6530
	public static void LinkSenderInvitedCancel(Game game) { }

	// RVA: 0x35A663C Offset: 0x35A263C VA: 0x35A663C
	public static void LinkConsent(Game game, PartyLinkInviteData invite) { }

	// RVA: 0x35A675C Offset: 0x35A275C VA: 0x35A675C
	public static void LinkRelease(Game game) { }

	// RVA: 0x35A6868 Offset: 0x35A2868 VA: 0x35A6868
	public static void LotteryRecruitStart(Game game, short exclusionLanguages) { }

	// RVA: 0x35A697C Offset: 0x35A297C VA: 0x35A697C
	public static void LotteryRecruitCancel(Game game) { }

	// RVA: 0x35A6A88 Offset: 0x35A2A88 VA: 0x35A6A88
	public static void LotteryJoin(Game game, int organizerId, int joinPartyId) { }

	// RVA: 0x35A6BA0 Offset: 0x35A2BA0 VA: 0x35A6BA0
	public static void LotteryStart(Game game, string message) { }

	// RVA: 0x35A6CC0 Offset: 0x35A2CC0 VA: 0x35A6CC0
	public static void LotteryInfo(Game game) { }

	// RVA: 0x35A6DCC Offset: 0x35A2DCC VA: 0x35A6DCC
	public static void LotteryListClear(Game game) { }

	// RVA: 0x35A6ED8 Offset: 0x35A2ED8 VA: 0x35A6ED8
	public static void LotteryRecruitReSend(Game game) { }
}
