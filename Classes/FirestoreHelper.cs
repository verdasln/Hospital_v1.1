using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Hospital1._0.Classes
{
    internal static class FirestoreHelper
    {
        private static string fireconfig = @"{
      ""type"": ""service_account"",
      ""project_id"": ""hospital-1346a"",
      ""private_key_id"": ""a03e0848fe4e896e2273b416c1253ef23fd0128b"",
      ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCdiky1qmboYkmD\nqe+1DSLOci/a9rSCd/qX0zL9N4nItvJerj3Ds0kja64JmgaQoyDsoqWYIG0x6chx\nL/91MThZIbPR+88vKiS0UANKajLRvqg8MEhJFLnoqGcI3utwFpwVyrCgqhxKTG24\n9FUho33lzdY7AmtJYmVs3BCT0McT/OXZBJR3KAVjHMa3UiI/ckWIhSHDb1HPalpA\nynRZS0OVhzMViqKGVQIzQGy2DYPVXPEC5NUe6njrb8luSb7aEZRGqSaM3SNCPgxj\nnvd0NGl0yu3N1Kkcz3Y3YzFfbRaryGKjHLnS/NZTvmsqsQ47tgiYOTAkemRd4UbI\nV/q/2CRdAgMBAAECggEAAWtiFo7y/2wHSoro8IIuSprnyHrJlJVdKioKfxKViLvx\nQh4iy1UdtxZ8ynRbU8lMfiVXBaBhK352QmLS0+z+G3t8wcsZikzAaOmBphV/4Ljt\njiFHPXVU2X5O81sC1w81F9MsNT5jI949bNmyvKta8ougvwZeDhq3XDw9X/+VE56D\nmk8NMkaKqW0AXNzHyUccrtLdMpzixHJrRSLK0Q3dIMrvInbjAPqJ8XPeJUK19bge\nPeQqQUbXQo/pkbZDbPhTjRTSn+LnR1pwguxrelZm+JzRvOkQGXilQxxAzmz5276c\n29RpVDdluG6BOpiKL7etJubxW2IQn9ieuWr8ipnzVwKBgQDR2X8WwC2ZJNgjDAut\nSFeJH1PS20uNBJQmUjI4Mz6a4T+igeL8za+czSjOoGlVfGhmnOYzv0kkehP16rEh\nw12DGEh7ei2Jzw7RcslET/0ju6iC9zfG7c0Q3XbFd0xUjlgqF7UzuYA6Tu2PbQYF\nV/z3+/gZOpwJ5MwnF0W8MkMIawKBgQDAL8sSDqo/K4426WzCisQL/d+UEKN+2X74\nFLfnPj+8lCvZq7TiQdcRuyVyrQGC6pZ7OIOpM81RO74uSOzgL04tnhEGrJPIKPTD\nIPyLJSKLu2SYeexuogFtejcGYgtkYG5xJTDUg2MO+oe9IiF7qefxXLNt6XgJcPTL\nkfuAaWLYVwKBgAJcIMq/tIORX4DdZNA5DQr0uDuZzbqzP3tC11+8a8rQF6gbL9NJ\n+NyZjgjs0uJsOLxWrVwNnaP0X38XeZB4oveTcVU6JYL0OiVu1gaXo7AgLx/x6cWp\n7PFwnCJSWiBlTWaDx7ziLCf7tT40qqmquKSNR9f4ycJuuUEDSPx50DkrAoGAc6YO\n8B3NCthd6uNKZEL2uDScLtBYYkPlKMnm5ItL9WHAhWrTHXf7QJs6bKh5CVu7FAkt\nCUu32JM33Uha6ojs5XyByF9fSoqCx0z5S44cHLO2VB7CTMzGSSfLJtcm/c8dho6X\ntLofiOrvdbutJGpYvaBIBPMCHcRQOpPtIRfJuF8CgYBUuttPgemPMUav2QhwOC8P\nH2fqJGJu5eE4uP3QQHlqPDlDrPSId9zzUfSMuJT5BEllGwy5snW084XfNOr6SQP3\n97kjbjLa1cKEM065bFKCS3D27E08jbO1LEtHg7vUjZLvbvSxcyILuKdfLSaEmt2d\nCPf9jkNidO1sB3nzWgrC8g==\n-----END PRIVATE KEY-----\n"",
      ""client_email"": ""firebase-adminsdk-blzi3@hospital-1346a.iam.gserviceaccount.com"",
      ""client_id"": ""106090139809565564353"",
      ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
      ""token_uri"": ""https://oauth2.googleapis.com/token"",
      ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
      ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-blzi3%40hospital-1346a.iam.gserviceaccount.com"",
      ""universe_domain"": ""googleapis.com""
    }";

        public static FirestoreDb Database;

        public static void SetEnvironmentVariable()
        {
            var tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json");

            File.WriteAllText(tempFilePath, fireconfig);
            File.SetAttributes(tempFilePath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", tempFilePath);

            Database = FirestoreDb.Create("hospital-1346a");

            // Optionally delete the file after the application exits
            AppDomain.CurrentDomain.ProcessExit += (sender, e) => File.Delete(tempFilePath);
        }
    }
}
