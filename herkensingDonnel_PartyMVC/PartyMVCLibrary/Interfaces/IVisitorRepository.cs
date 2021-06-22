using herkensingDonnel_PartyMVC.PartyMVCLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace herkensingDonnel_PartyMVC.PartyMVCLibrary.Interfaces
{
    public interface IVisitorRepository
    {
        void AddVisitor(Visitor visitor);
        int OldestMember();
        int TotalFamilyMembers();
        int TotalMembers();
        int YoungestMember();
    }
}
