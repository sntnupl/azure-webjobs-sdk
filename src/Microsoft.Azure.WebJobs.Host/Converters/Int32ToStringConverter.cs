﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Globalization;

namespace Microsoft.Azure.WebJobs.Host.Converters
{
    internal class Int32ToStringConverter : IConverter<int, string>
    {
        public string Convert(int input)
        {
            return input.ToString(CultureInfo.InvariantCulture);
        }
    }
}
