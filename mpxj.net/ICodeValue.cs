using System.Collections.Generic;

namespace MPXJ.Net;

public interface ICodeValue  
{
    int? UniqueID { get; }
    
    int? ParentCodeUniqueId { get; }

    int? SequenceNumber { get; }

    string Name { get; }

    string Description { get; }

    int? ParentValueUniqueId { get; }
}