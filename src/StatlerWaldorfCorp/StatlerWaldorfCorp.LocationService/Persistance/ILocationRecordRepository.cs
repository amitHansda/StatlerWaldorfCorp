using StatlerWaldorfCorp.LocationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.LocationService.Persistance
{
    public interface ILocationRecordRepository
    {
        LocationRecord Add(LocationRecord record);
        LocationRecord Update(LocationRecord record);
        LocationRecord Get(Guid memberId, Guid recordId);
        LocationRecord Delete(Guid memberId, Guid recordId);

        LocationRecord GetLatestForMember(Guid memberId);

        ICollection<LocationRecord> AllForMember(Guid memberId);
    }
}
