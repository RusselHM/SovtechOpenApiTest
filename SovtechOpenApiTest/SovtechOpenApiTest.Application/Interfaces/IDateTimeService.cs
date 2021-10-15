using System;
using System.Collections.Generic;
using System.Text;

namespace SovtechOpenApiTest.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
