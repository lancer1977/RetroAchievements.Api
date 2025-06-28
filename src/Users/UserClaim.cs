namespace PolyhydraGames.RetroAchievements.Users;
    public record UserClaim(
        [property: JsonPropertyName("ID")] int ID,
        [property: JsonPropertyName("User")] string User,
        [property: JsonPropertyName("ULID")] string ULID,
        [property: JsonPropertyName("GameID")] int GameID,
        [property: JsonPropertyName("GameTitle")] string GameTitle,
        [property: JsonPropertyName("GameIcon")] string GameIcon,
        [property: JsonPropertyName("ConsoleID")] int ConsoleID,
        [property: JsonPropertyName("ConsoleName")] string ConsoleName,
        [property: JsonPropertyName("ClaimType")] int ClaimType,
        [property: JsonPropertyName("SetType")] int SetType,
        [property: JsonPropertyName("Status")] int Status,
        [property: JsonPropertyName("Extension")] int Extension,
        [property: JsonPropertyName("Special")] int Special,
        [property: JsonPropertyName("Created")] string Created,
        [property: JsonPropertyName("DoneTime")] string DoneTime,
        [property: JsonPropertyName("Updated")] string Updated,
        [property: JsonPropertyName("UserIsJrDev")] int UserIsJrDev,
        [property: JsonPropertyName("MinutesLeft")] int MinutesLeft
    );
    public record UserPoints(
        [property: JsonPropertyName("Points")] int Points,
        [property: JsonPropertyName("SoftcorePoints")] int SoftcorePoints
    );


    public record UserAwardsResponse(
        [property: JsonPropertyName("TotalAwardsCount")] int TotalAwardsCount,
        [property: JsonPropertyName("HiddenAwardsCount")] int HiddenAwardsCount,
        [property: JsonPropertyName("MasteryAwardsCount")] int MasteryAwardsCount,
        [property: JsonPropertyName("CompletionAwardsCount")] int CompletionAwardsCount,
        [property: JsonPropertyName("BeatenHardcoreAwardsCount")] int BeatenHardcoreAwardsCount,
        [property: JsonPropertyName("BeatenSoftcoreAwardsCount")] int BeatenSoftcoreAwardsCount,
        [property: JsonPropertyName("EventAwardsCount")] int EventAwardsCount,
        [property: JsonPropertyName("SiteAwardsCount")] int SiteAwardsCount,
        [property: JsonPropertyName("VisibleUserAwards")] IReadOnlyList<VisibleUserAward> VisibleUserAwards
    );

    public record VisibleUserAward(
        [property: JsonPropertyName("AwardedAt")] DateTime AwardedAt,
        [property: JsonPropertyName("AwardType")] string AwardType,
        [property: JsonPropertyName("AwardData")] int AwardData,
        [property: JsonPropertyName("AwardDataExtra")] int AwardDataExtra,
        [property: JsonPropertyName("DisplayOrder")] int DisplayOrder,
        [property: JsonPropertyName("Title")] string Title,
        [property: JsonPropertyName("ConsoleID")] int ConsoleID,
        [property: JsonPropertyName("ConsoleName")] string ConsoleName,
        [property: JsonPropertyName("Flags")] object Flags,
        [property: JsonPropertyName("ImageIcon")] string ImageIcon
    );
