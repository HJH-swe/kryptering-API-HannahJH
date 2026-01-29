using Xunit;
using kryptering_API_HannahJH;

namespace kryptering_API_HannahJH.Tests;

public class XunitTests
{
    // Test av kryptering - bara små bokstäver
    [Fact]
    public void Encrypt_OnlyLowercase_ReturnsEncryptedText()
    {
        // given
        var encryptor = new EncryptionMethods();       // behöver objekt för att anropa metoden
        string plaintext = "abcdefg";
        string expected = "hijklmn";

        // when
        string result = encryptor.Encrypt(plaintext);

        // then
        Assert.Equal(expected, result);
    }

    // Test av kryptering - stora bokstäver, mellanslag och skiljetecken
    [Fact]
    public void Encrypt_UppercaseSpacesPunctuation_ReturnsEncryptedText()
    {
        // given
        var encryptor = new EncryptionMethods();
        string plaintext = "Encrypt This!";
        string expected = "Lujycwå Åopz!";

        // when
        string result = encryptor.Encrypt(plaintext);

        // then
        Assert.Equal(expected, result);
    }

    // Test av kryptering - bokstäver och siffror
    [Fact]
    public void Encrypt_LettersAndNumbers_ReturnsEncryptedText()
    {
        // given
        var encryptor = new EncryptionMethods();
        string plaintext = "Testing123";
        string expected = "Ålzåpun123";

        // when
        string result = encryptor.Encrypt(plaintext);

        // then
        Assert.Equal(expected, result);
    }

    // Test av dekryptering - bara små bokstäver
    [Fact]
    public void Decrypt_OnlyLowercase_ReturnsDecryptedText()
    {
        // given 
        var encryptor = new EncryptionMethods();
        string ciphertext = "xyzåäö";
        string expected = "qrstuv";

        // when
        string result = encryptor.Decrypt(ciphertext);
    
        // then
        Assert.Equal(expected, result);
    }

    // Test av dekryptering - stora bokstäver, mellanslag och skiljetecken
    [Fact]
    public void Decrypt_UppercaseSpacesPunctuation_ReturnsDecryptedText()
    {
        // given
        var encryptor = new EncryptionMethods();
        string ciphertext = "H ölyc zljylå tlzzhnl!";
        string expected = "A very secret message!";

        // when
        string result = encryptor.Decrypt(ciphertext);

        // then
        Assert.Equal(expected, result);
    }

    // Test av dekryptering - bokstäver och siffror
    [Fact]
    public void Decrypt_LettersAndNumbers_ReturnsDecryptedText()
    {
        // given
        var encryptor = new EncryptionMethods();
        string ciphertext ="KljycwåTl123";
        string expected = "DecryptMe123";

        // when
        string result = encryptor.Decrypt(ciphertext);

        // then
        Assert.Equal(expected, result);
    }
}
