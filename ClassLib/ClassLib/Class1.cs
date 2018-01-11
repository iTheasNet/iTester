using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using (TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(new Uri(collectionUri)))



namespace ClassLib
{
    public class Class1
    {
        public static void AADSoapSample()
        {
            // Authenticate using Azure Active Directory credential (requires a AAD-backed Visual Studio Team Services Account)
            using (TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(new Uri(collectionUri), new AadCredential()))
            {
                tpc.Authenticate();
                Console.WriteLine(tpc.InstanceId);
            }
        }

    }

}

