var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Skapar ett EncryptionsMethods-objekt för att anropa metoderna
var encryptor = new EncryptionMethods();

app.MapGet("/", () => "Go ahead and encrypt or decrypt text!");
app.MapGet("/encrypt/{plaintext}", (string plaintext) => encryptor.Encrypt(plaintext));
app.MapGet("/decrypt/{ciphertext}", (string ciphertext) => encryptor.Decrypt(ciphertext));

app.Run();

