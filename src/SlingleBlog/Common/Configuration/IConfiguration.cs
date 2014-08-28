﻿using System.Collections.Generic;

namespace SlingleBlog.Common.Configuration
{
    public interface IConfiguration
    {
        string BasePath { get; }

        string StorageBasePath { get; }

        string PublicPath { get; }

        string TempDirectory { get; }

        bool UseErrorPage { get; }

        List<string> DefaultFiles { get; }

        string ApiErrorPolicy { get; }

        string ApiKey { get;}

        string ApiKeyHeaderField { get;}

        string TargetFolderHeaderField { get; }
    }
}