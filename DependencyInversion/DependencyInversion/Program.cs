using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory tao instance owner
            //dung instance goi propertis set gia tri
            IPerson owner = Factory.CreatePerson();
            {
                owner.FirstName = "Tim";
                owner.LastName = "Corey";
                owner.EmailAddress = "tim@corey.com";
                owner.PhoneNumber = "555-1212";
            };

            IChore chore = Factory.CreateChore();
            {
                chore.ChoreName = "Take out the trash";
                chore.Owner = owner;
            };

            chore.PerformedWork(3D);
            chore.PerformedWork(1.5D);
            chore.CompleteChore();

        }
    }
}
