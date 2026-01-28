public class EncryptionMethods
{
    // Till krypteringen används Caesarchiffer med H som startposition
    // a b c d e f g h i j k l m n o p q r s t u v w x y z å ä ö
    // H I J K L M N O P Q R S T U V W X Y Z Å Ä Ö A B C D E F G
    // DecryptMe
    // KljycwåTl

    // Metod för kryptering
    public string Encrypt(string plaintext)
    {
        if (string.IsNullOrEmpty(plaintext))
        {
            return "You can't encrypt an empty string!";
        }

        string alphabet = "abcdefghijklmnopqrstuvwxyzåäö";
        string shiftedAlphabet = "hijklmnopqrstuvwxyzåäöabcdefg";
        // Initialiserar en tom sträng för chiffertexten
        string ciphertext = "";
        // Går igenom varje tecken i klartexten
        foreach (char c in plaintext)
        {
            // Hittar tecknets position i alfabetet --> index
            int index = alphabet.IndexOf(char.ToLower(c));
            // om tecknet inte finns i alfabetet (mellanslag, punkt) blir index -1
            if (index != -1)
            {
                char encryptedChar = shiftedAlphabet[index];
                // Kollar om originaltecknet är versal och behåller versal i så fall
                if (char.IsUpper(c))
                {
                    encryptedChar = char.ToUpper(encryptedChar);
                }
                ciphertext += encryptedChar;
            }
            // Tecken som inte är bokstäver ändras inte (mellanslag, punkt osv.)
            else
            {
                ciphertext += c;
            }
        }

        // Returnerat den krypterade texten
        return ciphertext;
    }

    // Metod för dekryptering - samma som ovan, fast tvärtom
    public string Decrypt(string ciphertext)
    {
        if (string.IsNullOrEmpty(ciphertext))
        {
            return "You can't decrypt an empty string!";
        }
        string alphabet = "abcdefghijklmnopqrstuvwxyzåäö";
        string shiftedAlphabet = "hijklmnopqrstuvwxyzåäöabcdefg";
        string plaintext = "";

        // Går igenom alla tecken i chiffertexten
        foreach (char c in ciphertext)
        {
            // Hittar tecknets position i det "krypterade" alfabetet
            int index = shiftedAlphabet.IndexOf(char.ToLower(c));
            if (index != -1)
            {
                char decryptedChar = alphabet[index];
                if (char.IsUpper(c))
                {
                    decryptedChar = char.ToUpper(decryptedChar);
                }
                plaintext += decryptedChar;
            }
            // ändrar inte mellanslag, punkt osv.
            else
            {
                plaintext += c;
            }
        }

        // returnerar den dekrypterade texten
        return plaintext;
    }
}