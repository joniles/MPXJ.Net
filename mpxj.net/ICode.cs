using System.Collections.Generic;

namespace MPXJ.Net;

public interface ICode : IProjectEntityWithUniqueID
{
    int? SequenceNumber { get; }

    string Name { get; }

    bool Secure { get; }

    int? MaxLength { get; }
}