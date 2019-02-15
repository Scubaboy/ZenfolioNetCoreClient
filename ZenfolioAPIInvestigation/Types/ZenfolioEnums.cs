﻿namespace ZenfolioAPIInvestigation.Types
{
    public enum ZenfolioAccessType
    {
        Private,
        Public,
        UserList,
        Password
    }

    public enum ZenfolioAccessMask
    {
        None,
        HideDateCreated,
        HideDateModified,
        HideDateTaken,
        HideMetaData,
        HideUserStats,
        HideVisits,
        NoCollections,
        NoPrivateSearch,
        NoPublicSearch,
        NoRecentList,
        ProtectExif,
        ProtectXXLarge,             // new in version 1.3
        ProtectExtraLarge,
        ProtectLarge,
        ProtectMedium,
        ProtectOriginals,
        ProtectGuestbook,             // new in version 1.1
        NoPublicGuestbookPosts,       // new in version 1.1
        NoPrivateGuestbookPosts,      // new in version 1.1
        NoAnonymousGuestbookPosts,    // new in version 1.1
        ProtectComments,              // new in version 1.1
        NoPublicComments,             // new in version 1.1
        NoPrivateComments,            // new in version 1.1
        NoAnonymousComments,          // new in version 1.1
        PasswordProtectOriginals,     // new in version 1.2
        UnprotectCover,               // new in version 1.6
        IncludeRawFilesWithOriginals, // new in version 1.8
        ProtectAll
    }
}