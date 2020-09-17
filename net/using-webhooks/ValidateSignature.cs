// DocSection: webhooks_validate_signature
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using System;
using System.Security.Cryptography;
using System.Text;

// Example of generating the hash to verify the notification
private static string GenerateHash(string message, string secret)
{
    secret = secret ?? "";
    UTF8Encoding SafeUTF8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
    byte[] keyBytes = SafeUTF8.GetBytes(secret);
    byte[] messageBytes = SafeUTF8.GetBytes(message);
    using (HMACSHA256 hmacsha256 = new HMACSHA256(keyBytes))
    {
        byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
        return Convert.ToBase64String(hashmessage);
    }
}
// EndDocSection