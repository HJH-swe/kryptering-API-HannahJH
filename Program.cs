var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Skapar ett EncryptionsMethods-objekt för att anropa metoderna
var encryptor = new EncryptionMethods();

app.MapGet("/", () => "Go ahead and encrypt or decrypt text!");
app.MapGet("/encrypt/{plaintext?}", (string? plaintext) => 
{
    if (string.IsNullOrEmpty(plaintext))
        return "You can't encrypt an empty string!";
    return encryptor.Encrypt(plaintext);
});
app.MapGet("/decrypt/{ciphertext?}", (string? ciphertext) => 
{
    if (string.IsNullOrEmpty(ciphertext))
        return "You can't decrypt an empty string!";
    return encryptor.Decrypt(ciphertext);
});

app.Run();

