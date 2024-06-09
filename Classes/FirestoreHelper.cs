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
          ""project_id"": ""hospital-74444"",
          ""private_key_id"": ""18dcb608a7af4d7b0c5a52c3462562f28590692f"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCE/EoayEU2sy6r\noIr0OJ2/Nl9lsgB/kBFj/KSQ0V/GPJz/zDj1JSQMp0vutiwRN/KwPyCIS3Kzvhue\nanb5Knanf1CHLvKrN013ykvLFuKPT9exTbZfSibC9VbVL+PRLlc5kJcJ0mIVRHNa\n4wUJBuvfjxPgOuRkV8E8x13dIMGP4qW0q4ZrHehcOYbfMqorS/Ems0w6pQhGJF4f\nHh2M5g9vMyHp7WJKNACXAVncndHvU6E5OxZQzG0sYny2BOS4JenfUQAsWFzpazG3\nM8Z8gOM/8/TCe9DNjne+M7WQCcZFiKvROQOm8xUsraTORZnv+E2Ly5qlo/2ljH45\n8B0uZ3IZAgMBAAECggEAALNl1/iWGS8+PJD+D0KAHediGJwkqzqdxaTc072JHDdd\npwef68/8PcvUF0GWMsLUds//Jb2EcN5WCp9Qs3uHjTzn9mDNmxARl3zCEJbB7voY\n+4baqLhjj80kRFkHAcDVT7wx3sJuAJYwGtQnU30zmRjWkWzGBaHxWcn9wuIYdJ/K\noisEd8V7H+XvilnDgjHvtA3VCVYprewvn3RIhFkBD4LaDoGSoB4WsgmxVllQYp26\n6E4AApFGc+IIUqIh2+GMxBSvVC6zBzTYbxbZaPn2XY47IjS+HUfAJrc5RbHLy5B9\nAgM1nVzHme3hT8nFzcVzbquCzDz8IkEll6qemiFH4QKBgQC7cz7GP/WvLqtWZlbS\nMCBdVtpE5r6p744Eq6OxVnHtUlm6ob1ezQXZr34Ypfu9bGi9E48pssJU+Rd1LlYP\nZcvF5SijoFe0LEVfUZXsE7ZRM+4KxFR9z1C0z5hl135LTS2JdswpzIQ5qQyR7Qm7\n+m+/qR60te3e99p+R3XojXaHEQKBgQC1nihqVkNk5EXGZ85rc6Gp+7R9nyPYeXP1\nIGBjXlsSbGELPx9GP4hbEhIeAkxKAl5m2HZIMGpfGPOg7PAIyyL948675jtvP6HO\nvSyDLdfYavu6vvozzjIGorfvAf3ncsDIqHgGKljLWQUBL9IhPAZ+mYQwXHg09jTf\n4IeSZoqKiQKBgEIw8cvDrhfMHQiHXsUd5W/QSYbnDBCp3LZdfZITemtZFwJGNr6R\nGy3BQH+nrPs4msuZaoZI70JeKyBf2lfZlFkvEGinKBEhSOXdw1j3pPuLoNUAeu1q\nFY+jdqcPrzMb76aI4pMn+tD5lsy4rSVJy8gcChG55GNFlkvdJA+YVHBhAoGAFBxc\nS1IcClsAovSxtdJLD4CQvuxVUs44Geeo5Lf5C7Q2lsE5nFTCq5r3qJ0Gh5d1jpvf\nlSTPUpJ3v9Ucy0x7JnQIW2QmJq58I2FtQWVdJljKYSZunDfz8CoqhevJisx5Ln8B\nM2WTCYlk9XmvIgD8kx46tgQ3R14QAs5hFMQICUkCgYAUmmwpPjan1CRrLcSUUQPv\n5wypE9p5rQr+YzQ+4xciqwRb60tW+f1toO5J8Xx7kel1qiIFhNCvatsMHVQsDULE\n3ungqVGkdROnHPF8oJ1rHp/kH5XZZ0+1uuzLQ/JBokLHSftmbm5dA8Evt4qTUvQZ\nqw7UW6gLIOiK8b1sQtAHeA==\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-fg0ed@hospital-74444.iam.gserviceaccount.com"",
          ""client_id"": ""112449510630060049469"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-fg0ed%40hospital-74444.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        }";


        private static FirestoreDb Database;

        public static void SetEnvironmentVariable()
        {
            var tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json");

            File.WriteAllText(tempFilePath, fireconfig);
            File.SetAttributes(tempFilePath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", tempFilePath);

            Database = FirestoreDb.Create("hospital-74444");

            // Optionally delete the file after the application exits
            AppDomain.CurrentDomain.ProcessExit += (sender, e) => File.Delete(tempFilePath);

        }
    }
}
