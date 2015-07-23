using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMP.Web.Entities;

namespace DMP.Web.Data
{
    public interface IDMPRepository
    {
        Profile GetProfileByUserName(string username);
        Profile GetProfile(string memberName);
        List<Profile> GetRandomProfiles(int numberToReturn);

        List<InterestType> GetInterestTypes();

        bool SaveAll();
    }
}
