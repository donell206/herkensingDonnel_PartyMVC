using herkensingDonnel_PartyMVC.PartyMVCLibrary.Interfaces;
using herkensingDonnel_PartyMVC.PartyMVCLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace herkensingDonnel_PartyMVC.PartyMVCLibrary.Repositories
{
    public class VisitorRepository: IVisitorRepository
    {
        private static List<Visitor> _visitors = new List<Visitor>();
        public VisitorRepository()
        {
            SeedData();
        }

        private void SeedData()
        {
            if (!_visitors.Any())
            {
                AddVisitor(new Visitor() { FirstName = "Kenan", SecondName = "Kurda", Address = "Koniging Fabiolalaan", Age = 50, City = "Gent", Email = "Kenan.Kurda@intecbrussel.be", IsFamily = false, PostalCode = 1100, Tel = "0412457894" });
                AddVisitor(new Visitor() { FirstName = "Ruben", SecondName = "Spillebeen", Address = "Koniging Fabiolalaan", Age = 19, City = "Gent", Email = "Kenan.Kurda@intecbrussel.be", IsFamily = true, PostalCode = 1100, Tel = "0412457894" });
                AddVisitor(new Visitor() { FirstName = "Timothy", SecondName = "Hsu", Address = "Koniging Fabiolalaan", Age = 59, City = "Gent", Email = "Kenan.Kurda@intecbrussel.be", IsFamily = false, PostalCode = 1100, Tel = "0412457894" });
            }
        }

        public void AddVisitor(Visitor visitor)
        {
            _visitors.Add(visitor);
        }
        public int OldestMember()
        {
            return _visitors.Max(x => x.Age);
        }
        public int YoungestMember()
        {
            return _visitors.Min(x => x.Age);
        }
        public int TotalMembers()
        {
            return _visitors.Count;
        }
        public int TotalFamilyMembers()
        {
            return _visitors.FindAll(x => x.IsFamily == true).Count;
        }
    }
}
